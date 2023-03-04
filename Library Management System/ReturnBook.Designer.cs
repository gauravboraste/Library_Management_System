namespace Library_Management_System
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FineTb = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ReturnDateTb = new System.Windows.Forms.DateTimePicker();
            this.IssueDateTb = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.StidTb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BookNameTb = new MetroFramework.Controls.MetroTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StNameTb = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BookidTb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IsseuRtnDataset = new System.Windows.Forms.DataGridView();
            this.RtnBookDataset = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.CalcTb = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IsseuRtnDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RtnBookDataset)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(995, 35);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(36, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Return ";
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
            this.pictureBox1.Location = new System.Drawing.Point(965, 3);
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
            this.panel2.Controls.Add(this.CalcTb);
            this.panel2.Controls.Add(this.FineTb);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.ReturnDateTb);
            this.panel2.Controls.Add(this.IssueDateTb);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.StidTb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BookNameTb);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.StNameTb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BookidTb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 217);
            this.panel2.TabIndex = 16;
            // 
            // FineTb
            // 
            // 
            // 
            // 
            this.FineTb.CustomButton.Image = null;
            this.FineTb.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.FineTb.CustomButton.Name = "";
            this.FineTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FineTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FineTb.CustomButton.TabIndex = 1;
            this.FineTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FineTb.CustomButton.UseSelectable = true;
            this.FineTb.CustomButton.Visible = false;
            this.FineTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.FineTb.Lines = new string[0];
            this.FineTb.Location = new System.Drawing.Point(862, 111);
            this.FineTb.MaxLength = 32767;
            this.FineTb.Multiline = true;
            this.FineTb.Name = "FineTb";
            this.FineTb.PasswordChar = '\0';
            this.FineTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FineTb.SelectedText = "";
            this.FineTb.SelectionLength = 0;
            this.FineTb.SelectionStart = 0;
            this.FineTb.ShortcutsEnabled = true;
            this.FineTb.Size = new System.Drawing.Size(80, 23);
            this.FineTb.TabIndex = 22;
            this.FineTb.UseSelectable = true;
            this.FineTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FineTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(858, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fine";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(732, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Return Date";
            // 
            // ReturnDateTb
            // 
            this.ReturnDateTb.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ReturnDateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDateTb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReturnDateTb.Location = new System.Drawing.Point(736, 111);
            this.ReturnDateTb.Name = "ReturnDateTb";
            this.ReturnDateTb.Size = new System.Drawing.Size(120, 21);
            this.ReturnDateTb.TabIndex = 20;
            // 
            // IssueDateTb
            // 
            this.IssueDateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueDateTb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.IssueDateTb.Location = new System.Drawing.Point(610, 111);
            this.IssueDateTb.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.IssueDateTb.Name = "IssueDateTb";
            this.IssueDateTb.Size = new System.Drawing.Size(120, 21);
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
            // 
            // StidTb
            // 
            this.StidTb.FormattingEnabled = true;
            this.StidTb.Location = new System.Drawing.Point(14, 106);
            this.StidTb.Name = "StidTb";
            this.StidTb.Size = new System.Drawing.Size(133, 21);
            this.StidTb.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(359, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Return Book Details";
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
            this.BookNameTb.Location = new System.Drawing.Point(449, 108);
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
            this.BookNameTb.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkViolet;
            this.button4.Location = new System.Drawing.Point(495, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 29);
            this.button4.TabIndex = 13;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name ";
            // 
            // StNameTb
            // 
            // 
            // 
            // 
            this.StNameTb.CustomButton.Image = null;
            this.StNameTb.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.StNameTb.CustomButton.Name = "";
            this.StNameTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.StNameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StNameTb.CustomButton.TabIndex = 1;
            this.StNameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StNameTb.CustomButton.UseSelectable = true;
            this.StNameTb.CustomButton.Visible = false;
            this.StNameTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.StNameTb.Lines = new string[0];
            this.StNameTb.Location = new System.Drawing.Point(153, 106);
            this.StNameTb.MaxLength = 32767;
            this.StNameTb.Multiline = true;
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.PasswordChar = '\0';
            this.StNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StNameTb.SelectedText = "";
            this.StNameTb.SelectionLength = 0;
            this.StNameTb.SelectionStart = 0;
            this.StNameTb.ShortcutsEnabled = true;
            this.StNameTb.Size = new System.Drawing.Size(163, 23);
            this.StNameTb.TabIndex = 2;
            this.StNameTb.UseSelectable = true;
            this.StNameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StNameTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book Id";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkViolet;
            this.button1.Location = new System.Drawing.Point(364, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Book Name";
            // 
            // BookidTb
            // 
            this.BookidTb.FormattingEnabled = true;
            this.BookidTb.Location = new System.Drawing.Point(322, 108);
            this.BookidTb.Name = "BookidTb";
            this.BookidTb.Size = new System.Drawing.Size(121, 21);
            this.BookidTb.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(606, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Issue Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(158, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Issue  List";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkViolet;
            this.label9.Location = new System.Drawing.Point(641, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "Return  List";
            // 
            // IsseuRtnDataset
            // 
            this.IsseuRtnDataset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IsseuRtnDataset.BackgroundColor = System.Drawing.Color.Thistle;
            this.IsseuRtnDataset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IsseuRtnDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IsseuRtnDataset.Location = new System.Drawing.Point(12, 304);
            this.IsseuRtnDataset.Name = "IsseuRtnDataset";
            this.IsseuRtnDataset.Size = new System.Drawing.Size(482, 201);
            this.IsseuRtnDataset.TabIndex = 20;
            this.IsseuRtnDataset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IsseuRtnDataset_CellContentClick);
            this.IsseuRtnDataset.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.IsseuRtnDataset_CellMouseClick);
            // 
            // RtnBookDataset
            // 
            this.RtnBookDataset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RtnBookDataset.BackgroundColor = System.Drawing.Color.Thistle;
            this.RtnBookDataset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RtnBookDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RtnBookDataset.Location = new System.Drawing.Point(503, 304);
            this.RtnBookDataset.Name = "RtnBookDataset";
            this.RtnBookDataset.Size = new System.Drawing.Size(482, 201);
            this.RtnBookDataset.TabIndex = 21;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkViolet;
            this.button5.Location = new System.Drawing.Point(440, 522);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 29);
            this.button5.TabIndex = 22;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CalcTb
            // 
            this.CalcTb.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcTb.ForeColor = System.Drawing.Color.DarkViolet;
            this.CalcTb.Location = new System.Drawing.Point(862, 137);
            this.CalcTb.Name = "CalcTb";
            this.CalcTb.Size = new System.Drawing.Size(80, 29);
            this.CalcTb.TabIndex = 23;
            this.CalcTb.Text = "Calaculate";
            this.CalcTb.UseVisualStyleBackColor = true;
            this.CalcTb.Click += new System.EventHandler(this.CalcTb_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 563);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RtnBookDataset);
            this.Controls.Add(this.IsseuRtnDataset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "@return";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IsseuRtnDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RtnBookDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox StidTb;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox BookNameTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox StNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BookidTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker ReturnDateTb;
        private System.Windows.Forms.DataGridView IsseuRtnDataset;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroTextBox FineTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker IssueDateTb;
        private System.Windows.Forms.DataGridView RtnBookDataset;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button CalcTb;
    }
}