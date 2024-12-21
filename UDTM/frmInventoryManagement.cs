using BLL;
using DTO.ModelHelp;
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
using UDTM;
using static UDTM.frmDeliveryReceiptDetails;

namespace DoAnUDTM
{
    public partial class frmInventoryManagement : Form
    {
        DeliveryReceiptBLL deliveryReceipt = new DeliveryReceiptBLL();
        DeliveryReceiptDetailBLL detail = new DeliveryReceiptDetailBLL();
        SupplierBLL supplierBLL = new SupplierBLL();
        ProductBLL productBLL = new ProductBLL();
        public frmInventoryManagement()
        {
            InitializeComponent();
        }

        private void frmInventoryManagement_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load ()
        {
            DsPhieuNhap.AutoGenerateColumns = false;
            DsPhieuNhap.DataSource = deliveryReceipt.GetAllDeliveryReceipts();
        }
        private void DsPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DsPhieuNhap.Rows[e.RowIndex];
                int Id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                List<DeliveryReceiptDetail> Products = detail.GetProductsByReceiptId(Id);


                List<DetailOrder> productDetails = new List<DetailOrder>();

                foreach (var Product in Products)
                {
                    DetailOrder Detail = new DetailOrder();
                    Detail.ProductID = Product.ProductID;
                    Detail.ProductName = productBLL.GetProductById(Product.ProductID).ProductName;
                    Detail.Price = Product.UnitPrice;
                    Detail.Quanlity = Product.Quantity;
                    productDetails.Add(Detail);
                }
                listProduct.AutoGenerateColumns = false;
                listProduct.DataSource = productDetails;

                idtxt.Text = selectedRow.Cells["id"].Value.ToString();
                int idNCC = int.Parse(selectedRow.Cells["idSupplier"].Value.ToString());
                ncctxt.Text = supplierBLL.findSupplier(idNCC).SupplierName;
                timetxt.Text = selectedRow.Cells["time"].Value.ToString();
                cbbStatus.Text  = selectedRow.Cells["Status"].Value.ToString();
                UpdateComboBoxItems(cbbStatus.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmImportedGoods fm=new frmImportedGoods();
            fm.FormClosed += FrmImportedGoods_FormClosed;
            fm.ShowDialog();
        }
        private void FrmImportedGoods_FormClosed(object sender, FormClosedEventArgs e)
        {
           load();
        }
        private void reset()
        {
            
            idtxt.Clear();
            ncctxt.Clear();
            timetxt.Clear();
            cbbStatus = null;
        }
        private void updateStatusbtn_Click(object sender, EventArgs e)
        {
            if (idtxt.Text == "")
            {
                MessageBox.Show("vui lòng chọn hóa đơn cần cập nhật trạng thái");
            }
            else
            {
                string status = cbbStatus.SelectedItem.ToString();
                deliveryReceipt.UpdateDeliveryReceiptStatus(int.Parse(idtxt.Text),status);
                reset();
                MessageBox.Show("Cập nhật thông tin trạng thái thành công!");
                load();
            }
        }
        private void UpdateComboBoxItems(string currentStatus)
        {
            cbbStatus.Items.Clear();

            if (currentStatus == "Đã đặt hàng")
            {
                cbbStatus.Items.Add("Hủy đơn");
                cbbStatus.Items.Add("Hoàn thành");
            }else if (currentStatus == "Đã Hủy" || currentStatus == "Hoàn thành")
            {
                MessageBox.Show("Đơn hàng đã hoàn tất!");
            }

            cbbStatus.Text = currentStatus;
        }
    }
}
