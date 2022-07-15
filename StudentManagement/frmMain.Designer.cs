namespace StudentManagement
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel_slide = new System.Windows.Forms.Panel();
            this.panel_classsubmenu = new System.Windows.Forms.Panel();
            this.button_manageclass = new System.Windows.Forms.Button();
            this.button_class = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.panel_scoresubmenu = new System.Windows.Forms.Panel();
            this.button_managescore = new System.Windows.Forms.Button();
            this.button_newscore = new System.Windows.Forms.Button();
            this.button_score = new System.Windows.Forms.Button();
            this.panel_coursesubmenu = new System.Windows.Forms.Panel();
            this.button_managecourse = new System.Windows.Forms.Button();
            this.button_newcourse = new System.Windows.Forms.Button();
            this.button_course = new System.Windows.Forms.Button();
            this.panel_stdsubmenu = new System.Windows.Forms.Panel();
            this.button_status = new System.Windows.Forms.Button();
            this.button_managestd = new System.Windows.Forms.Button();
            this.button_registration = new System.Windows.Forms.Button();
            this.button_std = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_slide.SuspendLayout();
            this.panel_classsubmenu.SuspendLayout();
            this.panel_scoresubmenu.SuspendLayout();
            this.panel_coursesubmenu.SuspendLayout();
            this.panel_stdsubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_slide
            // 
            this.panel_slide.AutoScroll = true;
            this.panel_slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_slide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_slide.Controls.Add(this.panel_classsubmenu);
            this.panel_slide.Controls.Add(this.button_class);
            this.panel_slide.Controls.Add(this.button_logout);
            this.panel_slide.Controls.Add(this.panel_scoresubmenu);
            this.panel_slide.Controls.Add(this.button_score);
            this.panel_slide.Controls.Add(this.panel_coursesubmenu);
            this.panel_slide.Controls.Add(this.button_course);
            this.panel_slide.Controls.Add(this.panel_stdsubmenu);
            this.panel_slide.Controls.Add(this.button_std);
            this.panel_slide.Controls.Add(this.panel_logo);
            this.panel_slide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_slide.Location = new System.Drawing.Point(0, 0);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(185, 701);
            this.panel_slide.TabIndex = 0;
            // 
            // panel_classsubmenu
            // 
            this.panel_classsubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_classsubmenu.Controls.Add(this.button_manageclass);
            this.panel_classsubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_classsubmenu.Location = new System.Drawing.Point(0, 572);
            this.panel_classsubmenu.Name = "panel_classsubmenu";
            this.panel_classsubmenu.Size = new System.Drawing.Size(181, 44);
            this.panel_classsubmenu.TabIndex = 9;
            // 
            // button_manageclass
            // 
            this.button_manageclass.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_manageclass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_manageclass.FlatAppearance.BorderSize = 0;
            this.button_manageclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manageclass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_manageclass.ForeColor = System.Drawing.Color.White;
            this.button_manageclass.Location = new System.Drawing.Point(0, 0);
            this.button_manageclass.Name = "button_manageclass";
            this.button_manageclass.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button_manageclass.Size = new System.Drawing.Size(181, 44);
            this.button_manageclass.TabIndex = 0;
            this.button_manageclass.Text = "Manage Class";
            this.button_manageclass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_manageclass.UseVisualStyleBackColor = true;
            this.button_manageclass.Click += new System.EventHandler(this.button_manageclass_Click);
            // 
            // button_class
            // 
            this.button_class.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_class.FlatAppearance.BorderSize = 0;
            this.button_class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_class.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_class.ForeColor = System.Drawing.Color.White;
            this.button_class.Location = new System.Drawing.Point(0, 527);
            this.button_class.Name = "button_class";
            this.button_class.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_class.Size = new System.Drawing.Size(181, 45);
            this.button_class.TabIndex = 8;
            this.button_class.Text = "Class";
            this.button_class.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_class.UseVisualStyleBackColor = true;
            this.button_class.Click += new System.EventHandler(this.button_class_Click);
            // 
            // button_logout
            // 
            this.button_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(0, 652);
            this.button_logout.Margin = new System.Windows.Forms.Padding(0);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(181, 45);
            this.button_logout.TabIndex = 7;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // panel_scoresubmenu
            // 
            this.panel_scoresubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_scoresubmenu.Controls.Add(this.button_managescore);
            this.panel_scoresubmenu.Controls.Add(this.button_newscore);
            this.panel_scoresubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_scoresubmenu.Location = new System.Drawing.Point(0, 438);
            this.panel_scoresubmenu.Name = "panel_scoresubmenu";
            this.panel_scoresubmenu.Size = new System.Drawing.Size(181, 89);
            this.panel_scoresubmenu.TabIndex = 6;
            // 
            // button_managescore
            // 
            this.button_managescore.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_managescore.FlatAppearance.BorderSize = 0;
            this.button_managescore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_managescore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_managescore.ForeColor = System.Drawing.Color.White;
            this.button_managescore.Location = new System.Drawing.Point(0, 43);
            this.button_managescore.Name = "button_managescore";
            this.button_managescore.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button_managescore.Size = new System.Drawing.Size(181, 47);
            this.button_managescore.TabIndex = 1;
            this.button_managescore.Text = "Manage Score";
            this.button_managescore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_managescore.UseVisualStyleBackColor = true;
            this.button_managescore.Click += new System.EventHandler(this.button_managescore_Click);
            // 
            // button_newscore
            // 
            this.button_newscore.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_newscore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_newscore.FlatAppearance.BorderSize = 0;
            this.button_newscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newscore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_newscore.ForeColor = System.Drawing.Color.White;
            this.button_newscore.Location = new System.Drawing.Point(0, 0);
            this.button_newscore.Name = "button_newscore";
            this.button_newscore.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button_newscore.Size = new System.Drawing.Size(181, 43);
            this.button_newscore.TabIndex = 0;
            this.button_newscore.Text = "New Score";
            this.button_newscore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_newscore.UseVisualStyleBackColor = true;
            this.button_newscore.Click += new System.EventHandler(this.button_newscore_Click);
            // 
            // button_score
            // 
            this.button_score.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_score.FlatAppearance.BorderSize = 0;
            this.button_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_score.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_score.ForeColor = System.Drawing.Color.White;
            this.button_score.Location = new System.Drawing.Point(0, 393);
            this.button_score.Name = "button_score";
            this.button_score.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_score.Size = new System.Drawing.Size(181, 45);
            this.button_score.TabIndex = 5;
            this.button_score.Text = "Score";
            this.button_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_score.UseVisualStyleBackColor = true;
            this.button_score.Click += new System.EventHandler(this.button_score_Click);
            // 
            // panel_coursesubmenu
            // 
            this.panel_coursesubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_coursesubmenu.Controls.Add(this.button_managecourse);
            this.panel_coursesubmenu.Controls.Add(this.button_newcourse);
            this.panel_coursesubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_coursesubmenu.Location = new System.Drawing.Point(0, 302);
            this.panel_coursesubmenu.Name = "panel_coursesubmenu";
            this.panel_coursesubmenu.Size = new System.Drawing.Size(181, 91);
            this.panel_coursesubmenu.TabIndex = 4;
            // 
            // button_managecourse
            // 
            this.button_managecourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_managecourse.FlatAppearance.BorderSize = 0;
            this.button_managecourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_managecourse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_managecourse.ForeColor = System.Drawing.Color.White;
            this.button_managecourse.Location = new System.Drawing.Point(0, 43);
            this.button_managecourse.Name = "button_managecourse";
            this.button_managecourse.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button_managecourse.Size = new System.Drawing.Size(181, 48);
            this.button_managecourse.TabIndex = 1;
            this.button_managecourse.Text = "Manage Course";
            this.button_managecourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_managecourse.UseVisualStyleBackColor = true;
            this.button_managecourse.Click += new System.EventHandler(this.button_managecourse_Click);
            // 
            // button_newcourse
            // 
            this.button_newcourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_newcourse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_newcourse.FlatAppearance.BorderSize = 0;
            this.button_newcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newcourse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_newcourse.ForeColor = System.Drawing.Color.White;
            this.button_newcourse.Location = new System.Drawing.Point(0, 0);
            this.button_newcourse.Name = "button_newcourse";
            this.button_newcourse.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button_newcourse.Size = new System.Drawing.Size(181, 43);
            this.button_newcourse.TabIndex = 0;
            this.button_newcourse.Text = "New Coure";
            this.button_newcourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_newcourse.UseVisualStyleBackColor = true;
            this.button_newcourse.Click += new System.EventHandler(this.button_newcourse_Click);
            // 
            // button_course
            // 
            this.button_course.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_course.FlatAppearance.BorderSize = 0;
            this.button_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_course.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_course.ForeColor = System.Drawing.Color.White;
            this.button_course.Location = new System.Drawing.Point(0, 257);
            this.button_course.Name = "button_course";
            this.button_course.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_course.Size = new System.Drawing.Size(181, 45);
            this.button_course.TabIndex = 3;
            this.button_course.Text = "Course";
            this.button_course.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_course.UseVisualStyleBackColor = true;
            this.button_course.Click += new System.EventHandler(this.button_course_Click);
            // 
            // panel_stdsubmenu
            // 
            this.panel_stdsubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_stdsubmenu.Controls.Add(this.button_status);
            this.panel_stdsubmenu.Controls.Add(this.button_managestd);
            this.panel_stdsubmenu.Controls.Add(this.button_registration);
            this.panel_stdsubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_stdsubmenu.Location = new System.Drawing.Point(0, 126);
            this.panel_stdsubmenu.Name = "panel_stdsubmenu";
            this.panel_stdsubmenu.Size = new System.Drawing.Size(181, 131);
            this.panel_stdsubmenu.TabIndex = 2;
            // 
            // button_status
            // 
            this.button_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_status.FlatAppearance.BorderSize = 0;
            this.button_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_status.ForeColor = System.Drawing.Color.White;
            this.button_status.Location = new System.Drawing.Point(0, 86);
            this.button_status.Name = "button_status";
            this.button_status.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button_status.Size = new System.Drawing.Size(181, 45);
            this.button_status.TabIndex = 2;
            this.button_status.Text = "Status";
            this.button_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_status.UseVisualStyleBackColor = true;
            this.button_status.Click += new System.EventHandler(this.button_status_Click);
            // 
            // button_managestd
            // 
            this.button_managestd.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_managestd.FlatAppearance.BorderSize = 0;
            this.button_managestd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_managestd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_managestd.ForeColor = System.Drawing.Color.White;
            this.button_managestd.Location = new System.Drawing.Point(0, 43);
            this.button_managestd.Name = "button_managestd";
            this.button_managestd.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button_managestd.Size = new System.Drawing.Size(181, 43);
            this.button_managestd.TabIndex = 1;
            this.button_managestd.Text = "Manage Student";
            this.button_managestd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_managestd.UseVisualStyleBackColor = true;
            this.button_managestd.Click += new System.EventHandler(this.button_managestd_Click);
            // 
            // button_registration
            // 
            this.button_registration.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_registration.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_registration.FlatAppearance.BorderSize = 0;
            this.button_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_registration.ForeColor = System.Drawing.Color.White;
            this.button_registration.Location = new System.Drawing.Point(0, 0);
            this.button_registration.Name = "button_registration";
            this.button_registration.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.button_registration.Size = new System.Drawing.Size(181, 43);
            this.button_registration.TabIndex = 0;
            this.button_registration.Text = "Registration";
            this.button_registration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_registration.UseVisualStyleBackColor = true;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            // 
            // button_std
            // 
            this.button_std.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_std.FlatAppearance.BorderSize = 0;
            this.button_std.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_std.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_std.ForeColor = System.Drawing.Color.White;
            this.button_std.Location = new System.Drawing.Point(0, 81);
            this.button_std.Name = "button_std";
            this.button_std.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_std.Size = new System.Drawing.Size(181, 45);
            this.button_std.TabIndex = 1;
            this.button_std.Text = "Student";
            this.button_std.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_std.UseVisualStyleBackColor = true;
            this.button_std.Click += new System.EventHandler(this.button_std_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_main.ForeColor = System.Drawing.Color.Black;
            this.panel_main.Location = new System.Drawing.Point(189, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(971, 699);
            this.panel_main.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.White;
            this.panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_logo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(181, 81);
            this.panel_logo.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 701);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_slide);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmMain";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel_slide.ResumeLayout(false);
            this.panel_classsubmenu.ResumeLayout(false);
            this.panel_scoresubmenu.ResumeLayout(false);
            this.panel_coursesubmenu.ResumeLayout(false);
            this.panel_stdsubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_logo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Panel panel_stdsubmenu;
        private System.Windows.Forms.Button button_status;
        private System.Windows.Forms.Button button_managestd;
        private System.Windows.Forms.Button button_registration;
        private System.Windows.Forms.Button button_std;
        private System.Windows.Forms.Panel panel_scoresubmenu;
        private System.Windows.Forms.Button button_managescore;
        private System.Windows.Forms.Button button_newscore;
        private System.Windows.Forms.Button button_score;
        private System.Windows.Forms.Panel panel_coursesubmenu;
        private System.Windows.Forms.Button button_managecourse;
        private System.Windows.Forms.Button button_newcourse;
        private System.Windows.Forms.Button button_course;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_classsubmenu;
        private System.Windows.Forms.Button button_manageclass;
        private System.Windows.Forms.Button button_class;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
