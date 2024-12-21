using System.Drawing;
using System.Windows.Forms;

namespace DoAnUDTM
{
    partial class frmInventoryManagement
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timetxt = new System.Windows.Forms.TextBox();
            this.ncctxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.updateStatusbtn = new System.Windows.Forms.Button();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listProduct = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DsPhieuNhap = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanlity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.timetxt);
            this.groupBox3.Controls.Add(this.ncctxt);
            this.groupBox3.Controls.Add(this.idtxt);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.updateStatusbtn);
            this.groupBox3.Controls.Add(this.cbbStatus);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.listProduct);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.DsPhieuNhap);
            this.groupBox3.Location = new System.Drawing.Point(12, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 504);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phiếu Nhập";
            // 
            // timetxt
            // 
            this.timetxt.Enabled = false;
            this.timetxt.Location = new System.Drawing.Point(569, 420);
            this.timetxt.Name = "timetxt";
            this.timetxt.Size = new System.Drawing.Size(211, 20);
            this.timetxt.TabIndex = 14;
            // 
            // ncctxt
            // 
            this.ncctxt.Enabled = false;
            this.ncctxt.Location = new System.Drawing.Point(569, 383);
            this.ncctxt.Name = "ncctxt";
            this.ncctxt.Size = new System.Drawing.Size(211, 20);
            this.ncctxt.TabIndex = 13;
            // 
            // idtxt
            // 
            this.idtxt.Enabled = false;
            this.idtxt.Location = new System.Drawing.Point(569, 346);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(211, 20);
            this.idtxt.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(466, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Trạng thái:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thời gian lập:";
            // 
            // updateStatusbtn
            // 
            this.updateStatusbtn.Location = new System.Drawing.Point(706, 450);
            this.updateStatusbtn.Name = "updateStatusbtn";
            this.updateStatusbtn.Size = new System.Drawing.Size(75, 41);
            this.updateStatusbtn.TabIndex = 6;
            this.updateStatusbtn.Text = "cập nhật trạng thái";
            this.updateStatusbtn.UseVisualStyleBackColor = true;
            this.updateStatusbtn.Click += new System.EventHandler(this.updateStatusbtn_Click);
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(569, 460);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(130, 21);
            this.cbbStatus.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nhà cung cấp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã phiếu nhập:";
            // 
            // listProduct
            // 
            this.listProduct.AllowUserToAddRows = false;
            this.listProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduct,
            this.ProductName,
            this.Quanlity,
            this.Price});
            this.listProduct.Location = new System.Drawing.Point(464, 42);
            this.listProduct.Name = "listProduct";
            this.listProduct.RowHeadersVisible = false;
            this.listProduct.RowHeadersWidth = 51;
            this.listProduct.Size = new System.Drawing.Size(316, 288);
            this.listProduct.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(716, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(613, 162);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(403, 32);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(403, 66);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Nhà Cung Cấp";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 102);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 66);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu nhập :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaPN);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 46);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác Vụ";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(447, 16);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(287, 20);
            this.txtMaPN.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm phiếu nhập hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button3_Click);
            // 
            // DsPhieuNhap
            // 
            this.DsPhieuNhap.AllowUserToAddRows = false;
            this.DsPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DsPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idSupplier,
            this.Status,
            this.time});
            this.DsPhieuNhap.Location = new System.Drawing.Point(6, 42);
            this.DsPhieuNhap.Name = "DsPhieuNhap";
            this.DsPhieuNhap.RowHeadersVisible = false;
            this.DsPhieuNhap.RowHeadersWidth = 51;
            this.DsPhieuNhap.Size = new System.Drawing.Size(452, 456);
            this.DsPhieuNhap.TabIndex = 0;
            this.DsPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DsPhieuNhap_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã phiếu nhập";
            this.id.Name = "id";
            // 
            // idSupplier
            // 
            this.idSupplier.DataPropertyName = "SupplierID";
            this.idSupplier.HeaderText = "Mã nhà cung cấp";
            this.idSupplier.Name = "idSupplier";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            // 
            // time
            // 
            this.time.DataPropertyName = "DeliveryDate";
            this.time.HeaderText = "Thời gian lập";
            this.time.Name = "time";
            this.time.Width = 150;
            // 
            // idProduct
            // 
            this.idProduct.DataPropertyName = "ProductID";
            this.idProduct.HeaderText = "Mã sản phẩm";
            this.idProduct.Name = "idProduct";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            // 
            // Quanlity
            // 
            this.Quanlity.DataPropertyName = "Quanlity";
            this.Quanlity.HeaderText = "Số lượng";
            this.Quanlity.Name = "Quanlity";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá nhập";
            this.Price.Name = "Price";
            // 
            // frmInventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmInventoryManagement";
            this.Text = "frmInventoryManagement";
            this.Load += new System.EventHandler(this.frmInventoryManagement_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private TextBox txtMaPN;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Label label7;
        private Label label6;
        private DataGridView listProduct;
        private Label label8;
        private Button updateStatusbtn;
        private Label label12;
        private ComboBox cbbStatus;
        private TextBox timetxt;
        private TextBox ncctxt;
        private TextBox idtxt;
        private DataGridView DsPhieuNhap;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn idSupplier;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn idProduct;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quanlity;
        private DataGridViewTextBoxColumn Price;
    }
}
