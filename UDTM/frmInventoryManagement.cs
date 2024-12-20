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
using UDTM;

namespace DoAnUDTM
{
    public partial class frmInventoryManagement : Form
    {
        DeliveryReceiptBLL deliveryReceipt = new DeliveryReceiptBLL();
        public frmInventoryManagement()
        {
            InitializeComponent();
        }

        private void frmInventoryManagement_Load(object sender, EventArgs e)
        {
            DsPhieuNhap.DataSource = deliveryReceipt.GetAllDeliveryReceipts();
        }

        private void DsPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DsPhieuNhap.Rows[e.RowIndex];

                txtMaPN.Text = row.Cells["id"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmImportedGoods fm=new frmImportedGoods();
            fm.ShowDialog();
        }

    }
}
