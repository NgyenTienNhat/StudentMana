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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            textBox_password.PasswordChar = '*';
        }

        private void button_exitlogin_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_login_Click(object sender, EventArgs e)
        {   
            
            if(textBox_username.Text =="" || textBox_password.Text == "")
            {
                MessageBox.Show("Input Username and Password", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            User_Account user_Account = AccountManager.GetAccount(textBox_username.Text, textBox_password.Text);
            if (user_Account != null)
            {
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }else
            {
                MessageBox.Show("Username and password are not exits", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
