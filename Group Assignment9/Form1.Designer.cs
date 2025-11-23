namespace Group_Assignment9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnDashboard = new Button();
            btnReports = new Button();
            btnExit = new Button();
            dgvStudents = new DataGridView();
            colStudentId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colDOB = new DataGridViewTextBoxColumn();
            colDepartment = new DataGridViewTextBoxColumn();
            colAverage = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1366, 384);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(257, 81);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(1366, 548);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(257, 102);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(1366, 740);
            btnReports.Margin = new Padding(4);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(257, 88);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1366, 922);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(257, 99);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colStudentId, colFullName, colGender, colDOB, colDepartment, colAverage });
            dgvStudents.Location = new Point(33, 51);
            dgvStudents.Margin = new Padding(4);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.Size = new Size(1278, 296);
            dgvStudents.TabIndex = 4;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // colStudentId
            // 
            colStudentId.HeaderText = "StudentId";
            colStudentId.MinimumWidth = 8;
            colStudentId.Name = "colStudentId";
            colStudentId.Width = 150;
            // 
            // colFullName
            // 
            colFullName.HeaderText = "FullName";
            colFullName.MinimumWidth = 8;
            colFullName.Name = "colFullName";
            colFullName.Width = 150;
            // 
            // colGender
            // 
            colGender.HeaderText = "Gender";
            colGender.MinimumWidth = 8;
            colGender.Name = "colGender";
            colGender.Width = 150;
            // 
            // colDOB
            // 
            colDOB.HeaderText = "DateOfBirth";
            colDOB.MinimumWidth = 8;
            colDOB.Name = "colDOB";
            colDOB.Width = 150;
            // 
            // colDepartment
            // 
            colDepartment.HeaderText = "Department";
            colDepartment.MinimumWidth = 8;
            colDepartment.Name = "colDepartment";
            colDepartment.Width = 150;
            // 
            // colAverage
            // 
            colAverage.HeaderText = "Average";
            colAverage.MinimumWidth = 8;
            colAverage.Name = "colAverage";
            colAverage.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(2079, 1231);
            Controls.Add(dgvStudents);
            Controls.Add(btnExit);
            Controls.Add(btnReports);
            Controls.Add(btnDashboard);
            Controls.Add(btnAdd);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Student Performance Tracker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnDashboard;
        private Button btnReports;
        private Button btnExit;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn colStudentId;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colDOB;
        private DataGridViewTextBoxColumn colDepartment;
        private DataGridViewTextBoxColumn colAverage;
    }
}
