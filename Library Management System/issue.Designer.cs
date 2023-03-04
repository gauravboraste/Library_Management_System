namespace Library_Management_System
{
    partial class issue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issue));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IssueDateTb = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.StidTb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BookNameTb = new MetroFramework.Controls.MetroTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.StNameTb = new MetroFramework.Controls.MetroTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BookidTb = new System.Windows.Forms.ComboBox();
            this.labeld = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IssueDataset = new System.Windows.Forms.DataGridView();
            this.IsuueBackBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssueDataset)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(827, 35);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(36, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Issue";
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
            this.pictureBox1.Location = new System.Drawing.Point(797, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.IssueDateTb);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.StidTb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BookNameTb);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.StNameTb);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BookidTb);
            this.panel2.Controls.Add(this.labeld);
            this.panel2.Location = new System.Drawing.Point(9, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 217);
            this.panel2.TabIndex = 15;
            // 
            // IssueDateTb
            // 
            this.IssueDateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueDateTb.Location = new System.Drawing.Point(670, 109);
            this.IssueDateTb.Name = "IssueDateTb";
            this.IssueDateTb.Size = new System.Drawing.Size(120, 20);
            this.IssueDateTb.TabIndex = 18;
            this.IssueDateTb.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Student Id";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // StidTb
            // 
            this.StidTb.FormattingEnabled = true;
            this.StidTb.Location = new System.Drawing.Point(14, 106);
            this.StidTb.Name = "StidTb";
            this.StidTb.Size = new System.Drawing.Size(133, 21);
            this.StidTb.TabIndex = 16;
            this.StidTb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.StidTb.SelectionChangeCommitted += new System.EventHandler(this.StidTb_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(278, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Issue Book Details";
            // 
            // BookNameTb
            // 
            // 
            // 
            // 
            this.BookNameTb.CustomButton.Image = null;
            this.BookNameTb.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.BookNameTb.CustomButton.Name = "";
            this.BookNameTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BookNameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BookNameTb.CustomButton.TabIndex = 1;
            this.BookNameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BookNameTb.CustomButton.UseSelectable = true;
            this.BookNameTb.CustomButton.Visible = false;
            this.BookNameTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.BookNameTb.Lines = new string[0];
            this.BookNameTb.Location = new System.Drawing.Point(494, 106);
            this.BookNameTb.MaxLength = 32767;
            this.BookNameTb.Name = "BookNameTb";
            this.BookNameTb.PasswordChar = '\0';
            this.BookNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BookNameTb.SelectedText = "";
            this.BookNameTb.SelectionLength = 0;
            this.BookNameTb.SelectionStart = 0;
            this.BookNameTb.ShortcutsEnabled = true;
            this.BookNameTb.Size = new System.Drawing.Size(155, 23);
            this.BookNameTb.TabIndex = 4;
            this.BookNameTb.UseSelectable = true;
            this.BookNameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BookNameTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // StNameTb
            // 
            // 
            // 
            // 
            this.StNameTb.CustomButton.Image = null;
            this.StNameTb.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.StNameTb.CustomButton.Name = "";
            this.StNameTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.StNameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StNameTb.CustomButton.TabIndex = 1;
            this.StNameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StNameTb.CustomButton.UseSelectable = true;
            this.StNameTb.CustomButton.Visible = false;
            this.StNameTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.StNameTb.Lines = new string[0];
            this.StNameTb.Location = new System.Drawing.Point(166, 106);
            this.StNameTb.MaxLength = 32767;
            this.StNameTb.Multiline = true;
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.PasswordChar = '\0';
            this.StNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StNameTb.SelectedText = "";
            this.StNameTb.SelectionLength = 0;
            this.StNameTb.SelectionStart = 0;
            this.StNameTb.ShortcutsEnabled = true;
            this.StNameTb.Size = new System.Drawing.Size(164, 23);
            this.StNameTb.TabIndex = 2;
            this.StNameTb.UseSelectable = true;
            this.StNameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StNameTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Book Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BookidTb
            // 
            this.BookidTb.FormattingEnabled = true;
            this.BookidTb.Location = new System.Drawing.Point(353, 108);
            this.BookidTb.Name = "BookidTb";
            this.BookidTb.Size = new System.Drawing.Size(121, 21);
            this.BookidTb.TabIndex = 7;
            this.BookidTb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.BookidTb.SelectionChangeCommitted += new System.EventHandler(this.BookidTb_SelectionChangeCommitted);
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeld.Location = new System.Drawing.Point(666, 84);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(55, 20);
            this.labeld.TabIndex = 8;
            this.labeld.Text = "Phone";
            this.labeld.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(332, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Issue  List";
            // 
            // IssueDataset
            // 
            this.IssueDataset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IssueDataset.BackgroundColor = System.Drawing.Color.Thistle;
            this.IssueDataset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IssueDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssueDataset.Location = new System.Drawing.Point(12, 292);
            this.IssueDataset.Name = "IssueDataset";
            this.IssueDataset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IssueDataset.Size = new System.Drawing.Size(803, 201);
            this.IssueDataset.TabIndex = 18;
            this.IssueDataset.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.IssueDataset_CellMouseClick);
            // 
            // IsuueBackBtn
            // 
            this.IsuueBackBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsuueBackBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.IsuueBackBtn.Location = new System.Drawing.Point(362, 499);
            this.IsuueBackBtn.Name = "IsuueBackBtn";
            this.IsuueBackBtn.Size = new System.Drawing.Size(109, 29);
            this.IsuueBackBtn.TabIndex = 19;
            this.IsuueBackBtn.Text = "Back";
            this.IsuueBackBtn.UseVisualStyleBackColor = true;
            this.IsuueBackBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 540);
            this.Controls.Add(this.IsuueBackBtn);
            this.Controls.Add(this.IssueDataset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "issue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "issue";
            this.Load += new System.EventHandler(this.issue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssueDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox BookNameTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private MetroFramework.Controls.MetroTextBox StNameTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BookidTb;
        private System.Windows.Forms.Label labeld;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView IssueDataset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox StidTb;
        private System.Windows.Forms.Button IsuueBackBtn;
        private System.Windows.Forms.DateTimePicker IssueDateTb;
    }
}