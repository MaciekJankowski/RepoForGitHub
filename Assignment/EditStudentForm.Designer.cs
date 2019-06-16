namespace Assignment
{
    partial class EditStudentForm
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
            this.EditStudentButton = new System.Windows.Forms.Button();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.CountyComboBox = new System.Windows.Forms.ComboBox();
            this.Address2Box = new System.Windows.Forms.TextBox();
            this.Address1Box = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.StudentNumberBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioPostgrad = new System.Windows.Forms.RadioButton();
            this.radioUndergrad = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MouseClickSearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(402, 168);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(85, 45);
            this.RefreshButton.TabIndex = 73;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(717, 214);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.MouseClickSearchBtn_Click);
            // 
            // EditStudentButton
            // 
            this.EditStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EditStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStudentButton.Location = new System.Drawing.Point(402, 54);
            this.EditStudentButton.Name = "EditStudentButton";
            this.EditStudentButton.Size = new System.Drawing.Size(85, 45);
            this.EditStudentButton.TabIndex = 70;
            this.EditStudentButton.Text = "Update Student";
            this.EditStudentButton.UseVisualStyleBackColor = false;
            this.EditStudentButton.Click += new System.EventHandler(this.EditStudentButton_Click);
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.Location = new System.Drawing.Point(402, 109);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(85, 45);
            this.CloseWindow.TabIndex = 74;
            this.CloseWindow.Text = "Close Window";
            this.CloseWindow.UseVisualStyleBackColor = false;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
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
            this.CountyComboBox.Location = new System.Drawing.Point(154, 122);
            this.CountyComboBox.Name = "CountyComboBox";
            this.CountyComboBox.Size = new System.Drawing.Size(214, 21);
            this.CountyComboBox.TabIndex = 95;
            // 
            // Address2Box
            // 
            this.Address2Box.Location = new System.Drawing.Point(154, 211);
            this.Address2Box.Name = "Address2Box";
            this.Address2Box.Size = new System.Drawing.Size(214, 20);
            this.Address2Box.TabIndex = 94;
            // 
            // Address1Box
            // 
            this.Address1Box.Location = new System.Drawing.Point(154, 181);
            this.Address1Box.Name = "Address1Box";
            this.Address1Box.Size = new System.Drawing.Size(214, 20);
            this.Address1Box.TabIndex = 93;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(154, 242);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(214, 20);
            this.EmailBox.TabIndex = 92;
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(154, 151);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(214, 20);
            this.CityBox.TabIndex = 90;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(154, 275);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(214, 20);
            this.PhoneBox.TabIndex = 88;
            // 
            // StudentNumberBox
            // 
            this.StudentNumberBox.Location = new System.Drawing.Point(154, 88);
            this.StudentNumberBox.Name = "StudentNumberBox";
            this.StudentNumberBox.Size = new System.Drawing.Size(214, 20);
            this.StudentNumberBox.TabIndex = 87;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 86;
            this.label10.Text = "Address 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 85;
            this.label9.Text = "Address 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 84;
            this.label8.Text = "Contact Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 83;
            this.label7.Text = "e-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 81;
            this.label5.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "County:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = "Student Number:";
            // 
            // radioPostgrad
            // 
            this.radioPostgrad.AutoSize = true;
            this.radioPostgrad.BackColor = System.Drawing.Color.Transparent;
            this.radioPostgrad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioPostgrad.Location = new System.Drawing.Point(280, 55);
            this.radioPostgrad.Name = "radioPostgrad";
            this.radioPostgrad.Size = new System.Drawing.Size(88, 17);
            this.radioPostgrad.TabIndex = 98;
            this.radioPostgrad.Text = "Postgraduate";
            this.radioPostgrad.UseVisualStyleBackColor = false;
            this.radioPostgrad.CheckedChanged += new System.EventHandler(this.radioPostgrad_CheckedChanged);
            // 
            // radioUndergrad
            // 
            this.radioUndergrad.AutoSize = true;
            this.radioUndergrad.BackColor = System.Drawing.Color.Transparent;
            this.radioUndergrad.Checked = true;
            this.radioUndergrad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioUndergrad.Location = new System.Drawing.Point(154, 54);
            this.radioUndergrad.Name = "radioUndergrad";
            this.radioUndergrad.Size = new System.Drawing.Size(96, 17);
            this.radioUndergrad.TabIndex = 97;
            this.radioUndergrad.TabStop = true;
            this.radioUndergrad.Text = "Undergraduate";
            this.radioUndergrad.UseVisualStyleBackColor = false;
            this.radioUndergrad.CheckedChanged += new System.EventHandler(this.radioUndergrad_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 96;
            this.label12.Text = "Education Level:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "Please fill all the fields to update the information.";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Assignment.Properties.Resources.conversation;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(531, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 188);
            this.panel1.TabIndex = 100;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Fuchsia;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(402, 257);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(138, 55);
            this.SearchButton.TabIndex = 101;
            this.SearchButton.Text = "Search By Student Number";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MouseClickSearchBtn
            // 
            this.MouseClickSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MouseClickSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouseClickSearchBtn.Location = new System.Drawing.Point(556, 257);
            this.MouseClickSearchBtn.Name = "MouseClickSearchBtn";
            this.MouseClickSearchBtn.Size = new System.Drawing.Size(144, 55);
            this.MouseClickSearchBtn.TabIndex = 102;
            this.MouseClickSearchBtn.Text = "Search by Clicking on a cell.";
            this.MouseClickSearchBtn.UseVisualStyleBackColor = false;
            this.MouseClickSearchBtn.Click += new System.EventHandler(this.MouseClickSearchBtn_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment.Properties.Resources.planeta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.MouseClickSearchBtn);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioPostgrad);
            this.Controls.Add(this.radioUndergrad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CountyComboBox);
            this.Controls.Add(this.Address2Box);
            this.Controls.Add(this.Address1Box);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.StudentNumberBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EditStudentButton);
            this.Name = "EditStudentForm";
            this.Text = "EditStudentForm";
            this.Load += new System.EventHandler(this.EditStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditStudentButton;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.ComboBox CountyComboBox;
        private System.Windows.Forms.TextBox Address2Box;
        private System.Windows.Forms.TextBox Address1Box;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox StudentNumberBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioPostgrad;
        private System.Windows.Forms.RadioButton radioUndergrad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button MouseClickSearchBtn;
    }
}