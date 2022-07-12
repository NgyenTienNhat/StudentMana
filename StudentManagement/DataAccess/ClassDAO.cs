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
    class ClassDAO
    {
        public static List<Class> GetAllClass()
        {
            string sql = "Select * from Class";
            DataTable dt = DAO.GetDataBySQL(sql);
            List<Class> list = new List<Class>();
            foreach(DataRow dr in dt.Rows)
            {
                Class c = new Class(
                    Convert.ToInt32(dr["ClassId"]),
                    dr["ClassName"].ToString()
                    );
                list.Add(c);
            }
            return list;
        }

        

        public static int InsertClass(Class c)
        {
            string sql = @"INSERT INTO Class (ClassName) Values (@classname)";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@classname", SqlDbType.VarChar);
            param[0].Value = c.ClassName;
            return DAO.ExecuteSql(sql, param);
        }

        public static int UpdateClass(Class c)
        {
            string sql = @"UPDATE Class SET ClassName = @classname where ClassId = @classid";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@classname", SqlDbType.VarChar);
            param[0].Value = c.ClassName;
            param[1] = new SqlParameter("@classid", SqlDbType.Int);
            param[1].Value = c.ClassId;
            return DAO.ExecuteSql(sql, param);
        }

        /*public static int GetClassIdByClassName(string className)
        {
            string sql = "select ClassId from Class where ClassName = @className";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@className", SqlDbType.NVarChar);
            param[0].Value = className;
            return DAO.ExecuteSql(sql, param);
        }*/
    }
}
