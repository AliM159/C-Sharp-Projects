namespace Group_Assignment9
{
    partial class StudentEntryForm
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
            txtName = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblDOB = new Label();
            dtpDOB = new DateTimePicker();
            grpCourses = new GroupBox();
            txtNetworking = new TextBox();
            txtTesting = new TextBox();
            txtJJava = new TextBox();
            cmbDepartment = new ComboBox();
            btnSave = new Button();
            btnClear = new Button();
            lbDepartment = new Label();
            grpCourses.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(207, 120);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(386, 47);
            txtName.TabIndex = 1;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(741, 126);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(110, 40);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender";
            lblGender.Click += lblGender_Click;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(880, 126);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(222, 58);
            cmbGender.TabIndex = 2;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 11F);
            lblDOB.Location = new Point(728, 318);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(79, 41);
            lblDOB.TabIndex = 4;
            lblDOB.Text = "DOB";
            // 
            // dtpDOB
            // 
            dtpDOB.Font = new Font("Segoe UI", 11F);
            dtpDOB.Location = new Point(832, 318);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(437, 47);
            dtpDOB.TabIndex = 4;
            dtpDOB.Value = new DateTime(2007, 12, 1, 13, 0, 0, 0);
            // 
            // grpCourses
            // 
            grpCourses.Controls.Add(txtNetworking);
            grpCourses.Controls.Add(txtTesting);
            grpCourses.Controls.Add(txtJJava);
            grpCourses.Font = new Font("Segoe UI", 12F);
            grpCourses.Location = new Point(139, 528);
            grpCourses.Name = "grpCourses";
            grpCourses.Size = new Size(436, 321);
            grpCourses.TabIndex = 5;
            grpCourses.TabStop = false;
            grpCourses.Text = "\tCourse Grades";
            // 
            // txtNetworking
            // 
            txtNetworking.Font = new Font("Segoe UI", 11F);
            txtNetworking.Location = new Point(39, 245);
            txtNetworking.Name = "txtNetworking";
            txtNetworking.PlaceholderText = "Networking";
            txtNetworking.Size = new Size(342, 47);
            txtNetworking.TabIndex = 8;
            // 
            // txtTesting
            // 
            txtTesting.Font = new Font("Segoe UI", 11F);
            txtTesting.Location = new Point(39, 168);
            txtTesting.Name = "txtTesting";
            txtTesting.PlaceholderText = "S/W Testing";
            txtTesting.Size = new Size(342, 47);
            txtTesting.TabIndex = 7;
            // 
            // txtJJava
            // 
            txtJJava.Font = new Font("Segoe UI", 11F);
            txtJJava.Location = new Point(39, 78);
            txtJJava.Name = "txtJJava";
            txtJJava.PlaceholderText = "Java Programming";
            txtJJava.Size = new Size(342, 47);
            txtJJava.TabIndex = 6;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(321, 312);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(272, 58);
            cmbDepartment.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11F);
            btnSave.Location = new Point(880, 528);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(412, 105);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11F);
            btnClear.Location = new Point(880, 715);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(412, 105);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lbDepartment
            // 
            lbDepartment.AutoSize = true;
            lbDepartment.Font = new Font("Segoe UI", 11F);
            lbDepartment.Location = new Point(68, 323);
            lbDepartment.Name = "lbDepartment";
            lbDepartment.Size = new Size(177, 41);
            lbDepartment.TabIndex = 0;
            lbDepartment.Text = "Department";
            // 
            // StudentEntryForm
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1736, 1219);
            Controls.Add(lbDepartment);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(cmbDepartment);
            Controls.Add(grpCourses);
            Controls.Add(dtpDOB);
            Controls.Add(lblDOB);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(txtName);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "StudentEntryForm";
            Text = "StudentEntryForm";
            Load += StudentEntryForm_Load;
            grpCourses.ResumeLayout(false);
            grpCourses.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblDOB;
        private DateTimePicker dtpDOB;
        private GroupBox grpCourses;
        private TextBox txtJJava;
        private ComboBox cmbDepartment;
        private TextBox txtTesting;
        private TextBox txtNetworking;
        private Button btnSave;
        private Button btnClear;
        private Label lbDepartment;
    }
}