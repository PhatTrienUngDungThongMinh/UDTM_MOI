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
    public partial class frmAddUserToPermissionGroup : Form
    {
        PositionBLL position = new PositionBLL();
        EmployeeBLL employee = new EmployeeBLL();
        QL_UserGroupBLL userGroup = new QL_UserGroupBLL();
        List<Employee> listEmployee = new List<Employee>();
        Employee em;
        Position selectedItem;
        public frmAddUserToPermissionGroup()
        {
            InitializeComponent();
        }

        private void frmAddUserToPermissionGroup_Load(object sender, EventArgs e)
        {
            
            lstPermissionGroups.DataSource = position.GetAllPositions();
            lstPermissionGroups.DisplayMember = "PositionName";
        }
        private void loadPermissionGroups()
        {
            listEmployee = employee.GetEmployeesByIdPosition(selectedItem.id);
            txtPermissions.Text = selectedItem.PositionName.ToString();
            txtUserName.Text = "";
            txtFullname.Text = "";
            dgvMembers.DataSource = listEmployee;
        }
        private void lstPermissionGroups_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstPermissionGroups.SelectedItem != null)
            {
                selectedItem = (Position)lstPermissionGroups.SelectedItem;
                loadPermissionGroups();
            }
        }
        
        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMembers.DataSource != null)
            {
                DataGridViewRow row = dgvMembers.Rows[e.RowIndex];
                txtUserName.Text = row.Cells["Username"].Value.ToString();
                txtFullname.Text = row.Cells["FullName"].Value.ToString();
            }
        }
        private bool checkEmployeeInListEmployees(Employee em)
        {
            return listEmployee.Contains(em);
        }
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0)
            {
                if(checkEmployeeInListEmployees(em))
                {
                    try
                    {
                        userGroup.DeleteQL_UserGroup(em.id, selectedItem.id);
                        loadPermissionGroups();
                        MessageBox.Show("Xóa thành công!");
                    }
                    catch
                    {
                        MessageBox.Show("vui lòng thử lại sau");
                    }
                }
                else
                {
                    MessageBox.Show("Không có nhân viên trong list");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thành viên cần xóa.");
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if(em != null && selectedItem != null)
            {
                QL_UserGroup user = new QL_UserGroup();
                user.IDEmployees = em.id;
                user.IDPositions = selectedItem.id;
                userGroup.AddQL_UserGroup(user);
                loadPermissionGroups();
                MessageBox.Show("Thêm thành công!","kết quả",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("thông tin không hợp lệ vui lòng kiểm tra lại thông tin cần thêm!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            em = employee.getEmployeeByUsername(txtUserName.Text);
            if (em != null)
            {
                txtFullname.Text = em.FullName;
            }
            else
            {
                txtFullname.Text = "";
            }
        }


    }
}
