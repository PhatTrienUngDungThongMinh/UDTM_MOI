using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDTM
{
    public partial class frmImportedGoods : Form
    {
        private readonly SupplierBLL _supplierBLL = new SupplierBLL();
        private readonly ProductBLL _productBLL = new ProductBLL();
        private readonly BindingList<DeliveryReceiptDetail> _deliveryReceiptDetails = new BindingList<DeliveryReceiptDetail>();
        private readonly DeliveryReceiptBLL deliveryReceipt = new DeliveryReceiptBLL();
        public frmImportedGoods()
        {
            InitializeComponent();
            _deliveryReceiptDetails = new BindingList<DeliveryReceiptDetail>();
        }

        private void FrmImportedGoods_Load(object sender, EventArgs e)
        {
            try
            {
                var suppliers = _supplierBLL.GetAllSuppliers();
                cmbSupplier.DataSource = suppliers;
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "Id";
                cmbSupplier.SelectedIndex = -1;
                listDSSP.DataSource = _deliveryReceiptDetails;
                listDSSP.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSupplier.SelectedValue != null && int.TryParse(cmbSupplier.SelectedValue.ToString(), out int supplierId))
                {
                    ListProductSupplier.AutoGenerateColumns = false;
                    ListProductSupplier.DataSource = _productBLL.GetAllProducts();
                    ListProductSupplier.ClearSelection();
                }
                else
                {
                    ListProductSupplier.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListProductSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = ListProductSupplier.Rows[e.RowIndex];
                    if (row.Cells["IdSP"].Value != null && row.Cells["ProductName"].Value != null)
                    {
                        if (int.TryParse(row.Cells["IdSP"].Value.ToString(), out int productId))
                        {
                            txtId.Text = productId.ToString();
                            txtSanPham.Text = row.Cells["ProductName"].Value.ToString();
                            txtSLNhap.Enabled = true;
                            txtGiaNhap.Enabled = true;
                            txtSLNhap.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected row contains invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void txtSLNhap_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            if (int.TryParse(txtSLNhap.Text, out int quantity) && int.TryParse(txtGiaNhap.Text, out int unitPrice))
            {
                txtTong.Text = (quantity * unitPrice).ToString();
            }
            else
            {
                txtTong.Text = "0";
            }
        }

        private void ResetForm()
        {
            txtId.Clear();
            txtSanPham.Clear();
            txtSLNhap.Clear();
            txtGiaNhap.Clear();
            txtTong.Clear();
            txtSLNhap.Enabled = false;
            txtGiaNhap.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtId.Text, out int productId) &&
                    int.TryParse(txtSLNhap.Text, out int quantity) &&
                    int.TryParse(txtGiaNhap.Text, out int unitPrice))
                {
                    var existingDetail = _deliveryReceiptDetails.FirstOrDefault(d => d.ProductID == productId);
                    if (existingDetail != null)
                    {
                        existingDetail.Quantity += quantity;
                        existingDetail.TotalPrice = existingDetail.Quantity * existingDetail.UnitPrice;
                    }
                    else
                    {
                        var deliveryDetail = new DeliveryReceiptDetail
                        {
                            ProductID = productId,
                            Quantity = quantity,
                            UnitPrice = unitPrice,
                            TotalPrice = quantity * unitPrice,
                            updatedAt = DateTime.Now,
                            createdAt = DateTime.Now
                            
                        };
                        _deliveryReceiptDetails.Add(deliveryDetail);
                    }
                    var filteredDetails = _deliveryReceiptDetails
                        .Select(d => new
                        {
                            id = d.ProductID,
                            Quantity = d.Quantity,
                            UnitPrice = d.UnitPrice,
                            TotalPrice = d.TotalPrice
                        })
                        .ToList();

                    listDSSP.DataSource = filteredDetails;

                    ResetForm();
                    cmbSupplier.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for Quantity and Unit Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the delivery detail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            _deliveryReceiptDetails.Clear();
            cmbSupplier.Enabled = true;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng DeliveryReceipt
                DeliveryReceipt d = new DeliveryReceipt
                {
                    SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue),
                    DeliveryDate = DateTime.Now,
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now,
                    EmployeeID = 1,
                    Status = "Chờ xác nhận"
                };



                deliveryReceipt.AddDeliveryReceipt(d, _deliveryReceiptDetails);
                MessageBox.Show("Delivery receipt has been successfully imported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                _deliveryReceiptDetails.Clear();
                listDSSP.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Product> list = _productBLL.GetAllProducts();
            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm hợp lệ.");
            }
            else
            {
                list = list.Where(o => o.id == int.Parse(textBox1.Text)).ToList();
                if (list.Count > 0)
                    ListProductSupplier.DataSource = list;
                else
                    ListProductSupplier.DataSource = null;
            }

           
        }
    }
}
