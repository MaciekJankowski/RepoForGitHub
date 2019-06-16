namespace Assignment
{
    partial class AddNewStudentForm
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
            this.RefreshButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioPostgraduate = new System.Windows.Forms.RadioButton();
            this.radioUndergraduate = new System.Windows.Forms.RadioButton();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.CountyComboBox = new System.Windows.Forms.ComboBox();
            this.Address2Box = new System.Windows.Forms.TextBox();
            this.Address1Box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.StudentNumberBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.radioPostgrad = new System.Windows.Forms.RadioButton();
            this.radioUndergrad = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(497, 362);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(94, 60);
            this.RefreshButton.TabIndex = 60;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 444);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 214);
            this.dataGridView1.TabIndex = 59;
            // 
            // radioPostgraduate
            // 
            this.radioPostgraduate.AutoSize = true;
            this.radioPostgraduate.Location = new System.Drawing.Point(638, -16);
            this.radioPostgraduate.Name = "radioPostgraduate";
            this.radioPostgraduate.Size = new System.Drawing.Size(88, 17);
            this.radioPostgraduate.TabIndex = 58;
            this.radioPostgraduate.Text = "Postgraduate";
            this.radioPostgraduate.UseVisualStyleBackColor = true;
            // 
            // radioUndergraduate
            // 
            this.radioUndergraduate.AutoSize = true;
            this.radioUndergraduate.Checked = true;
            this.radioUndergraduate.Location = new System.Drawing.Point(533, -16);
            this.radioUndergraduate.Name = "radioUndergraduate";
            this.radioUndergraduate.Size = new System.Drawing.Size(96, 17);
            this.radioUndergraduate.TabIndex = 57;
            this.radioUndergraduate.TabStop = true;
            this.radioUndergraduate.Text = "Undergraduate";
            this.radioUndergraduate.UseVisualStyleBackColor = true;
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Items.AddRange(new object[] {
            "Software Development",
            "Arts",
            "Business",
            "Astrophisics",
            "History "});
            this.CourseComboBox.Location = new System.Drawing.Point(161, 189);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(214, 21);
            this.CourseComboBox.TabIndex = 56;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentButton.Location = new System.Drawing.Point(399, 362);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(90, 60);
            this.AddStudentButton.TabIndex = 55;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = false;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // CountyComboBox
            // 
            this.CountyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountyComboBox.FormattingEnabled = true;
            this.CountyComboBox.Items.AddRange(new object[] {
            "Co. Dublin",
            "Co. Kildare",
            "Co. Meath",
            "Co. Weastmeath",
            "Co. Cavan",
            "Co. Donegal",
            "Co. Mayo",
            "Co. Galway",
            "Co. Wexford",
            "Co. Waterford",
            "Co. Cork",
            "Co. Kerry",
            "Co. Limerick",
            "Co. Neverland"});
            this.CountyComboBox.Location = new System.Drawing.Point(161, 226);
            this.CountyComboBox.Name = "CountyComboBox";
            this.CountyComboBox.Size = new System.Drawing.Size(214, 21);
            this.CountyComboBox.TabIndex = 51;
            // 
            // Address2Box
            // 
            this.Address2Box.Location = new System.Drawing.Point(161, 333);
            this.Address2Box.Name = "Address2Box";
            this.Address2Box.Size = new System.Drawing.Size(214, 20);
            this.Address2Box.TabIndex = 50;
            // 
            // Address1Box
            // 
            this.Address1Box.Location = new System.Drawing.Point(161, 298);
            this.Address1Box.Name = "Address1Box";
            this.Address1Box.Size = new System.Drawing.Size(214, 20);
            this.Address1Box.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, -13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Education Level:";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(161, 371);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(214, 20);
            this.EmailBox.TabIndex = 47;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(161, 151);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(214, 20);
            this.SurnameBox.TabIndex = 46;
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(161, 262);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(214, 20);
            this.CityBox.TabIndex = 45;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(161, 117);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(214, 20);
            this.FirstNameBox.TabIndex = 44;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(161, 402);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(214, 20);
            this.PhoneBox.TabIndex = 43;
            // 
            // StudentNumberBox
            // 
            this.StudentNumberBox.Location = new System.Drawing.Point(161, 82);
            this.StudentNumberBox.MaxLength = 8;
            this.StudentNumberBox.Name = "StudentNumberBox";
            this.StudentNumberBox.Size = new System.Drawing.Size(214, 20);
            this.StudentNumberBox.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Address 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Address 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Contact Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "e-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "County:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Student Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "First Name:";
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.Location = new System.Drawing.Point(597, 362);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(91, 60);
            this.CloseWindow.TabIndex = 76;
            this.CloseWindow.Text = "Close Window";
            this.CloseWindow.UseVisualStyleBackColor = false;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // radioPostgrad
            // 
            this.radioPostgrad.AutoSize = true;
            this.radioPostgrad.BackColor = System.Drawing.Color.Transparent;
            this.radioPostgrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPostgrad.ForeColor = System.Drawing.Color.White;
            this.radioPostgrad.Location = new System.Drawing.Point(273, 53);
            this.radioPostgrad.Name = "radioPostgrad";
            this.radioPostgrad.Size = new System.Drawing.Size(100, 17);
            this.radioPostgrad.TabIndex = 79;
            this.radioPostgrad.Text = "Postgraduate";
            this.radioPostgrad.UseVisualStyleBackColor = false;
            this.radioPostgrad.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioUndergrad
            // 
            this.radioUndergrad.AutoSize = true;
            this.radioUndergrad.BackColor = System.Drawing.Color.Transparent;
            this.radioUndergrad.Checked = true;
            this.radioUndergrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUndergrad.ForeColor = System.Drawing.Color.White;
            this.radioUndergrad.Location = new System.Drawing.Point(161, 53);
            this.radioUndergrad.Name = "radioUndergrad";
            this.radioUndergrad.Size = new System.Drawing.Size(109, 17);
            this.radioUndergrad.TabIndex = 78;
            this.radioUndergrad.TabStop = true;
            this.radioUndergrad.Text = "Undergraduate";
            this.radioUndergrad.UseVisualStyleBackColor = false;
            this.radioUndergrad.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 77;
            this.label12.Text = "Education Level:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(157, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(222, 24);
            this.label13.TabIndex = 80;
            this.label13.Text = "Please fill all the fields.";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Assignment.Properties.Resources.clif;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(454, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 254);
            this.panel1.TabIndex = 83;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Fuchsia;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(694, 362);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(85, 60);
            this.SearchButton.TabIndex = 84;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddNewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Assignment.Properties.Resources.storm_clouds_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.radioPostgrad);
            this.Controls.Add(this.radioUndergrad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioPostgraduate);
            this.Controls.Add(this.radioUndergraduate);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.CountyComboBox);
            this.Controls.Add(this.Address2Box);
            this.Controls.Add(this.Address1Box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.StudentNumberBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewStudentForm";
            this.Text = "AddNewStudent";
            this.Load += new System.EventHandler(this.AddNewStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioPostgraduate;
        private System.Windows.Forms.RadioButton radioUndergraduate;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.ComboBox CountyComboBox;
        private System.Windows.Forms.TextBox Address2Box;
        private System.Windows.Forms.TextBox Address1Box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox StudentNumberBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.RadioButton radioPostgrad;
        private System.Windows.Forms.RadioButton radioUndergrad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchButton;
    }
}