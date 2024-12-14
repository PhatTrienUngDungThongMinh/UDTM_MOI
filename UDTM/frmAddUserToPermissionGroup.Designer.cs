namespace DoAnUDTM
{
    partial class frmAddUserToPermissionGroup
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lstPermissionGroups = new System.Windows.Forms.ListBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGroups = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPermissions = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPermissionGroups
            // 
            this.lstPermissionGroups.Location = new System.Drawing.Point(437, 263);
            this.lstPermissionGroups.Name = "lstPermissionGroups";
            this.lstPermissionGroups.Size = new System.Drawing.Size(361, 303);
            this.lstPermissionGroups.TabIndex = 1;
            this.lstPermissionGroups.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstPermissionGroups_MouseClick);
            // 
            // dgvMembers
            // 
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Username,
            this.FullName});
            this.dgvMembers.Location = new System.Drawing.Point(12, 50);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(416, 518);
            this.dgvMembers.TabIndex = 3;
            this.dgvMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID tài khoản";
            this.id.Name = "id";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tên tài khoản";
            this.Username.Name = "Username";
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.Name = "FullName";
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Location = new System.Drawing.Point(434, 232);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(129, 13);
            this.lblGroups.TabIndex = 0;
            this.lblGroups.Text = "Danh Sách Nhóm Quyền:";
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Location = new System.Drawing.Point(12, 20);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(123, 13);
            this.lblMembers.TabIndex = 2;
            this.lblMembers.Text = "Thành Viên trong Nhóm:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(129, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtPermissions
            // 
            this.txtPermissions.Location = new System.Drawing.Point(129, 92);
            this.txtPermissions.Name = "txtPermissions";
            this.txtPermissions.Size = new System.Drawing.Size(200, 20);
            this.txtPermissions.TabIndex = 7;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(32, 33);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Tên tài khoản :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Tên nhân viên :";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(129, 117);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(84, 23);
            this.btnAddMember.TabIndex = 11;
            this.btnAddMember.Text = "Thêm";
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(245, 117);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(84, 23);
            this.btnDeleteMember.TabIndex = 12;
            this.btnDeleteMember.Text = "Xóa";
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFullname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.btnDeleteMember);
            this.groupBox1.Controls.Add(this.btnAddMember);
            this.groupBox1.Controls.Add(this.txtPermissions);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Location = new System.Drawing.Point(437, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 174);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thành viên";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(129, 59);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(200, 20);
            this.txtFullname.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quyền đã chọn :";
            // 
            // frmAddUserToPermissionGroup
            // 
            this.ClientSize = new System.Drawing.Size(810, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGroups);
            this.Controls.Add(this.lstPermissionGroups);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.dgvMembers);
            this.Name = "frmAddUserToPermissionGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhóm Quyền và Thành Viên";
            this.Load += new System.EventHandler(this.frmAddUserToPermissionGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.ListBox lstPermissionGroups;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPermissions;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
    }
}