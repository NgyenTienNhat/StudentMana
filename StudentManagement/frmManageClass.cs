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
    public partial class frmManageClass : Form
    {
        public frmManageClass()
        {
            InitializeComponent();
        }
        private void frmManageClass_Load(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }
        public void LoadDataForDGV()
        {
            dataGridView1.DataSource = ClassManager.GetAllClass();
        }

        private void button_add_class_Click(object sender, EventArgs e)
        {
            Class c = GetClassInfo();
            ClassManager.InsertClass(c);
            LoadDataForDGV();
        }

        private void button_update_class_Click(object sender, EventArgs e)
        {

            Class c = GetClassInfo();
            ClassManager.UpdateClass(c);
            LoadDataForDGV();
        }

        private Class GetClassInfo()
        {
            Class c = new Class();
            if (textBox_classid.Text != null && !string.IsNullOrWhiteSpace(textBox_classid.Text))
            {
                c.ClassId = Convert.ToInt32(textBox_classid.Text);
            }
            c.ClassName = textBox_classname.Text.Trim();
            return c;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox_classid.Text = row.Cells[0].Value.ToString();
                textBox_classname.Text = row.Cells[1].Value.ToString();
            }
        }

       
    }
}
/*private void frmClassManage_Load(object sender, EventArgs e)
{
    LoadDataForDGV();
}
public void LoadDataForDGV()
{
    dataGridView.DataSource = ClassManager.GetAllClass();
}

private Class GetClassInfo()
{
    Class c = new Class();
    if (textBox_classid.Text != null && !string.IsNullOrWhiteSpace(textBox_classid.Text))
    {
        c.ClassId = Convert.ToInt32(textBox_classid.Text);
    }
    c.ClassName = textBox_classname.Text.Trim();
    return c;
}


private void button_add_class_Click(object sender, EventArgs e)
{
    Class c = GetClassInfo();
    ClassManager.InsertClass(c);
    LoadDataForDGV();
}

private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0)
    {
        DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
        textBox_classid.Text = row.Cells[0].Value.ToString();
        textBox_classname.Text = row.Cells[1].Value.ToString();
    }
}

private void button_update_class_Click(object sender, EventArgs e)
{
    Class c = GetClassInfo();
    ClassManager.UpdateClass(c);
    LoadDataForDGV();
}
    }*/