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
            LoadDataForDGV();
        }
        public void LoadDataForDGV()
        {
            dataGridView1.DataSource = StudentManager.GetStudents();
        }
    }
}
