namespace Group_Assignment9
{
    partial class DashboardForm
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
            dgvTopStudents = new DataGridView();
            dgvCourseAverage = new DataGridView();
            dgvGenderStats = new DataGridView();
            lblTopStudents = new Label();
            lbCourseAverage = new Label();
            lbGenderStats = new Label();
            lbStudentsUnder21 = new Label();
            lbAllPassed = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTopStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourseAverage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGenderStats).BeginInit();
            SuspendLayout();
            // 
            // dgvTopStudents
            // 
            dgvTopStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopStudents.Location = new Point(292, 23);
            dgvTopStudents.Name = "dgvTopStudents";
            dgvTopStudents.RowHeadersWidth = 82;
            dgvTopStudents.Size = new Size(1163, 242);
            dgvTopStudents.TabIndex = 0;
            // 
            // dgvCourseAverage
            // 
            dgvCourseAverage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourseAverage.Location = new Point(292, 293);
            dgvCourseAverage.Name = "dgvCourseAverage";
            dgvCourseAverage.RowHeadersWidth = 82;
            dgvCourseAverage.Size = new Size(1163, 238);
            dgvCourseAverage.TabIndex = 1;
            // 
            // dgvGenderStats
            // 
            dgvGenderStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenderStats.Location = new Point(292, 563);
            dgvGenderStats.Name = "dgvGenderStats";
            dgvGenderStats.RowHeadersWidth = 82;
            dgvGenderStats.Size = new Size(677, 291);
            dgvGenderStats.TabIndex = 2;
            // 
            // lblTopStudents
            // 
            lblTopStudents.AutoSize = true;
            lblTopStudents.Location = new Point(50, 105);
            lblTopStudents.Name = "lblTopStudents";
            lblTopStudents.Size = new Size(173, 32);
            lblTopStudents.TabIndex = 3;
            lblTopStudents.Text = "Top 3 Students";
            // 
            // lbCourseAverage
            // 
            lbCourseAverage.AutoSize = true;
            lbCourseAverage.Location = new Point(50, 356);
            lbCourseAverage.Name = "lbCourseAverage";
            lbCourseAverage.Size = new Size(182, 32);
            lbCourseAverage.TabIndex = 4;
            lbCourseAverage.Text = "Course Average";
            // 
            // lbGenderStats
            // 
            lbGenderStats.AutoSize = true;
            lbGenderStats.Location = new Point(50, 629);
            lbGenderStats.Name = "lbGenderStats";
            lbGenderStats.Size = new Size(164, 32);
            lbGenderStats.TabIndex = 5;
            lbGenderStats.Text = "Gender Count";
            // 
            // lbStudentsUnder21
            // 
            lbStudentsUnder21.AutoSize = true;
            lbStudentsUnder21.Location = new Point(116, 904);
            lbStudentsUnder21.Name = "lbStudentsUnder21";
            lbStudentsUnder21.Size = new Size(217, 32);
            lbStudentsUnder21.TabIndex = 6;
            lbStudentsUnder21.Text = "Under 21 Students:";
            // 
            // lbAllPassed
            // 
            lbAllPassed.AutoSize = true;
            lbAllPassed.Location = new Point(651, 904);
            lbAllPassed.Name = "lbAllPassed";
            lbAllPassed.Size = new Size(102, 32);
            lbAllPassed.TabIndex = 7;
            lbAllPassed.Text = "No Data";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1563, 1018);
            Controls.Add(lbAllPassed);
            Controls.Add(lbStudentsUnder21);
            Controls.Add(lbGenderStats);
            Controls.Add(lbCourseAverage);
            Controls.Add(lblTopStudents);
            Controls.Add(dgvGenderStats);
            Controls.Add(dgvCourseAverage);
            Controls.Add(dgvTopStudents);
            Name = "DashboardForm";
            Text = "Dashboard Form";
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTopStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourseAverage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGenderStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTopStudents;
        private DataGridView dgvCourseAverage;
        private DataGridView dgvGenderStats;
        private Label lblTopStudents;
        private Label lbCourseAverage;
        private Label lbGenderStats;
        private Label lbStudentsUnder21;
        private Label lbAllPassed;
    }
}