namespace UDTM
{
    partial class frmImportedGoods
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
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listDSSP = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ListProductSupplier = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IdSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listDSSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListProductSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(94, 22);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(227, 21);
            this.cmbSupplier.TabIndex = 1;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(18, 24);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(78, 13);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Nhà cung cấp:";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(646, 317);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(68, 24);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Nhập hàng";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(729, 317);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 24);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listDSSP);
            this.groupBox1.Location = new System.Drawing.Point(333, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 261);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm nhập";
            // 
            // listDSSP
            // 
            this.listDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Quantity,
            this.UnitPrice,
            this.TotalPrice});
            this.listDSSP.Location = new System.Drawing.Point(6, 19);
            this.listDSSP.Name = "listDSSP";
            this.listDSSP.Size = new System.Drawing.Size(443, 236);
            this.listDSSP.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã sản phẩm";
            this.id.Name = "id";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Giá nhập";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Tổng tiền";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSLNhap);
            this.groupBox2.Controls.Add(this.txtGiaNhap);
            this.groupBox2.Controls.Add(this.txtTong);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ListProductSupplier);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSanPham);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 298);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm nhà cung cấp";
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Enabled = false;
            this.txtSLNhap.Location = new System.Drawing.Point(97, 231);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(125, 20);
            this.txtSLNhap.TabIndex = 20;
            this.txtSLNhap.TextChanged += new System.EventHandler(this.txtGiaNhap_TextChanged);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Enabled = false;
            this.txtGiaNhap.Location = new System.Drawing.Point(97, 201);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(125, 20);
            this.txtGiaNhap.TabIndex = 19;
            this.txtGiaNhap.TextChanged += new System.EventHandler(this.txtGiaNhap_TextChanged);
            // 
            // txtTong
            // 
            this.txtTong.Enabled = false;
            this.txtTong.Location = new System.Drawing.Point(97, 262);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(125, 20);
            this.txtTong.TabIndex = 18;
            this.txtTong.Text = "0";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(34, 167);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(32, 20);
            this.txtId.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(227, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "đ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng tiền :";
            // 
            // ListProductSupplier
            // 
            this.ListProductSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListProductSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSP,
            this.ProductName});
            this.ListProductSupplier.Location = new System.Drawing.Point(6, 48);
            this.ListProductSupplier.Name = "ListProductSupplier";
            this.ListProductSupplier.Size = new System.Drawing.Size(303, 114);
            this.ListProductSupplier.TabIndex = 12;
            this.ListProductSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListProductSupplier_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "đ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá nhập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng nhập :";
            // 
            // txtSanPham
            // 
            this.txtSanPham.Location = new System.Drawing.Point(192, 168);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(117, 20);
            this.txtSanPham.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sản phẩm đã chọn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IdSP
            // 
            this.IdSP.DataPropertyName = "id";
            this.IdSP.HeaderText = "Mã Sản phẩm";
            this.IdSP.Name = "IdSP";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            // 
            // frmImportedGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmImportedGoods";
            this.Text = "Phiếu Nhập Hàng";
            this.Load += new System.EventHandler(this.FrmImportedGoods_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listDSSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListProductSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnCancel;
        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listDSSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSanPham;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ListProductSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
    }
}