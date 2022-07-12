using StudentManagement.DataAccess;
using StudentManagement.Logics;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class frmManageStd : Form
    {
        public frmManageStd()
        {
            InitializeComponent();
        }

        private void frmManageStd_Load(object sender, EventArgs e)
        {
            comboBox_class.DataSource = ClassDAO.GetAllClass();
            comboBox_class.DisplayMember = "ClassName";
            LoadDataForDGV();
        }

        public void LoadDataForDGV()
        {
            var datadataGridViewManageStd = (from s in StudentManager.GetStudents()
                                             join c in ClassDAO.GetAllClass() on s.ClassId equals c.ClassId
                                             select new
                                             {
                                                 StudentId = s.StudentId,
                                                 StudentName = s.StudentName,
                                                 Mobile = s.Mobile,
                                                 Dob = s.Dob,
                                                 Male = s.Male,
                                                 RollNo = s.RollNo,
                                                 Address = s.Address,
                                                 ClassName = c.ClassName
                                             }).ToList();
            dataGridView1.DataSource = datadataGridViewManageStd;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox_Id.Text = row.Cells[0].Value.ToString();
                textBox_stdname.Text = row.Cells[1].Value.ToString();
                textBox_mobile.Text = row.Cells[2].Value.ToString();
                dateTimePicker_dob.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                if ((Boolean)row.Cells[4].Value == false)
                {
                    radioButton_female.Checked = true;
                }
                else
                {
                    radioButton_male.Checked = true;
                }
                textBox_rollno.Text = row.Cells[5].Value.ToString();
                textBox_address.Text = row.Cells[6].Value.ToString();
                comboBox_class.Text = row.Cells[7].Value.ToString();
            }
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

        private void button_update_std_Click(object sender, EventArgs e)
        {
            Student s = GetStudentInfo();
            StudentManager.UpdateStudent(s);
            LoadDataForDGV();
        }

        private void button_delete_std_Click(object sender, EventArgs e)
        {
            Student s = GetStudentInfo();
            StudentManager.DeleteStudent(s);
            LoadDataForDGV();
        }
    }
}
