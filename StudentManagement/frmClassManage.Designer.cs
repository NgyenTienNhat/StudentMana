namespace StudentManagement
{
    partial class frmClassManage
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
            this.panel_register = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_delete_class = new System.Windows.Forms.Button();
            this.button_update_class = new System.Windows.Forms.Button();
            this.button_add_class = new System.Windows.Forms.Button();
            this.textBox_classname = new System.Windows.Forms.TextBox();
            this.textBox_classid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_register.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_register
            // 
            this.panel_register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_register.Controls.Add(this.panel2);
            this.panel_register.Controls.Add(this.panel1);
            this.panel_register.Controls.Add(this.dataGridView);
            this.panel_register.Location = new System.Drawing.Point(5, 3);
            this.panel_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(825, 478);
            this.panel_register.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_delete_class);
            this.panel2.Controls.Add(this.button_update_class);
            this.panel2.Controls.Add(this.button_add_class);
            this.panel2.Controls.Add(this.textBox_classname);
            this.panel2.Controls.Add(this.textBox_classid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(419, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 433);
            this.panel2.TabIndex = 26;
            // 
            // button_delete_class
            // 
            this.button_delete_class.BackColor = System.Drawing.SystemColors.Control;
            this.button_delete_class.Location = new System.Drawing.Point(280, 393);
            this.button_delete_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete_class.Name = "button_delete_class";
            this.button_delete_class.Size = new System.Drawing.Size(89, 29);
            this.button_delete_class.TabIndex = 25;
            this.button_delete_class.Text = "Delete";
            this.button_delete_class.UseVisualStyleBackColor = false;
            // 
            // button_update_class
            // 
            this.button_update_class.BackColor = System.Drawing.SystemColors.Control;
            this.button_update_class.Location = new System.Drawing.Point(161, 393);
            this.button_update_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_update_class.Name = "button_update_class";
            this.button_update_class.Size = new System.Drawing.Size(89, 29);
            this.button_update_class.TabIndex = 24;
            this.button_update_class.Text = "Update";
            this.button_update_class.UseVisualStyleBackColor = false;
            this.button_update_class.Click += new System.EventHandler(this.button_update_class_Click);
            // 
            // button_add_class
            // 
            this.button_add_class.BackColor = System.Drawing.SystemColors.Control;
            this.button_add_class.Location = new System.Drawing.Point(35, 393);
            this.button_add_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add_class.Name = "button_add_class";
            this.button_add_class.Size = new System.Drawing.Size(89, 29);
            this.button_add_class.TabIndex = 23;
            this.button_add_class.Text = "Add";
            this.button_add_class.UseVisualStyleBackColor = false;
            this.button_add_class.Click += new System.EventHandler(this.button_add_class_Click);
            // 
            // textBox_classname
            // 
            this.textBox_classname.Location = new System.Drawing.Point(149, 56);
            this.textBox_classname.Name = "textBox_classname";
            this.textBox_classname.Size = new System.Drawing.Size(117, 23);
            this.textBox_classname.TabIndex = 22;
            // 
            // textBox_classid
            // 
            this.textBox_classid.Enabled = false;
            this.textBox_classid.Location = new System.Drawing.Point(149, 17);
            this.textBox_classid.Name = "textBox_classid";
            this.textBox_classid.Size = new System.Drawing.Size(117, 23);
            this.textBox_classid.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "CLass Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "CLass ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 27);
            this.panel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(325, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "MANAGE CLASS";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(7, 38);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(403, 433);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // frmClassManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 485);
            this.Controls.Add(this.panel_register);
            this.MaximumSize = new System.Drawing.Size(850, 524);
            this.MinimumSize = new System.Drawing.Size(850, 524);
            this.Name = "frmClassManage";
            this.Text = "frmClassManage";
            this.Load += new System.EventHandler(this.frmClassManage_Load);
            this.panel_register.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_register;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_classname;
        private System.Windows.Forms.TextBox textBox_classid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_delete_class;
        private System.Windows.Forms.Button button_update_class;
        private System.Windows.Forms.Button button_add_class;
    }
}