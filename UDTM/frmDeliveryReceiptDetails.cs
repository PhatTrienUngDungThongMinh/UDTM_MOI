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
using static DoAnUDTM.frmOrderManagement;

namespace UDTM
{
    public partial class frmDeliveryReceiptDetails : Form
    {
        DeliveryReceiptDetailBLL deliveryReceiptDetailBLL=new DeliveryReceiptDetailBLL();
        DeliveryReceiptBLL delivery=new DeliveryReceiptBLL();
        public frmDeliveryReceiptDetails()
        {
            InitializeComponent();
        }

        private void frmDeliveryReceiptDetails_Load(object sender, EventArgs e)
        {
            DsPhieuNhap.DataSource = delivery.GetAllDeliveryReceipts();
            DsPhieuNhap.CellClick += DsCTPhieuNhap_CellClick1;
        }

        private void DsCTPhieuNhap_CellClick1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DsPhieuNhap.Rows.Count)
            {
                DataGridViewRow selectedRow = DsPhieuNhap.Rows[e.RowIndex];
                int receiptId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                var productIds = deliveryReceiptDetailBLL.GetProductIdsByReceiptId(receiptId);

                var productDetails = new List<ProductDetails>();
                foreach (var productId in productIds)
                {
                    var product = new ProductBLL().GetProductById(productId);

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

                // Hiển thị danh sách sản phẩm vào DSSP
                DSSP.DataSource = productDetails;
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
    }
}
