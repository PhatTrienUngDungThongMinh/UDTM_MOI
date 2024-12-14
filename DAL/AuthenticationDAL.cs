using DTO;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DAL
{
    public class AuthenticationDAL
    {
        private readonly DBDataContext db; 

        public AuthenticationDAL()
        {
            db = new DBDataContext();
        }
        public bool AuthenticateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            var user = db.Employees.SingleOrDefault(u => u.Username == username);

            if (user == null)
            {
                return false;
            }

            if (VerifyPassword(password, user.Password))
            {
                return true;
            }

            return false;
        }

        private bool VerifyPassword(string enteredPassword, string storedPassword)
        {
            string hashedPassword = HashPassword(enteredPassword);
            return hashedPassword == storedPassword;
        }
        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public bool ResetPasswordToUsername(int employeeId)
        {
            var employee = db.Employees.SingleOrDefault(e => e.id == employeeId);

            if (employee != null)
            {
                string username = employee.Username;

                string hashedPassword = HashPassword(username);
                employee.Password = hashedPassword;

                db.SubmitChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public Employee GetUserByUsername(string username)
        {
            Employee user = db.Employees.SingleOrDefault(u => u.Username == username);
            if (user != null)
            {
                return user;
            }
            return null;
        }
    }
}
