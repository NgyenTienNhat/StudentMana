using StudentManagement.DataAccess;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Logics
{
    class AccountManager
    {
        public static User_Account GetAccount(string username, string password)
        {
            return AccountDAO.GetAccount(username, password);
        }
    }
}
