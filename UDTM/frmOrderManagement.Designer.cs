using System.Drawing;
using System.Windows.Forms;

namespace DoAnUDTM
{
    partial class frmOrderManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gr = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DsHoaDon = new System.Windows.Forms.DataGridView();
            this.idOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nameCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanlity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtNgayBan = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gr
            // 
            this.gr.Controls.Add(this.label2);
            this.gr.Controls.Add(this.label1);
            this.gr.Controls.Add(this.textBox1);
            this.gr.Controls.Add(this.comboBox1);
            this.gr.Controls.Add(this.DsHoaDon);
            this.gr.Location = new System.Drawing.Point(12, 83);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(423, 527);
            this.gr.TabIndex = 1;
            this.gr.TabStop = false;
            this.gr.Text = "Danh sách hóa đơn đã bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trạng thái:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chờ xác nhận",
            "Đã xác nhận",
            "Chờ giao hàng",
            "Hoàn thành",
            "Hủy"});
            this.comboBox1.Location = new System.Drawing.Point(289, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // DsHoaDon
            // 
            this.DsHoaDon.AllowUserToResizeColumns = false;
            this.DsHoaDon.AllowUserToResizeRows = false;
            this.DsHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DsHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrder,
            this.Customer,
            this.Status,
            this.TotalAmount,
            this.promotion,
            this.orderDate});
            this.DsHoaDon.Location = new System.Drawing.Point(6, 56);
            this.DsHoaDon.Name = "DsHoaDon";
            this.DsHoaDon.RowHeadersVisible = false;
            this.DsHoaDon.RowHeadersWidth = 51;
            this.DsHoaDon.Size = new System.Drawing.Size(404, 451);
            this.DsHoaDon.TabIndex = 0;
            this.DsHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DsHoaDon_CellClick);
            // 
            // idOrder
            // 
            this.idOrder.DataPropertyName = "id";
            this.idOrder.HeaderText = "Mã hóa đơn";
            this.idOrder.Name = "idOrder";
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "CustomerID";
            this.Customer.HeaderText = "Khách hàng";
            this.Customer.Name = "Customer";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "OrderStatus";
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "Tổng tiền đơn hàng";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // promotion
            // 
            this.promotion.DataPropertyName = "PromotionID";
            this.promotion.HeaderText = "Mã khuyễn mãi (nếu có) ";
            this.promotion.Name = "promotion";
            // 
            // orderDate
            // 
            this.orderDate.DataPropertyName = "OrderDate";
            this.orderDate.HeaderText = "Thời gian đặt hàng";
            this.orderDate.Name = "orderDate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(156, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(289, 20);
            this.txtTimKiem.TabIndex = 38;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(488, 14);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 29);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameCustomer);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbbTrangThai);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtTrangThai);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.txtNgayBan);
            this.groupBox2.Controls.Add(this.txtMaHD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(441, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 527);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chung";
            // 
            // nameCustomer
            // 
            this.nameCustomer.Enabled = false;
            this.nameCustomer.Location = new System.Drawing.Point(74, 118);
            this.nameCustomer.Name = "nameCustomer";
            this.nameCustomer.Size = new System.Drawing.Size(270, 20);
            this.nameCustomer.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Khách hàng";
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Đã xác nhận",
            "Đã hủy",
            "Hoàn thành",
            "Chờ giao hàng",
            "Chờ xác nhận"});
            this.cbbTrangThai.Location = new System.Drawing.Point(36, 500);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(140, 21);
            this.cbbTrangThai.TabIndex = 37;
            this.cbbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbbTrangThai_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 30);
            this.button2.TabIndex = 33;
            this.button2.Text = "Xác nhận";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(6, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 335);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm theo hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ProductName,
            this.Quanlity,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(332, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "ProductID";
            this.id.HeaderText = "Mã sản phẩm";
            this.id.Name = "id";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            // 
            // Quanlity
            // 
            this.Quanlity.DataPropertyName = "quanlity";
            this.Quanlity.HeaderText = "Số lượng";
            this.Quanlity.Name = "Quanlity";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Giá tiền";
            this.Price.Name = "Price";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Location = new System.Drawing.Point(255, 74);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(96, 20);
            this.txtTrangThai.TabIndex = 35;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(255, 31);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(96, 20);
            this.txtTongTien.TabIndex = 34;
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.Enabled = false;
            this.txtNgayBan.Location = new System.Drawing.Point(74, 73);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Size = new System.Drawing.Size(102, 20);
            this.txtNgayBan.TabIndex = 33;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(74, 31);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(102, 20);
            this.txtMaHD.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tổng tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Trạng thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ngày Đặt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã Hóa Đơn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gr);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOrderManagement";
            this.Text = "frmOrderManagement";
            this.Load += new System.EventHandler(this.frmOrderManagement_Load);
            this.gr.ResumeLayout(false);
            this.gr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gr;
        private DataGridView DsHoaDon;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtNgayBan;
        private TextBox txtMaHD;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnTimKiem;
        private Button button2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private TextBox txtTrangThai;
        private TextBox txtTongTien;
        private ComboBox cbbTrangThai;
        private TextBox txtTimKiem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quanlity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn idOrder;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn promotion;
        private DataGridViewTextBoxColumn orderDate;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox nameCustomer;
        private Label label3;
        private TextBox textBox1;
    }
}