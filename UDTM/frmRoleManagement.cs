using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnUDTM
{
    public partial class frmRoleManagement : Form
    {
        ScreenBLL screen = new ScreenBLL();
        PositionBLL position = new PositionBLL();
        QL_PhanQuyenBLL phanquyen = new QL_PhanQuyenBLL();
        List<QL_PhanQuyen> Listchecked;
        public frmRoleManagement()
        {
            InitializeComponent();
        }

        private void loadPosition()
        {
            ListPermissions.DataSource = position.GetAllPositions();
        }
        private void frmRoleManagement_Load(object sender, EventArgs e)
        {
            chkListPermissions.DataSource = screen.GetAllScreens();
            chkListPermissions.DisplayMember = "ScreenName";
            loadPosition();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoadcheckedListPermissions()
        {
            for (int i = 0; i < chkListPermissions.Items.Count; i++)
            {
                DM_Screen screen = chkListPermissions.Items[i] as DM_Screen;
                if (screen != null)
                {
                    // Kiểm tra nếu quyền này đã có trong Listchecked
                    bool isChecked = Listchecked.Any(q => q.ScreenCode == screen.ScreenCode);

                    // Cập nhật trạng thái checkbox
                    chkListPermissions.SetItemChecked(i, isChecked);
                }
            }
        }
        private void ListPermissions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ListPermissions.Rows[e.RowIndex];

                int cellValue = (int)row.Cells["id"].Value;
                idPermission.Text = cellValue.ToString();
                txtRoleName.Text = row.Cells["PositionName"].Value.ToString();
                Listchecked = phanquyen.GetAllQL_PhanQuyensByIdPosition(cellValue);
                LoadcheckedListPermissions();
            }
        }

        private void addPermissions_Click(object sender, EventArgs e)
        {
            Position NewPosition = new Position();
            NewPosition.PositionName = txtRoleName.Text;
            position.AddPosition(NewPosition);
            loadPosition();
        }

        private void editPermissions_Click(object sender, EventArgs e)
        {
            Position editPosition = new Position();
            editPosition.id = int.Parse(idPermission.Text);
            editPosition.PositionName = txtRoleName.Text;
            position.UpdatePosition(editPosition);
            loadPosition();
        }

        private void deletePermissions_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idPermission.Text);
            position.DeletePosition(id);
            loadPosition();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            LoadcheckedListPermissions();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int positionId = int.Parse(idPermission.Text);

            // Danh sách quyền đã được chọn
            List<QL_PhanQuyen> newPermissions = new List<QL_PhanQuyen>();

            for (int i = 0; i < chkListPermissions.Items.Count; i++)
            {
                DM_Screen screen = chkListPermissions.Items[i] as DM_Screen;

                if (screen != null && chkListPermissions.GetItemChecked(i))
                {
                    // Thêm quyền vào danh sách
                    newPermissions.Add(new QL_PhanQuyen
                    {
                        IDPositions = positionId,
                        ScreenCode = screen.ScreenCode,
                        HasPermission = true,
                    });
                }
            }

            // Cập nhật quyền cho vị trí
            phanquyen.UpdatePermissionsByIdPosition(positionId, newPermissions);

            MessageBox.Show("Đã cập nhật.", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            if (idPermission.Text == "")
            {
                MessageBox.Show("vui lòng chọn nhóm quyền hợp lệ!");
                return;
            }
            if (chkAllPermissions.Checked)
            {
                for (int i = 0; i < chkListPermissions.Items.Count; i++)
                {
                    chkListPermissions.SetItemChecked(i, true);
                }
            }
            else
            {
                LoadcheckedListPermissions();
            }
        }
    }
}
