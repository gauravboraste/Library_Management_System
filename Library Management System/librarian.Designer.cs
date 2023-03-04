namespace Library_Management_System
{
    partial class librarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(librarian));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LibPassTb = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LibPhnTb = new MetroFramework.Controls.MetroTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.LibNameTb = new MetroFramework.Controls.MetroTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LibrarianDataset = new System.Windows.Forms.DataGridView();
            this.LibBackBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibrarianDataset)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(745, 35);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(36, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Librarian";
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
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.LibPassTb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.LibPhnTb);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.LibNameTb);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(7, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 217);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LibPassTb
            // 
            // 
            // 
            // 
            this.LibPassTb.CustomButton.Image = null;
            this.LibPassTb.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.LibPassTb.CustomButton.Name = "";
            this.LibPassTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LibPassTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LibPassTb.CustomButton.TabIndex = 1;
            this.LibPassTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LibPassTb.CustomButton.UseSelectable = true;
            this.LibPassTb.CustomButton.Visible = false;
            this.LibPassTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.LibPassTb.Lines = new string[0];
            this.LibPassTb.Location = new System.Drawing.Point(453, 89);
            this.LibPassTb.MaxLength = 32767;
            this.LibPassTb.Name = "LibPassTb";
            this.LibPassTb.PasswordChar = '*';
            this.LibPassTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LibPassTb.SelectedText = "";
            this.LibPassTb.SelectionLength = 0;
            this.LibPassTb.SelectionStart = 0;
            this.LibPassTb.ShortcutsEnabled = true;
            this.LibPassTb.Size = new System.Drawing.Size(139, 23);
            this.LibPassTb.TabIndex = 16;
            this.LibPassTb.UseSelectable = true;
            this.LibPassTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LibPassTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(289, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Librarian Details";
            // 
            // LibPhnTb
            // 
            // 
            // 
            // 
            this.LibPhnTb.CustomButton.Image = null;
            this.LibPhnTb.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.LibPhnTb.CustomButton.Name = "";
            this.LibPhnTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LibPhnTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LibPhnTb.CustomButton.TabIndex = 1;
            this.LibPhnTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LibPhnTb.CustomButton.UseSelectable = true;
            this.LibPhnTb.CustomButton.Visible = false;
            this.LibPhnTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.LibPhnTb.Lines = new string[0];
            this.LibPhnTb.Location = new System.Drawing.Point(305, 89);
            this.LibPhnTb.MaxLength = 32767;
            this.LibPhnTb.Name = "LibPhnTb";
            this.LibPhnTb.PasswordChar = '\0';
            this.LibPhnTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LibPhnTb.SelectedText = "";
            this.LibPhnTb.SelectionLength = 0;
            this.LibPhnTb.SelectionStart = 0;
            this.LibPhnTb.ShortcutsEnabled = true;
            this.LibPhnTb.Size = new System.Drawing.Size(141, 23);
            this.LibPhnTb.TabIndex = 4;
            this.LibPhnTb.UseSelectable = true;
            this.LibPhnTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LibPhnTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkViolet;
            this.button4.Location = new System.Drawing.Point(491, 148);
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
            this.label2.Location = new System.Drawing.Point(153, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name ";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkViolet;
            this.button3.Location = new System.Drawing.Point(376, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LibNameTb
            // 
            // 
            // 
            // 
            this.LibNameTb.CustomButton.Image = null;
            this.LibNameTb.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.LibNameTb.CustomButton.Name = "";
            this.LibNameTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LibNameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LibNameTb.CustomButton.TabIndex = 1;
            this.LibNameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LibNameTb.CustomButton.UseSelectable = true;
            this.LibNameTb.CustomButton.Visible = false;
            this.LibNameTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.LibNameTb.Lines = new string[0];
            this.LibNameTb.Location = new System.Drawing.Point(157, 89);
            this.LibNameTb.MaxLength = 32767;
            this.LibNameTb.Multiline = true;
            this.LibNameTb.Name = "LibNameTb";
            this.LibNameTb.PasswordChar = '\0';
            this.LibNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LibNameTb.SelectedText = "";
            this.LibNameTb.SelectionLength = 0;
            this.LibNameTb.SelectionStart = 0;
            this.LibNameTb.ShortcutsEnabled = true;
            this.LibNameTb.Size = new System.Drawing.Size(142, 23);
            this.LibNameTb.TabIndex = 2;
            this.LibNameTb.UseSelectable = true;
            this.LibNameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LibNameTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkViolet;
            this.button2.Location = new System.Drawing.Point(261, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkViolet;
            this.button1.Location = new System.Drawing.Point(146, 148);
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
            this.label4.Location = new System.Drawing.Point(449, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(314, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Librarian List";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LibrarianDataset
            // 
            this.LibrarianDataset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LibrarianDataset.BackgroundColor = System.Drawing.Color.Thistle;
            this.LibrarianDataset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LibrarianDataset.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LibrarianDataset.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LibrarianDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LibrarianDataset.DefaultCellStyle = dataGridViewCellStyle2;
            this.LibrarianDataset.Location = new System.Drawing.Point(10, 292);
            this.LibrarianDataset.Name = "LibrarianDataset";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LibrarianDataset.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LibrarianDataset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LibrarianDataset.Size = new System.Drawing.Size(723, 201);
            this.LibrarianDataset.TabIndex = 19;
            this.LibrarianDataset.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LibrarianDataset_CellClick);
            this.LibrarianDataset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LibBackBtn
            // 
            this.LibBackBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibBackBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.LibBackBtn.Location = new System.Drawing.Point(344, 499);
            this.LibBackBtn.Name = "LibBackBtn";
            this.LibBackBtn.Size = new System.Drawing.Size(110, 29);
            this.LibBackBtn.TabIndex = 20;
            this.LibBackBtn.Text = "Back";
            this.LibBackBtn.UseVisualStyleBackColor = true;
            this.LibBackBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(498, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 530);
            this.Controls.Add(this.LibBackBtn);
            this.Controls.Add(this.LibrarianDataset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "librarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "librarian";
            this.Load += new System.EventHandler(this.librarian_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibrarianDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox LibPassTb;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox LibPhnTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private MetroFramework.Controls.MetroTextBox LibNameTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView LibrarianDataset;
        private System.Windows.Forms.Button LibBackBtn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}