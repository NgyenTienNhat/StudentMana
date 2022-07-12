using StudentManagement.DataAccess;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Logics
{
    class StudentManager
    {
        public static List<Student> GetStudents()
        {
            return StudentDAO.GetStudents();
        }

        public static int InsertStudent(Student s)
        {
            return StudentDAO.InsertStudent(s);
        }

        public static int UpdateStudent(Student s)
        {
            return StudentDAO.UpdateStudent(s);
        }

        /*public static int DeleteStudent(Student s)
        {
            return StudentDAO.DeleteStudent(s.Id);
        }

        public static List<string> GetAllMajors()
        {
            return new List<string> { "SE", "IA", "GD", "SB", "AI", "HS" };
        }*/
    }
}
