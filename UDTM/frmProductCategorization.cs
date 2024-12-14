using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyLibrary;
using System.Drawing.Imaging;
using System.IO;
namespace DoAnUDTM
{
    public partial class frmProductCategorization : Form
    {
        CategoryBLL category = new CategoryBLL();
        CloudinaryService cloud = new CloudinaryService();
        public frmProductCategorization()
        {
            InitializeComponent();
        }

        private void frmProductCategorization_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            DsDanhMuc.DataSource = category.GetAllCategories();
            DsDanhMuc.CellClick += DsDanhMuc_CellClick;
        }


        private void DsDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = DsDanhMuc.Rows[e.RowIndex];

                txtMaDM.Text = row.Cells["id"].Value.ToString();
                txtTenDM.Text = row.Cells["CategoryName"].Value.ToString();
                txtCreate.Text = row.Cells["createdAt"].Value.ToString();
                txtupdate.Text = row.Cells["updatedAt"].Value.ToString();
                if (row.Cells["pathImg"] != null && row.Cells["pathImg"].Value != null)
                {
                    string imageUrl = row.Cells["pathImg"].Value.ToString();
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
                                    pictureBox1.Image = Image.FromStream(ms);
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
                var result = MessageBox.Show("Bạn có chắc chắn muốn thêm danh mục này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(txtTenDM.Text))
                    {
                        MessageBox.Show("Tên danh mục không được để trống.");
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

                    var newCategory = new DTO.Category
                    {
                        CategoryName = txtTenDM.Text,
                        pathImg = imgUrl,  
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now
                    };

                    category.AddCategory(newCategory); 
                    MessageBox.Show("Thêm danh mục thành công!");
                    LoadCategories();
                    txtTenDM.Clear();
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }


        // Xóa Category
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaDM.Text))
                {
                    MessageBox.Show("Chưa chọn danh mục để xóa.");
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int categoryId = Convert.ToInt32(txtMaDM.Text);
                    try
                    {
                        category.DeleteCategory(categoryId);
                        MessageBox.Show("Xóa danh mục thành công!");
                        LoadCategories();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("FK"))
                        {
                            MessageBox.Show("Vui lòng xử lý các khóa ngoại trước khi xóa danh mục này.");
                        }
                        else
                        {
                            MessageBox.Show($"Lỗi: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaDM.Text) || string.IsNullOrWhiteSpace(txtTenDM.Text))
                {
                    MessageBox.Show("Vui lòng chọn danh mục và nhập tên danh mục.");
                    return;
                }

                int categoryId = Convert.ToInt32(txtMaDM.Text);

                var result = MessageBox.Show("Bạn có chắc chắn muốn sửa danh mục này không?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var currentCategory = category.GetAllCategories().FirstOrDefault(c => c.id == categoryId);

                    if (currentCategory == null)
                    {
                        MessageBox.Show("Danh mục không tồn tại.");
                        return;
                    }

                    var updatedCategory = new DTO.Category
                    {
                        id = categoryId,
                        CategoryName = txtTenDM.Text,
                        createdAt = currentCategory.createdAt,
                        updatedAt = DateTime.Now
                    };

                    category.UpdateCategory(updatedCategory);

                    MessageBox.Show("Cập nhật danh mục thành công!");
                    LoadCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Chỉ cho phép chọn file ảnh

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(filePath);
            }
        }
    }
}
