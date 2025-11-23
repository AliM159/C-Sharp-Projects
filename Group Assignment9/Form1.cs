using System;
using System.Collections.Generic;
using System.Linq;
namespace Group_Assignment9

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvStudents.AllowUserToAddRows = false;
            RefreshGrid();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentEntryForm entryForm = new StudentEntryForm();
            entryForm.FormClosed += (s, args) => RefreshGrid();
            entryForm.ShowDialog();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // optional: you can leave this empty
        }

        // ✅ Add this below
        private void RefreshGrid()
        {
            dgvStudents.Rows.Clear();

            foreach (var student in StudentRepository.Students)
            {
                dgvStudents.Rows.Add(
                    student.StudentId,
                    student.FullName,
                    student.Gender,
                    student.DateOfBirth.ToString("yyyy-MM-dd"),
                    student.Department,
                    student.AverageGrade
                );
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
