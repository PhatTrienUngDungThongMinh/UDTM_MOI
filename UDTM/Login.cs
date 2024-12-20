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

namespace DoAnUDTM
{
    public partial class Login : Form
    {
        private EmployeeBLL emBLL = new EmployeeBLL();
        private AuthenticationBLL authentication = new AuthenticationBLL();
        private List<QL_UserGroup> qL_UserGroups = new List<QL_UserGroup>();
        public Employee _employee;
        public List<Position> quyen;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //authentication.ResetPasswordToUsername(1);
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lblUsername.Text.ToLower(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Không được bỏ trống " + lblPassword.Text.ToLower(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPassword.Focus();
                return;
            }

            bool isAuthenticated = authentication.AuthenticateUser(txtUsername.Text.Trim(), txtPassword.Text);
            if (isAuthenticated)
            {
                _employee = authentication.GetUserByUsername(txtUsername.Text.Trim());
                quyen = emBLL.GetPositionsByEmployeeId(_employee.id);
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmHome mainForm = new frmHome(_employee, quyen);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Clear();
                this.txtPassword.Focus();
            }
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.txtUsername.Focus();
        }
    }
}
