namespace Friday_Project
{
    partial class Student
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.showRecords = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.add_Student = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.contactNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 69);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.genderComboBox);
            this.groupBox1.Controls.Add(this.dobPicker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.showRecords);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.add_Student);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.contactNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.emailId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.passwordBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fullName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 741);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 465);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 276);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(319, 250);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(228, 30);
            this.genderComboBox.TabIndex = 18;
            this.genderComboBox.Text = "              -Select-";
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            // 
            // dobPicker
            // 
            this.dobPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobPicker.Location = new System.Drawing.Point(319, 298);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(228, 22);
            this.dobPicker.TabIndex = 17;
            this.dobPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dobPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 38);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date Of Birth";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // showRecords
            // 
            this.showRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRecords.Location = new System.Drawing.Point(567, 375);
            this.showRecords.Name = "showRecords";
            this.showRecords.Size = new System.Drawing.Size(267, 47);
            this.showRecords.TabIndex = 15;
            this.showRecords.Text = "Display All Students";
            this.showRecords.UseVisualStyleBackColor = true;
            this.showRecords.Click += new System.EventHandler(this.showRecords_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(420, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 47);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteRecord);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(266, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 47);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.updateRecord);
            // 
            // add_Student
            // 
            this.add_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Student.Location = new System.Drawing.Point(116, 375);
            this.add_Student.Name = "add_Student";
            this.add_Student.Size = new System.Drawing.Size(110, 47);
            this.add_Student.TabIndex = 12;
            this.add_Student.Text = "Add";
            this.add_Student.UseVisualStyleBackColor = true;
            this.add_Student.Click += new System.EventHandler(this.add_Student_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gender";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // contactNo
            // 
            this.contactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNo.Location = new System.Drawing.Point(319, 196);
            this.contactNo.Name = "contactNo";
            this.contactNo.Size = new System.Drawing.Size(228, 38);
            this.contactNo.TabIndex = 7;
            this.contactNo.TextChanged += new System.EventHandler(this.contactNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contact No";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // emailId
            // 
            this.emailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailId.Location = new System.Drawing.Point(322, 102);
            this.emailId.Name = "emailId";
            this.emailId.Size = new System.Drawing.Size(228, 38);
            this.emailId.TabIndex = 5;
            this.emailId.TextChanged += new System.EventHandler(this.emailId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(320, 149);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(228, 38);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fullName
            // 
            this.fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.Location = new System.Drawing.Point(322, 58);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(228, 38);
            this.fullName.TabIndex = 1;
            this.fullName.TextChanged += new System.EventHandler(this.fullName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 810);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contactNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showRecords;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add_Student;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}