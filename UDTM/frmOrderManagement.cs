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

namespace DoAnUDTM
{
    public partial class frmOrderManagement : Form
    {
        OrderCustomerBLL orderCustomer = new OrderCustomerBLL();
        OrderProductDetailBLL productDetail = new OrderProductDetailBLL();  
        public frmOrderManagement()
        {
            InitializeComponent();
        }

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            DsHoaDon.DataSource = orderCustomer.GetAllOrderCustomers();
            DsHoaDon.CellClick += DsHoaDon_CellClick;
        }

        private void DsHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DsHoaDon.Rows.Count)
            {
                DataGridViewRow selectedRow = DsHoaDon.Rows[e.RowIndex];

                int orderId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                var orderProducts = productDetail.GetOrderProductsByOrderId(orderId);

       
                var productDetails = new List<ProductDetails>();

                foreach (var orderProduct in orderProducts)
                {

                    var product = productDetail.GetProductById(orderProduct.ProductID);

                    if (product != null)
                    {
                        productDetails.Add(new ProductDetails
                        {
                            ProductID = product.id,
                            ProductName = product.ProductName,
                            ListedPrice = product.ListedPrice,
                            Stock = product.Stock,
                            Description = product.Description,
                            PromotionalPrice = product.PromotionalPrice ?? 0,
                            Status = product.Status,
                            Sold = product.Sold ?? 0,  
                            IsDeleted = product.IsDeleted ?? false,  
                            CategoryID = product.CategoryID ?? 0,  
                            ManufacturerID = product.ManufacturerID ?? 0, 
                            WarrantyPolicyID = product.WarrantyPolicyID ?? 0,  
                            CountryID = product.CountryID ?? 0,
                            CreatedBy = product.CreatedBy,
                            UpdatedBy = product.UpdatedBy

                        });
                    }
                }

                dataGridView1.DataSource = productDetails;


                txtMaHD.Text = selectedRow.Cells["id"].Value?.ToString() ?? string.Empty;
                txtNgayBan.Text = selectedRow.Cells["OrderDate"].Value?.ToString() ?? string.Empty;
                txtTongTien.Text = selectedRow.Cells["TotalAmount"].Value?.ToString() ?? string.Empty;
                txtTrangThai.Text = selectedRow.Cells["OrderStatus"].Value?.ToString() ?? string.Empty;
            }
        }
        public class ProductDetails
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public decimal ListedPrice { get; set; }
            public int Stock { get; set; }
            public string Description { get; set; }
            public decimal PromotionalPrice { get; set; }
            public string Status { get; set; }
            public int Sold { get; set; }
            public bool IsDeleted { get; set; }
            public int CategoryID { get; set; }
            public int ManufacturerID { get; set; }
            public int WarrantyPolicyID { get; set; }
            public int CountryID { get; set; }
            public string CreatedBy { get; set; }
            public string UpdatedBy { get; set; }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            var allOrders = orderCustomer.GetAllOrderCustomers();

            var filteredOrders = allOrders.Where(order =>
                (!string.IsNullOrEmpty(order.OrderStatus) && order.OrderStatus.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(order.TotalAmount.ToString()) && order.TotalAmount.ToString().Contains(keyword)) ||
                (!string.IsNullOrEmpty(order.CustomerID.ToString()) && order.CustomerID.ToString().Contains(keyword)) ||
                (!string.IsNullOrEmpty(order.id.ToString()) && order.id.ToString().Contains(keyword))
            ).ToList();

            DsHoaDon.DataSource = filteredOrders;
            if (!filteredOrders.Any())
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trước khi xác nhận trạng thái!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (cbbTrangThai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái trước khi xác nhận!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int orderId = int.Parse(txtMaHD.Text);
                string newStatus = cbbTrangThai.SelectedItem.ToString();

                var orderToUpdate = new OrderCustomer
                {
                    id = orderId,
                    OrderStatus = newStatus,
                    updatedAt = DateTime.UtcNow 
                };

                orderCustomer.UpdateOrderCustomer(orderToUpdate);

                DsHoaDon.DataSource = orderCustomer.GetAllOrderCustomers();

                MessageBox.Show("Cập nhật trạng thái hóa đơn thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi cập nhật trạng thái: {ex.Message}",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


    }
}
