namespace Library_Management_System
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.QtyTb = new MetroFramework.Controls.MetroTextBox();
            this.BPublisherTb = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BAuthorTb = new MetroFramework.Controls.MetroTextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.BNameTb = new MetroFramework.Controls.MetroTextBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BPriceTb = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.BooksDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).BeginInit();
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
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(36, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Books";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.QtyTb);
            this.panel2.Controls.Add(this.BPublisherTb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BAuthorTb);
            this.panel2.Controls.Add(this.ResetBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.BNameTb);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.SaveBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BPriceTb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(11, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 217);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(601, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quantity";
            // 
            // QtyTb
            // 
            // 
            // 
            // 
            this.QtyTb.CustomButton.Image = null;
            this.QtyTb.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.QtyTb.CustomButton.Name = "";
            this.QtyTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.QtyTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QtyTb.CustomButton.TabIndex = 1;
            this.QtyTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QtyTb.CustomButton.UseSelectable = true;
            this.QtyTb.CustomButton.Visible = false;
            this.QtyTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.QtyTb.Lines = new string[0];
            this.QtyTb.Location = new System.Drawing.Point(605, 107);
            this.QtyTb.MaxLength = 32767;
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.PasswordChar = '\0';
            this.QtyTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QtyTb.SelectedText = "";
            this.QtyTb.SelectionLength = 0;
            this.QtyTb.SelectionStart = 0;
            this.QtyTb.ShortcutsEnabled = true;
            this.QtyTb.Size = new System.Drawing.Size(102, 23);
            this.QtyTb.TabIndex = 17;
            this.QtyTb.UseSelectable = true;
            this.QtyTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QtyTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.QtyTb.Click += new System.EventHandler(this.metroTextBox5_Click);
            // 
            // BPublisherTb
            // 
            // 
            // 
            // 
            this.BPublisherTb.CustomButton.Image = null;
            this.BPublisherTb.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.BPublisherTb.CustomButton.Name = "";
            this.BPublisherTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BPublisherTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BPublisherTb.CustomButton.TabIndex = 1;
            this.BPublisherTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BPublisherTb.CustomButton.UseSelectable = true;
            this.BPublisherTb.CustomButton.Visible = false;
            this.BPublisherTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.BPublisherTb.Lines = new string[0];
            this.BPublisherTb.Location = new System.Drawing.Point(313, 107);
            this.BPublisherTb.MaxLength = 32767;
            this.BPublisherTb.Name = "BPublisherTb";
            this.BPublisherTb.PasswordChar = '\0';
            this.BPublisherTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BPublisherTb.SelectedText = "";
            this.BPublisherTb.SelectionLength = 0;
            this.BPublisherTb.SelectionStart = 0;
            this.BPublisherTb.ShortcutsEnabled = true;
            this.BPublisherTb.Size = new System.Drawing.Size(139, 23);
            this.BPublisherTb.TabIndex = 16;
            this.BPublisherTb.UseSelectable = true;
            this.BPublisherTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BPublisherTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(289, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Books Details";
            // 
            // BAuthorTb
            // 
            // 
            // 
            // 
            this.BAuthorTb.CustomButton.Image = null;
            this.BAuthorTb.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.BAuthorTb.CustomButton.Name = "";
            this.BAuthorTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BAuthorTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BAuthorTb.CustomButton.TabIndex = 1;
            this.BAuthorTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BAuthorTb.CustomButton.UseSelectable = true;
            this.BAuthorTb.CustomButton.Visible = false;
            this.BAuthorTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.BAuthorTb.Lines = new string[0];
            this.BAuthorTb.Location = new System.Drawing.Point(165, 107);
            this.BAuthorTb.MaxLength = 32767;
            this.BAuthorTb.Name = "BAuthorTb";
            this.BAuthorTb.PasswordChar = '\0';
            this.BAuthorTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BAuthorTb.SelectedText = "";
            this.BAuthorTb.SelectionLength = 0;
            this.BAuthorTb.SelectionStart = 0;
            this.BAuthorTb.ShortcutsEnabled = true;
            this.BAuthorTb.Size = new System.Drawing.Size(141, 23);
            this.BAuthorTb.TabIndex = 4;
            this.BAuthorTb.UseSelectable = true;
            this.BAuthorTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BAuthorTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.ResetBtn.Location = new System.Drawing.Point(505, 154);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(109, 29);
            this.ResetBtn.TabIndex = 13;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name ";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.DeleteBtn.Location = new System.Drawing.Point(375, 154);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(109, 29);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // BNameTb
            // 
            // 
            // 
            // 
            this.BNameTb.CustomButton.Image = null;
            this.BNameTb.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.BNameTb.CustomButton.Name = "";
            this.BNameTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BNameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BNameTb.CustomButton.TabIndex = 1;
            this.BNameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BNameTb.CustomButton.UseSelectable = true;
            this.BNameTb.CustomButton.Visible = false;
            this.BNameTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.BNameTb.Lines = new string[0];
            this.BNameTb.Location = new System.Drawing.Point(17, 107);
            this.BNameTb.MaxLength = 32767;
            this.BNameTb.Multiline = true;
            this.BNameTb.Name = "BNameTb";
            this.BNameTb.PasswordChar = '\0';
            this.BNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BNameTb.SelectedText = "";
            this.BNameTb.SelectionLength = 0;
            this.BNameTb.SelectionStart = 0;
            this.BNameTb.ShortcutsEnabled = true;
            this.BNameTb.Size = new System.Drawing.Size(142, 23);
            this.BNameTb.TabIndex = 2;
            this.BNameTb.UseSelectable = true;
            this.BNameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BNameTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.EditBtn.Location = new System.Drawing.Point(255, 154);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(109, 29);
            this.EditBtn.TabIndex = 11;
            this.EditBtn.Text = "Update";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.SaveBtn.Location = new System.Drawing.Point(128, 154);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(109, 29);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Publisher";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BPriceTb
            // 
            // 
            // 
            // 
            this.BPriceTb.CustomButton.Image = null;
            this.BPriceTb.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.BPriceTb.CustomButton.Name = "";
            this.BPriceTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BPriceTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BPriceTb.CustomButton.TabIndex = 1;
            this.BPriceTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BPriceTb.CustomButton.UseSelectable = true;
            this.BPriceTb.CustomButton.Visible = false;
            this.BPriceTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.BPriceTb.Lines = new string[0];
            this.BPriceTb.Location = new System.Drawing.Point(458, 107);
            this.BPriceTb.MaxLength = 32767;
            this.BPriceTb.Name = "BPriceTb";
            this.BPriceTb.PasswordChar = '\0';
            this.BPriceTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BPriceTb.SelectedText = "";
            this.BPriceTb.SelectionLength = 0;
            this.BPriceTb.SelectionStart = 0;
            this.BPriceTb.ShortcutsEnabled = true;
            this.BPriceTb.Size = new System.Drawing.Size(141, 23);
            this.BPriceTb.TabIndex = 9;
            this.BPriceTb.UseSelectable = true;
            this.BPriceTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BPriceTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BPriceTb.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(454, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(304, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Books List";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkViolet;
            this.button5.Location = new System.Drawing.Point(309, 510);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 29);
            this.button5.TabIndex = 19;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BooksDGV
            // 
            this.BooksDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BooksDGV.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BooksDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.BooksDGV.Location = new System.Drawing.Point(12, 303);
            this.BooksDGV.Name = "BooksDGV";
            this.BooksDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksDGV.Size = new System.Drawing.Size(724, 201);
            this.BooksDGV.TabIndex = 20;
            this.BooksDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BooksDGV_CellMouseClick);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 540);
            this.Controls.Add(this.BooksDGV);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox BAuthorTb;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteBtn;
        private MetroFramework.Controls.MetroTextBox BNameTb;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox BPriceTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox BPublisherTb;
        private System.Windows.Forms.Button button5;
        private MetroFramework.Controls.MetroTextBox QtyTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView BooksDGV;
    }
}