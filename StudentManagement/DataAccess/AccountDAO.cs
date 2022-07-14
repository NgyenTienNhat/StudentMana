using Microsoft.SqlServer.Management.Sdk.Sfc;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccess
{
    class AccountDAO
    {
         public static User_Account GetAccount(string username, string password)
         {
             string sql = "select AccountId, UserName, Password from User_Account where Username = @username and Password = @password ";
             
         }
    }
}
