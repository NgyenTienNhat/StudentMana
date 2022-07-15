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

        public static int DeleteStudent(Student s)
        {
            return StudentDAO.DeleteStudent(s.StudentId);
        }

        public static List<Student> SearchStudentByName(string studentName)
        {
            return StudentDAO.SearchStudentByName(studentName);
        }
    }
}
