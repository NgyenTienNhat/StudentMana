using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    class Student
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public DateTime Dob { get; set; }
        public bool Gender { get; set; }
        public string? Mobile { get; set; }
        public string? RollNo { get; set; }
        public string? Address { get; set; }
        public int ClassId { get; set; }
        public string? Image { get; set; }
        

        public Student()
        {

        }

        public Student(int studentId, string? studentName, DateTime dob, bool gender, string? mobile, string? rollNo, string? address, int classId, string? image)
        {
            StudentId = studentId;
            StudentName = studentName;
            Dob = dob;
            Gender = gender;
            Mobile = mobile;
            RollNo = rollNo;
            Address = address;
            ClassId = classId;
            Image = image;
        }
    }
}
