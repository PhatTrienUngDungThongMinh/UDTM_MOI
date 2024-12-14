using System.Drawing;
using System.Windows.Forms;

namespace DoAnUDTM
{
    partial class frmRoleManagement
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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.idPermission = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addPermissions = new System.Windows.Forms.Button();
            this.deletePermissions = new System.Windows.Forms.Button();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.editPermissions = new System.Windows.Forms.Button();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.groupBoxPermissions = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.chkAllPermissions = new System.Windows.Forms.CheckBox();
            this.chkListPermissions = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListPermissions = new System.Windows.Forms.DataGridView();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxPermissions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.idPermission);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.addPermissions);
            this.groupBoxInfo.Controls.Add(this.deletePermissions);
            this.groupBoxInfo.Controls.Add(this.txtRoleName);
            this.groupBoxInfo.Controls.Add(this.editPermissions);
            this.groupBoxInfo.Controls.Add(this.lblRoleName);
            this.groupBoxInfo.Location = new System.Drawing.Point(20, 21);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(522, 100);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin nhóm quyền";
            // 
            // idPermission
            // 
            this.idPermission.Enabled = false;
            this.idPermission.Location = new System.Drawing.Point(100, 30);
            this.idPermission.Name = "idPermission";
            this.idPermission.Size = new System.Drawing.Size(229, 20);
            this.idPermission.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã quyền:";
            // 
            // addPermissions
            // 
            this.addPermissions.Location = new System.Drawing.Point(343, 30);
            this.addPermissions.Name = "addPermissions";
            this.addPermissions.Size = new System.Drawing.Size(75, 20);
            this.addPermissions.TabIndex = 4;
            this.addPermissions.Text = "Thêm";
            this.addPermissions.UseVisualStyleBackColor = true;
            this.addPermissions.Click += new System.EventHandler(this.addPermissions_Click);
            // 
            // deletePermissions
            // 
            this.deletePermissions.Location = new System.Drawing.Point(343, 58);
            this.deletePermissions.Name = "deletePermissions";
            this.deletePermissions.Size = new System.Drawing.Size(75, 23);
            this.deletePermissions.TabIndex = 2;
            this.deletePermissions.Text = "Xóa quyền";
            this.deletePermissions.UseVisualStyleBackColor = true;
            this.deletePermissions.Click += new System.EventHandler(this.deletePermissions_Click);
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(100, 61);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(229, 20);
            this.txtRoleName.TabIndex = 2;
            // 
            // editPermissions
            // 
            this.editPermissions.Location = new System.Drawing.Point(428, 30);
            this.editPermissions.Name = "editPermissions";
            this.editPermissions.Size = new System.Drawing.Size(75, 20);
            this.editPermissions.TabIndex = 1;
            this.editPermissions.Text = "Sửa Quyền";
            this.editPermissions.UseVisualStyleBackColor = true;
            this.editPermissions.Click += new System.EventHandler(this.editPermissions_Click);
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(20, 61);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(70, 13);
            this.lblRoleName.TabIndex = 0;
            this.lblRoleName.Text = "Nhóm quyền:";
            // 
            // groupBoxPermissions
            // 
            this.groupBoxPermissions.Controls.Add(this.cancel);
            this.groupBoxPermissions.Controls.Add(this.save);
            this.groupBoxPermissions.Controls.Add(this.chkAllPermissions);
            this.groupBoxPermissions.Controls.Add(this.chkListPermissions);
            this.groupBoxPermissions.Location = new System.Drawing.Point(548, 21);
            this.groupBoxPermissions.Name = "groupBoxPermissions";
            this.groupBoxPermissions.Size = new System.Drawing.Size(232, 386);
            this.groupBoxPermissions.TabIndex = 1;
            this.groupBoxPermissions.TabStop = false;
            this.groupBoxPermissions.Text = "Chọn quyền";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(17, 341);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Hủy";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(140, 341);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Lưu ";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // chkAllPermissions
            // 
            this.chkAllPermissions.AutoSize = true;
            this.chkAllPermissions.Location = new System.Drawing.Point(17, 19);
            this.chkAllPermissions.Name = "chkAllPermissions";
            this.chkAllPermissions.Size = new System.Drawing.Size(107, 17);
            this.chkAllPermissions.TabIndex = 1;
            this.chkAllPermissions.Text = "Chọn toàn quyền";
            this.chkAllPermissions.UseVisualStyleBackColor = true;
            this.chkAllPermissions.CheckedChanged += new System.EventHandler(this.chkAllPermissions_CheckedChanged);
            // 
            // chkListPermissions
            // 
            this.chkListPermissions.FormattingEnabled = true;
            this.chkListPermissions.Location = new System.Drawing.Point(17, 46);
            this.chkListPermissions.Name = "chkListPermissions";
            this.chkListPermissions.Size = new System.Drawing.Size(198, 289);
            this.chkListPermissions.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListPermissions);
            this.groupBox2.Location = new System.Drawing.Point(20, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 280);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các quyền đã thêm";
            // 
            // ListPermissions
            // 
            this.ListPermissions.AllowUserToResizeColumns = false;
            this.ListPermissions.AllowUserToResizeRows = false;
            this.ListPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListPermissions.Location = new System.Drawing.Point(13, 19);
            this.ListPermissions.Name = "ListPermissions";
            this.ListPermissions.Size = new System.Drawing.Size(490, 239);
            this.ListPermissions.TabIndex = 0;
            this.ListPermissions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPermissions_CellClick);
            // 
            // frmRoleManagement
            // 
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxPermissions);
            this.Controls.Add(this.groupBoxInfo);
            this.Name = "frmRoleManagement";
            this.Text = "Thêm mới nhóm quyền";
            this.Load += new System.EventHandler(this.frmRoleManagement_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxPermissions.ResumeLayout(false);
            this.groupBoxPermissions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListPermissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.GroupBox groupBoxPermissions;
        private System.Windows.Forms.CheckBox chkAllPermissions;
        private System.Windows.Forms.CheckedListBox chkListPermissions;
        private GroupBox groupBox2;
        private DataGridView ListPermissions;
        private Button deletePermissions;
        private Button editPermissions;
        private Button addPermissions;
        private TextBox idPermission;
        private Label label2;
        private Button cancel;
        private Button save;
    }
}