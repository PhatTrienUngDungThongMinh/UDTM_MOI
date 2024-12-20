using BLL;
using DTO;
using KeyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
namespace DoAnUDTM
{
    public partial class frmProductManagement : Form
    {
        CloudinaryService cloud = new CloudinaryService();
        ProductBLL productBLL = new ProductBLL();
        public frmProductManagement()
        {
            InitializeComponent();
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            ProductBLL productBLL = new ProductBLL();
            DsSanPham.DataSource = productBLL.GetAllProducts();
            LoadComboBoxData();
        }
        private void LoadComboBoxData()
        {
          
            CategoryBLL categoryBLL = new CategoryBLL();
            WarrantyPolicyBLL warrantyBLL = new WarrantyPolicyBLL();
            ManufacturerBLL manufacturerBLL = new ManufacturerBLL();
            CountryOfOriginBLL countryBLL = new CountryOfOriginBLL();

           
            cbbDanhMuc.DataSource = categoryBLL.GetAllCategories();
            cbbDanhMuc.DisplayMember = "CategoryName"; 
            cbbDanhMuc.ValueMember = "id"; 

            cbbBaoHanh.DataSource = warrantyBLL.GetAllWarrantyPolicies();
            cbbBaoHanh.DisplayMember = "WarrantyProvider"; 
            cbbBaoHanh.ValueMember = "id"; 

            cbbHangSX.DataSource = manufacturerBLL.GetAllManufacturers();
            cbbHangSX.DisplayMember = "ManufacturerName"; 
            cbbHangSX.ValueMember = "id"; 

            cbbNuocXX.DataSource = countryBLL.GetAllCountries();
            cbbNuocXX.DisplayMember = "CountryName"; 
            cbbNuocXX.ValueMember = "id";
        }

        private void DsSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = DsSanPham.Rows[e.RowIndex];

          
                txtMaSP.Text = row.Cells["id"].Value.ToString();
                txtTenSP.Text = row.Cells["ProductName"].Value.ToString();
                txtGiaGoc.Text = row.Cells["ListedPrice"].Value.ToString();
                txtGiaGiam.Text = row.Cells["PromotionalPrice"].Value.ToString();
                txtTonKho.Text = row.Cells["Stock"].Value.ToString();
                txtMoTa.Text = row.Cells["Description"].Value.ToString();

    
                cbbDanhMuc.SelectedValue = row.Cells["CategoryID"].Value; 
                cbbBaoHanh.SelectedValue = row.Cells["WarrantyPolicyID"].Value;
                cbbHangSX.SelectedValue = row.Cells["ManufacturerID"].Value;
                cbbNuocXX.SelectedValue = row.Cells["CountryID"].Value;
                if (row.Cells["RepresentativeImage"] != null && row.Cells["RepresentativeImage"].Value != null)
                {
                    string imageUrl = row.Cells["RepresentativeImage"].Value.ToString();
                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        try
                        {
                            // Tải ảnh từ URL
                            using (var wc = new System.Net.WebClient())
                            {
                                byte[] data = wc.DownloadData(imageUrl);
                                using (var ms = new System.IO.MemoryStream(data))
                                {
                                    pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Không thể tải ảnh: {ex.Message}");
                        }
                    }
                    else
                    {
                        // Nếu không có URL ảnh, có thể đặt một ảnh mặc định hoặc xóa ảnh cũ
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    // Nếu cột ảnh không có, xóa ảnh cũ nếu có
                    pictureBox1.Image = null;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn thêm sản phẩm này không?",
                                            "Xác nhận",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(txtTenSP.Text))
                    {
                        MessageBox.Show("Tên không được để trống.");
                        return;
                    }

                    string imgUrl = null;

                    if (pictureBox1.Image != null)
                    {
                        string tempFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".jpg");
                        pictureBox1.Image.Save(tempFilePath, ImageFormat.Jpeg);

                        try
                        {
                            imgUrl = cloud.UploadImg(tempFilePath, "categories"); // "categories" là tên thư mục trên Cloudinary, bạn có thể thay đổi
                        }
                        catch (Exception uploadEx)
                        {
                            MessageBox.Show($"Tải ảnh lên Cloudinary thất bại: {uploadEx.Message}");
                            return;
                        }
                        finally
                        {
                            if (File.Exists(tempFilePath))
                            {
                                File.Delete(tempFilePath);
                            }
                        }
                    }

                    var newProduct = new DTO.Product
                    {
                        CategoryID = Convert.ToInt32(cbbDanhMuc.SelectedValue),
                        ManufacturerID = Convert.ToInt32(cbbHangSX.SelectedValue),
                        ProductName = txtTenSP.Text,
                        ListedPrice = Convert.ToInt32(txtGiaGoc.Text),
                        CountryID = Convert.ToInt32(cbbNuocXX.SelectedValue),
                        WarrantyPolicyID = Convert.ToInt32(cbbBaoHanh.SelectedValue),
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now,
                        IsDeleted = false,
                        Stock = 0,
                        RepresentativeImage = imgUrl,
                        Sold = 0,
                        Status = "Active",
                        Description = txtMoTa.Text,
                        PromotionalPrice = Convert.ToInt32(txtGiaGiam.Text)
                    };

                    productBLL.AddProduct(newProduct);
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    pictureBox1.Image = null;
                    txtMaSP.Clear();
                    txtTenSP.Clear();
                    txtGiaGoc.Clear();
                    txtGiaGiam.Clear();
                    txtTonKho.Clear();
                    txtMoTa.Clear();

                    cbbDanhMuc.SelectedIndex = 0;
                    cbbBaoHanh.SelectedIndex = 0;
                    cbbHangSX.SelectedIndex = 0;
                    cbbNuocXX.SelectedIndex = 0;
                    LoadProducts();
                }
            }
            catch
            {
                MessageBox.Show("them that bai");
            }

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu những thay đổi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtMaSP.Text))
                    {
                        MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    ProductBLL productBLL = new ProductBLL();
                    Product updatedProduct = new Product
                    {
                        id = int.Parse(txtMaSP.Text),
                        ProductName = txtTenSP.Text.Trim(),
                        ListedPrice = decimal.Parse(txtGiaGoc.Text),
                        PromotionalPrice = decimal.Parse(txtGiaGiam.Text),
                        Stock = int.Parse(txtTonKho.Text),
                        Sold = 0,
                        Status = "Active",
                        Description = txtMoTa.Text.Trim(),
                        CategoryID = (int)cbbDanhMuc.SelectedValue,
                        WarrantyPolicyID = (int)cbbBaoHanh.SelectedValue,
                        ManufacturerID = (int)cbbHangSX.SelectedValue,
                        CountryID = (int)cbbNuocXX.SelectedValue,
                        updatedAt = DateTime.Now,
                    };

                    productBLL.UpdateProduct(updatedProduct);
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSP.Text))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int productId = int.Parse(txtMaSP.Text);
                    ProductBLL productBLL = new ProductBLL();

                    productBLL.DeleteProduct(productId);
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ProductBLL productBLL = new ProductBLL();
                    Product newProduct = new Product
                    {
                        ProductName = txtTenSP.Text.Trim(),
                        ListedPrice = decimal.Parse(txtGiaGoc.Text),
                        PromotionalPrice = decimal.Parse(txtGiaGiam.Text),
                        Stock = int.Parse(txtTonKho.Text),
                        Sold = 0,
                        Status = "Active",
                        Description = txtMoTa.Text.Trim(),
                        CategoryID = (int)cbbDanhMuc.SelectedValue,
                        WarrantyPolicyID = (int)cbbBaoHanh.SelectedValue,
                        ManufacturerID = (int)cbbHangSX.SelectedValue,
                        CountryID = (int)cbbNuocXX.SelectedValue,
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now,
                    };

                    productBLL.AddProduct(newProduct);  
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox1.Image = System.Drawing.Image.FromFile(filePath);
            }
        }
    }
}
