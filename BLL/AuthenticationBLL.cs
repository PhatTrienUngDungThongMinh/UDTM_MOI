using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class AuthenticationBLL
    {
        private AuthenticationDAL authenticationDAL;

        public AuthenticationBLL()
        {
            authenticationDAL = new AuthenticationDAL();
        }

        public bool AuthenticateUser(string username, string password)
        {
            return authenticationDAL.AuthenticateUser(username, password);
        }

        private string HashPassword(string password)
        {
            return authenticationDAL.HashPassword(password);
        }

        public bool ResetPasswordToUsername(int employeeId)
        {
            return authenticationDAL.ResetPasswordToUsername(employeeId);
        }

        public Employee GetUserByUsername(string username)
        {
            return authenticationDAL.GetUserByUsername(username);
        }
    }
}
