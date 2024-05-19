namespace Friday_Project
{
    partial class Teacher
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
            this.teachersDataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.showRecords = new System.Windows.Forms.Button();
            this.deleteTeacherRecord = new System.Windows.Forms.Button();
            this.updateteacher = new System.Windows.Forms.Button();
            this.add_Teacher = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.contactNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teachersDataGridView
            // 
            this.teachersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersDataGridView.Location = new System.Drawing.Point(0, 465);
            this.teachersDataGridView.Name = "teachersDataGridView";
            this.teachersDataGridView.RowHeadersWidth = 51;
            this.teachersDataGridView.RowTemplate.Height = 24;
            this.teachersDataGridView.Size = new System.Drawing.Size(1133, 276);
            this.teachersDataGridView.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 69);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teachersDataGridView);
            this.groupBox1.Controls.Add(this.genderComboBox);
            this.groupBox1.Controls.Add(this.dobPicker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.showRecords);
            this.groupBox1.Controls.Add(this.deleteTeacherRecord);
            this.groupBox1.Controls.Add(this.updateteacher);
            this.groupBox1.Controls.Add(this.add_Teacher);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.contactNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.emailId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.passwordBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 672);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(249, 278);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(228, 30);
            this.genderComboBox.TabIndex = 18;
            this.genderComboBox.Text = "              -Select-";
            // 
            // dobPicker
            // 
            this.dobPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobPicker.Location = new System.Drawing.Point(249, 326);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(228, 22);
            this.dobPicker.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 38);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date Of Birth";
            // 
            // showRecords
            // 
            this.showRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRecords.Location = new System.Drawing.Point(495, 401);
            this.showRecords.Name = "showRecords";
            this.showRecords.Size = new System.Drawing.Size(267, 47);
            this.showRecords.TabIndex = 15;
            this.showRecords.Text = "Display All Records";
            this.showRecords.UseVisualStyleBackColor = true;
            this.showRecords.Click += new System.EventHandler(this.showRecords_Click);
            // 
            // deleteTeacherRecord
            // 
            this.deleteTeacherRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTeacherRecord.Location = new System.Drawing.Point(348, 401);
            this.deleteTeacherRecord.Name = "deleteTeacherRecord";
            this.deleteTeacherRecord.Size = new System.Drawing.Size(110, 47);
            this.deleteTeacherRecord.TabIndex = 14;
            this.deleteTeacherRecord.Text = "Delete";
            this.deleteTeacherRecord.UseVisualStyleBackColor = true;
            this.deleteTeacherRecord.Click += new System.EventHandler(this.deleteTeacherRecord_Click);
            // 
            // updateteacher
            // 
            this.updateteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateteacher.Location = new System.Drawing.Point(194, 401);
            this.updateteacher.Name = "updateteacher";
            this.updateteacher.Size = new System.Drawing.Size(110, 47);
            this.updateteacher.TabIndex = 13;
            this.updateteacher.Text = "Update";
            this.updateteacher.UseVisualStyleBackColor = true;
            this.updateteacher.Click += new System.EventHandler(this.updateteacher_Click);
            // 
            // add_Teacher
            // 
            this.add_Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Teacher.Location = new System.Drawing.Point(44, 401);
            this.add_Teacher.Name = "add_Teacher";
            this.add_Teacher.Size = new System.Drawing.Size(110, 47);
            this.add_Teacher.TabIndex = 12;
            this.add_Teacher.Text = "Add";
            this.add_Teacher.UseVisualStyleBackColor = true;
            this.add_Teacher.Click += new System.EventHandler(this.add_Teacher_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gender";
            // 
            // contactNo
            // 
            this.contactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNo.Location = new System.Drawing.Point(249, 224);
            this.contactNo.Name = "contactNo";
            this.contactNo.Size = new System.Drawing.Size(231, 38);
            this.contactNo.TabIndex = 7;
            this.contactNo.Text = "0322-1234567";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contact No";
            // 
            // emailId
            // 
            this.emailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailId.Location = new System.Drawing.Point(252, 130);
            this.emailId.Name = "emailId";
            this.emailId.Size = new System.Drawing.Size(228, 38);
            this.emailId.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email Id";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(250, 177);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(228, 38);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.Text = "demo123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTextBox.Location = new System.Drawing.Point(252, 86);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(228, 38);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name";
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 672);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Teacher";
            this.Text = "Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView teachersDataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button showRecords;
        private System.Windows.Forms.Button deleteTeacherRecord;
        private System.Windows.Forms.Button updateteacher;
        private System.Windows.Forms.Button add_Teacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contactNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label2;
    }
}