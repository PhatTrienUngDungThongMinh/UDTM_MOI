﻿using BLL;
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmImportedGoods fm = new frmImportedGoods();
            fm.ShowDialog();
        }
    }
}
