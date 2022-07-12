using System.Data.SqlClient;
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
                int? ClassId = 0;
                if (dr["ClassId"] != null)
                {
                    ClassId = Convert.ToInt32(dr["ClassId"]);
                }
                Student s = new Student(
                    Convert.ToInt32(dr["StudentId"]),
                    dr["StudentName"].ToString(),
                    Convert.ToDateTime(dr["Dob"]),
                    Convert.ToBoolean(dr["Male"]),
                    dr["Mobile"].ToString(),
                    dr["RollNo"].ToString(),
                    dr["Address"].ToString(),
                    ClassId,
                    dr["Image"].ToString()
                    );
                list.Add(s);
            }
            return list;
        }
        public static int InsertStudent(Student s)
        {
            string sql = @"INSERT INTO Student(StudentName, Dob, Male, Mobile, RollNo, [Address], ClassId ,[Image]) 
                Values(@studentname, @dob, @male, @mobile, @rollno, @address, @classid ,@image )";
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@studentname", SqlDbType.NVarChar);
            param[0].Value = s.StudentName;
            param[1] = new SqlParameter("@dob", SqlDbType.Date);
            param[1].Value = s.Dob;
            param[2] = new SqlParameter("@male", SqlDbType.Bit);
            param[2].Value = s.Male;
            param[3] = new SqlParameter("@mobile", SqlDbType.VarChar);
            param[3].Value = s.Mobile;
            param[4] = new SqlParameter("@rollno", SqlDbType.VarChar);
            param[4].Value = s.RollNo;
            param[5] = new SqlParameter("@address", SqlDbType.NVarChar);
            param[5].Value = s.Address;
            param[6] = new SqlParameter("@classid", SqlDbType.Int);
            param[6].Value = s.ClassId;
            param[7] = new SqlParameter("@image", SqlDbType.NVarChar);
            param[7].Value = s.Image;
            return DAO.ExecuteSql(sql, param);
        }

        public static int UpdateStudent(Student s)
        {
            string sql = "Update Student set StudentName = @studentname, Dob = @dob, Male = @male, " +
                "Mobile = @mobile, RollNo = @rollno, [Address] = @address, ClassId = @classid, " +
                "Image = @image where StudentId = @studentid";
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@studentname", SqlDbType.NVarChar);
            param[0].Value = s.StudentName;
            param[1] = new SqlParameter("@dob", SqlDbType.Date);
            param[1].Value = s.Dob;
            param[2] = new SqlParameter("@male", SqlDbType.Bit);
            param[2].Value = s.Male;
            param[3] = new SqlParameter("@mobile", SqlDbType.VarChar);
            param[3].Value = s.Mobile;
            param[4] = new SqlParameter("@rollno", SqlDbType.VarChar);
            param[4].Value = s.RollNo;
            param[5] = new SqlParameter("@address", SqlDbType.NVarChar);
            param[5].Value = s.Address;
            param[6] = new SqlParameter("@classid", SqlDbType.Int);
            param[6].Value = s.ClassId;
            param[7] = new SqlParameter("@image", SqlDbType.NVarChar);
            param[7].Value = s.Image;
            param[8] = new SqlParameter("@studentid", SqlDbType.Int);
            param[8].Value = s.StudentId;
            return DAO.ExecuteSql(sql, param);
            
        }
    }
}
