using StudentManagement.DataAccess;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Logics
{
     class ClassManager
    {
        public static List<Class> GetAllClass()
        {
            return ClassDAO.GetAllClass();
        }

        public static int InsertClass(Class c)
        {
            return ClassDAO.InsertClass(c);
        }
        public static int UpdateClass(Class c)
        {
            return ClassDAO.UpdateClass(c);
        }

        


    }
}
