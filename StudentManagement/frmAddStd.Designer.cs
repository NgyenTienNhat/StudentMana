namespace StudentManagement
{
    partial class frmAddStd
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add_std = new System.Windows.Forms.Button();
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
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(930, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 36);
            this.panel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(354, -125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "ADD NEW STUDENT";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(14, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 8);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBox_Id);
            this.panel3.Controls.Add(this.comboBox_class);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button_cancel);
            this.panel3.Controls.Add(this.button_add_std);
            this.panel3.Controls.Add(this.button_upload_image);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.textBox_address);
            this.panel3.Controls.Add(this.textBox_rollno);
            this.panel3.Controls.Add(this.radioButton_female);
            this.panel3.Controls.Add(this.radioButton_male);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dateTimePicker_dob);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_mobile);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox_stdname);
            this.panel3.Location = new System.Drawing.Point(11, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 335);
            this.panel3.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(8, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "Student ID :";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Enabled = false;
            this.textBox_Id.Location = new System.Drawing.Point(154, 11);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(153, 27);
            this.textBox_Id.TabIndex = 42;
            // 
            // comboBox_class
            // 
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Location = new System.Drawing.Point(154, 299);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(123, 28);
            this.comboBox_class.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "Class Name :";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.button_cancel.Location = new System.Drawing.Point(767, 293);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(160, 39);
            this.button_cancel.TabIndex = 39;
            this.button_cancel.Text = "Clear";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click_1);
            // 
            // button_add_std
            // 
            this.button_add_std.BackColor = System.Drawing.SystemColors.Control;
            this.button_add_std.Location = new System.Drawing.Point(578, 293);
            this.button_add_std.Name = "button_add_std";
            this.button_add_std.Size = new System.Drawing.Size(160, 39);
            this.button_add_std.TabIndex = 38;
            this.button_add_std.Text = "Add";
            this.button_add_std.UseVisualStyleBackColor = false;
            this.button_add_std.Click += new System.EventHandler(this.button_add_std_Click_1);
            // 
            // button_upload_image
            // 
            this.button_upload_image.BackColor = System.Drawing.SystemColors.Control;
            this.button_upload_image.Location = new System.Drawing.Point(767, 183);
            this.button_upload_image.Name = "button_upload_image";
            this.button_upload_image.Size = new System.Drawing.Size(160, 39);
            this.button_upload_image.TabIndex = 37;
            this.button_upload_image.Text = "Upload";
            this.button_upload_image.UseVisualStyleBackColor = false;
            this.button_upload_image.Click += new System.EventHandler(this.button_upload_image_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(767, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 163);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(154, 253);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(383, 27);
            this.textBox_address.TabIndex = 35;
            // 
            // textBox_rollno
            // 
            this.textBox_rollno.Location = new System.Drawing.Point(154, 211);
            this.textBox_rollno.Name = "textBox_rollno";
            this.textBox_rollno.Size = new System.Drawing.Size(153, 27);
            this.textBox_rollno.TabIndex = 34;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(243, 173);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(78, 24);
            this.radioButton_female.TabIndex = 33;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(154, 173);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(63, 24);
            this.radioButton_male.TabIndex = 32;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "RollNumber :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Gender :";
            // 
            // dateTimePicker_dob
            // 
            this.dateTimePicker_dob.Location = new System.Drawing.Point(154, 132);
            this.dateTimePicker_dob.Name = "dateTimePicker_dob";
            this.dateTimePicker_dob.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_dob.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Dob :";
            // 
            // textBox_mobile
            // 
            this.textBox_mobile.Location = new System.Drawing.Point(154, 92);
            this.textBox_mobile.Name = "textBox_mobile";
            this.textBox_mobile.Size = new System.Drawing.Size(153, 27);
            this.textBox_mobile.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mobile :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Student Name :";
            // 
            // textBox_stdname
            // 
            this.textBox_stdname.Location = new System.Drawing.Point(154, 52);
            this.textBox_stdname.Name = "textBox_stdname";
            this.textBox_stdname.Size = new System.Drawing.Size(153, 27);
            this.textBox_stdname.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(369, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "ADD NEW STUDENT";
            // 
            // frmAddStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 660);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(971, 696);
            this.Name = "frmAddStd";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmAddStd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add_std;
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
        private System.Windows.Forms.Label label10;
    }
}