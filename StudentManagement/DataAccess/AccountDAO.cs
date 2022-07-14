using Microsoft.SqlServer.Management.Sdk.Sfc;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccess
{
    class AccountDAO
    {
         public static User_Account GetAccount(string username, string password)
         {
            string sql = "select * from User_Account where Username = @username and Password = @password ";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@username", SqlDbType.VarChar);
            param[0].Value = username;
            param[1] = new SqlParameter("@password", SqlDbType.VarChar);
            param[1].Value = username;
            DataTable dataTable =  DAO.GetDataBySQL(sql, param);
            User_Account ur = new User_Account();
            foreach (DataRow dr in dataTable.Rows)
            {
                 ur = new User_Account(
                   Convert.ToInt32(dr[0]),
                   dr[1].ToString(),
                   dr[2].ToString()
                   );
            }
            return ur;
        }
    }
}

