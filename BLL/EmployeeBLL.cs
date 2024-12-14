using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeBLL
    {
        private readonly EmployeeDAL employeeDAL = new EmployeeDAL();

        public EmployeeBLL()
        {

        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.GetAllEmployees();
        }
        public List<Employee> GetEmployeesByIdPosition(int id)
        {
            return employeeDAL.GetEmployeesByPositionId(id);
        }
        public List<Position> GetPositionsByEmployeeId(int employeeId)
        {
            return employeeDAL.GetPositionsByEmployeeId(employeeId);
        }
        public Employee getEmployeeByUsername(string Username)
        {
            return employeeDAL.getEmployeeByUsername(Username);
        }
        public void AddEmployee(Employee employee)
        {

            if (string.IsNullOrWhiteSpace(employee.Username))
            {
                throw new ArgumentException("Username không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(employee.Password))
            {
                throw new ArgumentException("Password không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(employee.FullName))
            {
                throw new ArgumentException("Họ và Tên không được để trống.");
            }

            employeeDAL.AddEmployee(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            if (string.IsNullOrWhiteSpace(employee.Username))
            {
                throw new ArgumentException("Username không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(employee.Password))
            {
                throw new ArgumentException("Password không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(employee.FullName))
            {
                throw new ArgumentException("Họ và Tên không được để trống.");
            }

            employeeDAL.UpdateEmployee(employee);
        }

        public void DeleteEmployee(int employeeId)
        {

            employeeDAL.DeleteEmployee(employeeId);
        }
    }
}
