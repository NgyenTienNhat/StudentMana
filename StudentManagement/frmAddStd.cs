using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.DataAccess;
using StudentManagement.Logics;


namespace StudentManagement
{
    public partial class frmAddStd : Form
    {
        public frmAddStd()
        {
            InitializeComponent();

        }
        private void frmAddStd_Load(object sender, EventArgs e)
        {
            comboBox_class.DataSource = ClassDAO.GetAllClass();
            comboBox_class.DisplayMember = "ClassName";
            LoadDataForDGV();

        }
        public void LoadDataForDGV()
        {
            var datadataGridViewAddStudent = (from s in StudentManager.GetStudents()
                       join c in ClassDAO.GetAllClass() on s.ClassId equals c.ClassId
                       select new
                       {
                           StudentId =   s.StudentId,
                           StudentName = s.StudentName,
                           Mobile = s.Mobile,
                           Dob = s.Dob,
                           Male = s.Male,
                           RollNo = s.RollNo,
                           Address = s.Address,
                           ClassName = c.ClassName
                       }).ToList();
            dataGridView1.DataSource = datadataGridViewAddStudent;

        }
        private Student GetStudentInfo()
        {
            Student s = new Student();
            if (textBox_Id.Text != null && !string.IsNullOrWhiteSpace(textBox_Id.Text))
            {
                s.StudentId = Convert.ToInt32(textBox_Id.Text);
            }
            s.StudentName = textBox_stdname.Text.Trim();
            s.Mobile = textBox_mobile.Text.Trim();
            s.Dob = dateTimePicker_dob.Value;
            s.Male = radioButton_male.Checked;
            s.RollNo = textBox_rollno.Text.Trim();
            s.Address = textBox_address.Text.Trim();
            s.Image = pictureBox1.ToString();
            foreach (Class c in ClassManager.GetAllClass())
                if (comboBox_class.Text.Equals(c.ClassName))
                {
                    s.ClassId = c.ClassId;
                    break;
                }
            return s;
        }
        private void button_add_std_Click_1(object sender, EventArgs e)
        {
            Student s = GetStudentInfo();
               StudentManager.InsertStudent(s);
               LoadDataForDGV();
            
        }

        private void button_cancel_Click_1(object sender, EventArgs e)
        {
            textBox_Id.Clear();
            textBox_stdname.Clear();
            textBox_mobile.Clear();
            textBox_rollno.Clear();
            textBox_address.Clear();
        }

        private void button_upload_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Image File | *.png; *.jpg; *.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

     
    }
}
