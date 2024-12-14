using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDAL
    {
        private readonly DBDataContext db;

        public EmployeeDAL()
        {
            db = new DBDataContext();
        }

        public List<Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }

        public List<Employee> GetEmployeesByPositionId(int positionId)
        {
            var employeeIds = db.QL_UserGroups
                                       .Where(ug => ug.IDPositions == positionId)
                                       .Select(ug => ug.IDEmployees)
                                       .ToList();
            var employees = db.Employees
                                     .Where(e => employeeIds.Contains(e.id) && !e.IsDeleted)
                                     .ToList();

            return employees;
        }
        public List<Position> GetPositionsByEmployeeId(int employeeId)
        {
            var employeePositions = db.QL_UserGroups
                                       .Where(ug => ug.IDEmployees == employeeId)
                                       .Select(ug => ug.IDPositions)
                                       .ToList();

            if (!employeePositions.Any())
            {
                return new List<Position>();
            }
            var positions = db.Positions
                               .Where(p => employeePositions.Contains(p.id))
                               .ToList();

            return positions;
        }

        public void AddEmployee(Employee employee)
        {
            db.Employees.InsertOnSubmit(employee);
            db.SubmitChanges();
        }
        public Employee getEmployeeByUsername(string Username)
        {
            var employee = db.Employees.SingleOrDefault(e => e.Username == Username);
            return employee;
        }
        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = db.Employees.SingleOrDefault(e => e.id == employee.id);
            if (existingEmployee != null)
            {
                existingEmployee.Username = employee.Username;
                existingEmployee.Password = employee.Password;
                existingEmployee.FullName = employee.FullName;
                existingEmployee.DateOfBirth = employee.DateOfBirth;
                existingEmployee.Gender = employee.Gender;
                existingEmployee.Address = employee.Address;
                existingEmployee.Email = employee.Email;
                existingEmployee.PhoneNumber = employee.PhoneNumber;
                existingEmployee.IsActive = employee.IsActive;
                existingEmployee.DeletedAt = employee.DeletedAt;
                existingEmployee.CreatedBy = employee.CreatedBy;
                existingEmployee.DeletedBy = employee.DeletedBy;
                existingEmployee.UpdatedBy = employee.UpdatedBy;
                existingEmployee.IsDeleted = employee.IsDeleted;
                existingEmployee.createdAt = employee.createdAt;
                existingEmployee.updatedAt = employee.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Employee not found");
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = db.Employees.SingleOrDefault(e => e.id == employeeId);
            if (employee != null)
            {
                db.Employees.DeleteOnSubmit(employee);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Employee not found");
            }
        }
    }
}
