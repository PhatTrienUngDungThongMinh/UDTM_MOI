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
    public partial class frmEmployeeAccountManagement : Form
    {
        EmployeeBLL employee = new EmployeeBLL();
        public frmEmployeeAccountManagement()
        {
            InitializeComponent();
        }

        private void frmEmployeeAccountManagement_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }
        private void LoadEmployee()
        {
            var employees = employee.GetAllEmployees().Where(emp => !emp.IsDeleted).ToList();
            DSNV.DataSource = employees;
            DSNV.CellClick += DSNV_CellClick;
            dateNgaySinh.Format = DateTimePickerFormat.Custom;
            dateNgaySinh.CustomFormat = "dd/MM/yyyy";
        }

        private void DSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DSNV.Rows.Count)
            {
                DataGridViewRow selectedRow = DSNV.Rows[e.RowIndex];

        
                txtMaNV.Text = selectedRow.Cells["id"].Value?.ToString() ?? string.Empty;
                txtTenNV.Text = selectedRow.Cells["FullName"].Value?.ToString() ?? string.Empty;
                txtUsername.Text = selectedRow.Cells["Username"].Value?.ToString() ?? string.Empty;
                txtPassword.Text = selectedRow.Cells["Password"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString() ?? string.Empty;
                txtSDT.Text = selectedRow.Cells["PhoneNumber"].Value?.ToString() ?? string.Empty;
                txtDiaChi.Text = selectedRow.Cells["Address"].Value?.ToString() ?? string.Empty;

                string gender = selectedRow.Cells["Gender"].Value?.ToString();
                if (gender == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else if (gender == "Nữ")
                {
                    rdoNu.Checked = true;
                }

                if (DateTime.TryParse(selectedRow.Cells["DateOfBirth"].Value?.ToString(), out DateTime dateOfBirth))
                {
                    dateNgaySinh.Value = dateOfBirth;
                }
                else
                {
                    dateNgaySinh.Value = DateTime.Now; 
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;

            rdoNam.Checked = false;
            rdoNu.Checked = false;

            dateNgaySinh.Value = DateTime.Now;

            txtTenNV.Focus();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn lưu thông tin nhân viên không?",
                                         "Xác nhận lưu",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Employee newEmployee = new Employee
                    {
                        FullName = txtTenNV.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        Email = txtEmail.Text,
                        PhoneNumber = txtSDT.Text,
                        Address = txtDiaChi.Text,
                        Gender = rdoNam.Checked ? "Nam" : (rdoNu.Checked ? "Nữ" : null),
                        IsActive=true,
                        DateOfBirth = dateNgaySinh.Value,
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now  
                    };

                    employee.AddEmployee(newEmployee);

                    LoadEmployee();

                    MessageBox.Show("Thêm nhân viên thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?",
                                         "Xác nhận xóa",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int employeeId = int.Parse(txtMaNV.Text);

                    employee.DeleteEmployee(employeeId);

                    LoadEmployee();

                    MessageBox.Show("Xóa nhân viên thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    btnThem_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi xóa: {ex.Message}",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            var result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin nhân viên này không?",
                                         "Xác nhận sửa",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int employeeId = int.Parse(txtMaNV.Text);

                    Employee updatedEmployee = new Employee
                    {
                        id = employeeId,
                        FullName = txtTenNV.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        Email = txtEmail.Text,
                        PhoneNumber = txtSDT.Text,
                        Address = txtDiaChi.Text,
                        Gender = rdoNam.Checked ? "Nam" : (rdoNu.Checked ? "Nữ" : null),
                        DateOfBirth = dateNgaySinh.Value,
                        updatedAt = DateTime.Now  
                    };

                    employee.UpdateEmployee(updatedEmployee);

                    LoadEmployee();

                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    btnThem_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi sửa: {ex.Message}",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

    }
}
