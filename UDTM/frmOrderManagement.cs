using BLL;
using DTO;
using DTO.ModelHelp;
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
            DsHoaDon.AutoGenerateColumns = false;
            List<OrderCustomer> order = orderCustomer.GetAllOrderCustomers();
            order = order.Where(o => o.OrderStatus == "Chờ xác nhận" || o.OrderStatus == "Đã xác nhận"||
                                      o.OrderStatus == "Chờ giao hàng").ToList();
            DsHoaDon.DataSource = order;
            DsHoaDon.CellClick += DsHoaDon_CellClick;
        }

        private void DsHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DsHoaDon.Rows.Count)
            {
                DataGridViewRow selectedRow = DsHoaDon.Rows[e.RowIndex];

                int orderId = Convert.ToInt32(selectedRow.Cells["idOrder"].Value);

                var orderProducts = productDetail.GetOrderProductsByOrderId(orderId);


                List<DetailOrder> productDetailsOrder = new List<DetailOrder>();

                foreach (var orderProduct in orderProducts)
                {
                    Product product = productDetail.GetProductById(orderProduct.ProductID);

                    if (product != null)
                    {
                        DetailOrder orderDetail = new DetailOrder();
                        orderDetail.ProductID = orderProduct.ProductID;
                        orderDetail.ProductName = product.ProductName;
                        orderDetail.Price = (decimal)product.PromotionalPrice;
                        orderDetail.Quanlity = orderProduct.Quantity;
                        productDetailsOrder.Add(orderDetail);
                    }

                }
                dataGridView1.AutoGenerateColumns = false;
                
                dataGridView1.DataSource = productDetailsOrder;


                txtMaHD.Text = selectedRow.Cells["idOrder"].Value?.ToString() ?? string.Empty;
                txtNgayBan.Text = selectedRow.Cells["OrderDate"].Value?.ToString() ?? string.Empty;
                txtTongTien.Text = selectedRow.Cells["TotalAmount"].Value?.ToString() ?? string.Empty;
                txtTrangThai.Text = selectedRow.Cells["Status"].Value?.ToString() ?? string.Empty;
                cbbTrangThai.Text = selectedRow.Cells["Status"].Value?.ToString() ?? string.Empty;
                UpdateComboBoxItems(txtTrangThai.Text);
            }
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
                orderCustomer.UpdateOrderStatus(orderId, newStatus);

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
        private void UpdateComboBoxItems(string currentStatus)
        {
            cbbTrangThai.Items.Clear();

            if (currentStatus == "Chờ xác nhận")
            {
                cbbTrangThai.Items.Add("Hủy đơn");
                cbbTrangThai.Items.Add("Đã xác nhận");
            }
            else if (currentStatus == "Đã xác nhận")
            {
                cbbTrangThai.Items.Add("Chờ giao hàng");
            }
            else if (currentStatus == "Chờ giao hàng")
            {
                cbbTrangThai.Items.Add("Hoàn thành");
            }
            else if (currentStatus == "Đã Hủy" || currentStatus == "Hoàn thành")
            {
                MessageBox.Show("Đơn hàng đã hoàn tất!");
            }

            cbbTrangThai.Text = currentStatus;
        }



    }
}
