namespace StudentManagement
{
    partial class frmManageStd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.button_delete_std = new System.Windows.Forms.Button();
            this.button_update_std = new System.Windows.Forms.Button();
            this.button_upload_image = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_rollno = new System.Windows.Forms.TextBox();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_dob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_mobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_stdname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_addstd = new System.Windows.Forms.Panel();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_register = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_addstd.SuspendLayout();
            this.panel_register.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(4, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Student ID :";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Enabled = false;
            this.textBox_Id.Location = new System.Drawing.Point(150, 16);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(152, 27);
            this.textBox_Id.TabIndex = 18;
            // 
            // button_delete_std
            // 
            this.button_delete_std.BackColor = System.Drawing.SystemColors.Control;
            this.button_delete_std.Location = new System.Drawing.Point(502, 228);
            this.button_delete_std.Name = "button_delete_std";
            this.button_delete_std.Size = new System.Drawing.Size(160, 39);
            this.button_delete_std.TabIndex = 17;
            this.button_delete_std.Text = "Delete";
            this.button_delete_std.UseVisualStyleBackColor = false;
            this.button_delete_std.Click += new System.EventHandler(this.button_delete_std_Click);
            // 
            // button_update_std
            // 
            this.button_update_std.BackColor = System.Drawing.SystemColors.Control;
            this.button_update_std.Location = new System.Drawing.Point(287, 228);
            this.button_update_std.Name = "button_update_std";
            this.button_update_std.Size = new System.Drawing.Size(160, 39);
            this.button_update_std.TabIndex = 16;
            this.button_update_std.Text = "Update";
            this.button_update_std.UseVisualStyleBackColor = false;
            this.button_update_std.Click += new System.EventHandler(this.button_update_std_Click);
            // 
            // button_upload_image
            // 
            this.button_upload_image.BackColor = System.Drawing.SystemColors.Control;
            this.button_upload_image.Location = new System.Drawing.Point(797, 167);
            this.button_upload_image.Name = "button_upload_image";
            this.button_upload_image.Size = new System.Drawing.Size(130, 39);
            this.button_upload_image.TabIndex = 15;
            this.button_upload_image.Text = "Upload";
            this.button_upload_image.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(797, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(470, 111);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(297, 27);
            this.textBox_address.TabIndex = 13;
            // 
            // textBox_rollno
            // 
            this.textBox_rollno.Location = new System.Drawing.Point(470, 63);
            this.textBox_rollno.Name = "textBox_rollno";
            this.textBox_rollno.Size = new System.Drawing.Size(129, 27);
            this.textBox_rollno.TabIndex = 12;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(224, 152);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(78, 24);
            this.radioButton_female.TabIndex = 11;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(150, 152);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(63, 24);
            this.radioButton_male.TabIndex = 10;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(327, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(327, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "RollNumber :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender :";
            // 
            // dateTimePicker_dob
            // 
            this.dateTimePicker_dob.Checked = false;
            this.dateTimePicker_dob.CustomFormat = "";
            this.dateTimePicker_dob.Location = new System.Drawing.Point(470, 16);
            this.dateTimePicker_dob.Name = "dateTimePicker_dob";
            this.dateTimePicker_dob.Size = new System.Drawing.Size(227, 27);
            this.dateTimePicker_dob.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(327, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dob :";
            // 
            // textBox_mobile
            // 
            this.textBox_mobile.Location = new System.Drawing.Point(150, 109);
            this.textBox_mobile.Name = "textBox_mobile";
            this.textBox_mobile.Size = new System.Drawing.Size(152, 27);
            this.textBox_mobile.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mobile :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Name :";
            // 
            // textBox_stdname
            // 
            this.textBox_stdname.Location = new System.Drawing.Point(150, 64);
            this.textBox_stdname.Name = "textBox_stdname";
            this.textBox_stdname.Size = new System.Drawing.Size(152, 27);
            this.textBox_stdname.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(371, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "MANAGE STUDENT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 36);
            this.panel1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(930, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel_addstd
            // 
            this.panel_addstd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_addstd.Controls.Add(this.comboBox_class);
            this.panel_addstd.Controls.Add(this.label9);
            this.panel_addstd.Controls.Add(this.label8);
            this.panel_addstd.Controls.Add(this.textBox_Id);
            this.panel_addstd.Controls.Add(this.button_delete_std);
            this.panel_addstd.Controls.Add(this.button_update_std);
            this.panel_addstd.Controls.Add(this.button_upload_image);
            this.panel_addstd.Controls.Add(this.pictureBox1);
            this.panel_addstd.Controls.Add(this.textBox_address);
            this.panel_addstd.Controls.Add(this.textBox_rollno);
            this.panel_addstd.Controls.Add(this.radioButton_female);
            this.panel_addstd.Controls.Add(this.radioButton_male);
            this.panel_addstd.Controls.Add(this.label6);
            this.panel_addstd.Controls.Add(this.label5);
            this.panel_addstd.Controls.Add(this.label4);
            this.panel_addstd.Controls.Add(this.dateTimePicker_dob);
            this.panel_addstd.Controls.Add(this.label3);
            this.panel_addstd.Controls.Add(this.textBox_mobile);
            this.panel_addstd.Controls.Add(this.label2);
            this.panel_addstd.Controls.Add(this.label1);
            this.panel_addstd.Controls.Add(this.textBox_stdname);
            this.panel_addstd.Location = new System.Drawing.Point(8, 379);
            this.panel_addstd.Name = "panel_addstd";
            this.panel_addstd.Size = new System.Drawing.Size(930, 269);
            this.panel_addstd.TabIndex = 19;
            // 
            // comboBox_class
            // 
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Location = new System.Drawing.Point(470, 152);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(123, 28);
            this.comboBox_class.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(327, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 24);
            this.label9.TabIndex = 42;
            this.label9.Text = "Class Name :";
            // 
            // panel_register
            // 
            this.panel_register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_register.Controls.Add(this.panel_addstd);
            this.panel_register.Controls.Add(this.panel1);
            this.panel_register.Controls.Add(this.dataGridView1);
            this.panel_register.Location = new System.Drawing.Point(5, 1);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(945, 651);
            this.panel_register.TabIndex = 21;
            // 
            // frmManageStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 652);
            this.Controls.Add(this.panel_register);
            this.MaximumSize = new System.Drawing.Size(972, 699);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(972, 699);
            this.Name = "frmManageStd";
            this.Text = "frmManageStd";
            this.Load += new System.EventHandler(this.frmManageStd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_addstd.ResumeLayout(false);
            this.panel_addstd.PerformLayout();
            this.panel_register.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Button button_delete_std;
        private System.Windows.Forms.Button button_update_std;
        private System.Windows.Forms.Button button_upload_image;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_rollno;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_mobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_stdname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel_addstd;
        private System.Windows.Forms.Panel panel_register;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Label label9;
    }
}