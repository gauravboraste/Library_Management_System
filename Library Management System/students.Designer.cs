namespace Library_Management_System
{
    partial class students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(students));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SNameTb = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeptNameTb = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SemCoBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneTb = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StudentDataSet = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(158)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(36, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Students";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(716, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SNameTb
            // 
            // 
            // 
            // 
            this.SNameTb.CustomButton.Image = null;
            this.SNameTb.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.SNameTb.CustomButton.Name = "";
            this.SNameTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SNameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SNameTb.CustomButton.TabIndex = 1;
            this.SNameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SNameTb.CustomButton.UseSelectable = true;
            this.SNameTb.CustomButton.Visible = false;
            this.SNameTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.SNameTb.Lines = new string[0];
            this.SNameTb.Location = new System.Drawing.Point(40, 107);
            this.SNameTb.MaxLength = 32767;
            this.SNameTb.Multiline = true;
            this.SNameTb.Name = "SNameTb";
            this.SNameTb.PasswordChar = '\0';
            this.SNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SNameTb.SelectedText = "";
            this.SNameTb.SelectionLength = 0;
            this.SNameTb.SelectionStart = 0;
            this.SNameTb.ShortcutsEnabled = true;
            this.SNameTb.Size = new System.Drawing.Size(156, 23);
            this.SNameTb.TabIndex = 2;
            this.SNameTb.UseSelectable = true;
            this.SNameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SNameTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SNameTb.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DeptNameTb
            // 
            // 
            // 
            // 
            this.DeptNameTb.CustomButton.Image = null;
            this.DeptNameTb.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.DeptNameTb.CustomButton.Name = "";
            this.DeptNameTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DeptNameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DeptNameTb.CustomButton.TabIndex = 1;
            this.DeptNameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DeptNameTb.CustomButton.UseSelectable = true;
            this.DeptNameTb.CustomButton.Visible = false;
            this.DeptNameTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.DeptNameTb.Lines = new string[0];
            this.DeptNameTb.Location = new System.Drawing.Point(217, 107);
            this.DeptNameTb.MaxLength = 32767;
            this.DeptNameTb.Name = "DeptNameTb";
            this.DeptNameTb.PasswordChar = '\0';
            this.DeptNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DeptNameTb.SelectedText = "";
            this.DeptNameTb.SelectionLength = 0;
            this.DeptNameTb.SelectionStart = 0;
            this.DeptNameTb.ShortcutsEnabled = true;
            this.DeptNameTb.Size = new System.Drawing.Size(156, 23);
            this.DeptNameTb.TabIndex = 4;
            this.DeptNameTb.UseSelectable = true;
            this.DeptNameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeptNameTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.DeptNameTb.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Semester";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SemCoBox
            // 
            this.SemCoBox.FormattingEnabled = true;
            this.SemCoBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.SemCoBox.Location = new System.Drawing.Point(393, 108);
            this.SemCoBox.Name = "SemCoBox";
            this.SemCoBox.Size = new System.Drawing.Size(121, 21);
            this.SemCoBox.TabIndex = 7;
            this.SemCoBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(534, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PhoneTb
            // 
            // 
            // 
            // 
            this.PhoneTb.CustomButton.Image = null;
            this.PhoneTb.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.PhoneTb.CustomButton.Name = "";
            this.PhoneTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PhoneTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PhoneTb.CustomButton.TabIndex = 1;
            this.PhoneTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PhoneTb.CustomButton.UseSelectable = true;
            this.PhoneTb.CustomButton.Visible = false;
            this.PhoneTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PhoneTb.Lines = new string[0];
            this.PhoneTb.Location = new System.Drawing.Point(538, 108);
            this.PhoneTb.MaxLength = 32767;
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.PasswordChar = '\0';
            this.PhoneTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PhoneTb.SelectedText = "";
            this.PhoneTb.SelectionLength = 0;
            this.PhoneTb.SelectionStart = 0;
            this.PhoneTb.ShortcutsEnabled = true;
            this.PhoneTb.Size = new System.Drawing.Size(156, 23);
            this.PhoneTb.TabIndex = 9;
            this.PhoneTb.UseSelectable = true;
            this.PhoneTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PhoneTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PhoneTb.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkViolet;
            this.button1.Location = new System.Drawing.Point(128, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkViolet;
            this.button2.Location = new System.Drawing.Point(255, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkViolet;
            this.button3.Location = new System.Drawing.Point(375, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkViolet;
            this.button4.Location = new System.Drawing.Point(505, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 29);
            this.button4.TabIndex = 13;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.DeptNameTb);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.SNameTb);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.PhoneTb);
            this.panel2.Controls.Add(this.SemCoBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 217);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(252, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Students Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(289, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Students List";
            // 
            // StudentDataSet
            // 
            this.StudentDataSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDataSet.BackgroundColor = System.Drawing.Color.Thistle;
            this.StudentDataSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StudentDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataSet.Location = new System.Drawing.Point(12, 293);
            this.StudentDataSet.Name = "StudentDataSet";
            this.StudentDataSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentDataSet.Size = new System.Drawing.Size(722, 201);
            this.StudentDataSet.TabIndex = 17;
            this.StudentDataSet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataSet_CellClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkViolet;
            this.button5.Location = new System.Drawing.Point(320, 500);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 29);
            this.button5.TabIndex = 16;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 540);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.StudentDataSet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "students";
            this.Load += new System.EventHandler(this.students_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox SNameTb;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox DeptNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SemCoBox;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox PhoneTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView StudentDataSet;
        private System.Windows.Forms.Button button5;
    }
}