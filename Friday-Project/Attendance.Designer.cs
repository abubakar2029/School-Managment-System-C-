namespace Friday_Project
{
    partial class Attendance
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.aIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showRecords = new System.Windows.Forms.Button();
            this.updateAttendance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.add_attendance = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aIdTextBox
            // 
            this.aIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aIdTextBox.Location = new System.Drawing.Point(252, 87);
            this.aIdTextBox.Name = "aIdTextBox";
            this.aIdTextBox.Size = new System.Drawing.Size(228, 38);
            this.aIdTextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 38);
            this.label5.TabIndex = 19;
            this.label5.Text = "Attendance ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 204);
            this.dataGridView1.TabIndex = 18;
            // 
            // showRecords
            // 
            this.showRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRecords.Location = new System.Drawing.Point(12, 309);
            this.showRecords.Name = "showRecords";
            this.showRecords.Size = new System.Drawing.Size(357, 62);
            this.showRecords.TabIndex = 15;
            this.showRecords.Text = "Display All Records";
            this.showRecords.UseVisualStyleBackColor = true;
            this.showRecords.Click += new System.EventHandler(this.showRecords_Click);
            // 
            // updateAttendance
            // 
            this.updateAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAttendance.Location = new System.Drawing.Point(166, 237);
            this.updateAttendance.Name = "updateAttendance";
            this.updateAttendance.Size = new System.Drawing.Size(154, 57);
            this.updateAttendance.TabIndex = 13;
            this.updateAttendance.Text = "Update";
            this.updateAttendance.UseVisualStyleBackColor = true;
            this.updateAttendance.Click += new System.EventHandler(this.updateAttendance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // add_attendance
            // 
            this.add_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_attendance.Location = new System.Drawing.Point(12, 237);
            this.add_attendance.Name = "add_attendance";
            this.add_attendance.Size = new System.Drawing.Size(144, 57);
            this.add_attendance.TabIndex = 12;
            this.add_attendance.Text = "Add";
            this.add_attendance.UseVisualStyleBackColor = true;
            this.add_attendance.Click += new System.EventHandler(this.add_attendance_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTextBox.Location = new System.Drawing.Point(252, 132);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(228, 38);
            this.studentNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 69);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteRecord);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(this.aIdTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.showRecords);
            this.groupBox1.Controls.Add(this.updateAttendance);
            this.groupBox1.Controls.Add(this.add_attendance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.studentNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 602);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrollment Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // deleteRecord
            // 
            this.deleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecord.Location = new System.Drawing.Point(326, 237);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(154, 57);
            this.deleteRecord.TabIndex = 22;
            this.deleteRecord.Text = "Delete";
            this.deleteRecord.UseVisualStyleBackColor = true;
            this.deleteRecord.Click += new System.EventHandler(this.deleteRecord_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.statusComboBox.Location = new System.Drawing.Point(252, 190);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(228, 24);
            this.statusComboBox.TabIndex = 21;
            this.statusComboBox.Text = "Present";
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox aIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showRecords;
        private System.Windows.Forms.Button updateAttendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_attendance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button deleteRecord;
    }
}