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
    public partial class frmHome : Form
    {
        private Employee employee;
        private List<Position> positions;
        private bool sildebarExpand = true;
        private Form currentFormChild;
        QL_PhanQuyenBLL phanQuyenBLL = new QL_PhanQuyenBLL();
        public frmHome(Employee em, List<Position> pos)
        {
            employee = em;
            positions = pos;
            InitializeComponent();
            txtNameEmployee.Text = em.FullName;
            ApplyPermissions();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void SlidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sildebarExpand)
            {
                tableLayoutPanel1.ColumnStyles[1].Width -= 10;
                if (tableLayoutPanel1.ColumnStyles[1].Width == 40)
                {
                    sildebarExpand = false;
                    SlidebarTimer.Stop();
                }
            }
            else
            {
                tableLayoutPanel1.ColumnStyles[0].Width += 10;
                if (tableLayoutPanel1.ColumnStyles[0].Width == 210)
                {
                    sildebarExpand = true;
                    SlidebarTimer.Stop();
                }
            }
        }

        private HashSet<string> GetEmployeePermissions()
        {
            // Tạo một HashSet để lưu trữ các quyền duy nhất
            HashSet<string> permissions = new HashSet<string>();

            // Lấy danh sách các ScreenCode từ danh sách positions
            List<string> roles = phanQuyenBLL.getAllScreenByListPosition(positions);

            // Thêm từng ScreenCode vào HashSet
            foreach (string screenCode in roles)
            {
                permissions.Add(screenCode);
            }

            // Trả về HashSet chứa các quyền duy nhất
            return permissions;
        }

        private void ApplyPermissions()
        {
            HashSet<string> employeePermissions = GetEmployeePermissions();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Button btn && btn.Tag != null)
                {
                    string requiredPermission = btn.Tag.ToString();

                    if (employeePermissions.Contains(requiredPermission))
                    {
                        btn.Visible = true;
                    }
                    else
                    {
                        btn.Visible = false;
                    }
                }
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmProductManagement pm = new frmProductManagement();
            OpenChildForm(pm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddUserToPermissionGroup pr = new frmAddUserToPermissionGroup();
            OpenChildForm(pr);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmOrderManagement om = new frmOrderManagement();
            OpenChildForm(om);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmCustomerManagement cm = new frmCustomerManagement();
            OpenChildForm(cm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEmployeeAccountManagement em = new frmEmployeeAccountManagement();
            OpenChildForm(em);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmProductCategorization pc = new frmProductCategorization();
            OpenChildForm(pc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmProductManagement pm = new frmProductManagement();
            OpenChildForm(pm);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login dn = new Login();
                dn.Show();
                this.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Không làm gì cả hoặc thêm chức năng nếu cần
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Không làm gì cả hoặc thêm chức năng nếu cần
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // Không làm gì cả hoặc thêm chức năng nếu cần
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {
            // Không làm gì cả hoặc thêm chức năng nếu cần
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {
            // Không làm gì cả hoặc thêm chức năng nếu cần
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Không làm gì cả hoặc thêm chức năng nếu cần
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmInventoryManagement im = new frmInventoryManagement();
            OpenChildForm(im);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmDiscountAndPromotionManagement dm = new frmDiscountAndPromotionManagement();
            OpenChildForm(dm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmRoleManagement rm = new frmRoleManagement();
            OpenChildForm(rm);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmManufacturers mu = new frmManufacturers();
            OpenChildForm(mu);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }
    }
}
