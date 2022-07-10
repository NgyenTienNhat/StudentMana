using Microsoft.Data.SqlClient;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccess
{
    class StudentDAO
    {   
        public static List<Student> GetStudents()
        {
            string sql = "select * from Student";
            DataTable dt = DAO.GetDataBySQL(sql);
            List<Student> list = new List<Student>();
            foreach (DataRow dr in dt.Rows)
            {
                Student s = new Student(
                    Convert.ToInt32(dr["StudentId"]),
                    dr["StudentName"].ToString(),
                    Convert.ToDateTime(dr["Dob"]),
                    Convert.ToBoolean(dr["Gender"]),
                    dr["Mobile"].ToString(),
                    dr["RollNo"].ToString(),
                    dr["Address"].ToString(),
                    Convert.ToInt32(dr["ClassId"]),
                    dr["Image"].ToString()
                    );
                list.Add(s);
            }
            return list;
        }
        public static int InsertStudent(Student s)
        {
            string sql = @"INSERT INTO Student(StudentName, DOB, Gender, Mobile, RollNo, [Address], [Image]) 
                Values(@studentname, @dob, @gender, @mobile, @rollno, @address, @image)";
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@studentname", SqlDbType.NVarChar);
            param[0].Value = s.StudentName;
            param[1] = new SqlParameter("@dob", SqlDbType.Date);
            param[1].Value = s.Dob;
            param[2] = new SqlParameter("@gender", SqlDbType.Bit);
            param[2].Value = s.Gender;
            param[3] = new SqlParameter("@phone", SqlDbType.BigInt);
            param[3].Value = s.Mobile;
            param[4] = new SqlParameter("@rollno", SqlDbType.VarChar);
            param[4].Value = s.RollNo;
            param[5] = new SqlParameter("@address", SqlDbType.NVarChar);
            param[5].Value = s.Address;
            param[6] = new SqlParameter("@image", SqlDbType.NVarChar);
            param[6].Value = s.Image;
            return DAO.ExecuteSql(sql, param);
        }
    }
}
