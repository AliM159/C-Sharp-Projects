using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment9
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                // Check if there are any students
                if (!StudentRepository.Students.Any())
                {
                    ShowNoDataMessage();
                    return;
                }

                LoadTopStudents();
                LoadCourseAverages();
                LoadGenderStatistics();
                LoadStudentsUnder21();
                LoadAllStudentsPassedStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowNoDataMessage()
        {
            // Clear all data grids and show no data message
            dgvTopStudents.DataSource = null;
            dgvCourseAverage.DataSource = null;
            dgvGenderStats.DataSource = null;
            lbStudentsUnder21.Text = "Students Under 21: 0";
            lbAllPassed.Text = "No Data";

            MessageBox.Show("No student data available. Please add students first.", "No Data",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadTopStudents()
        {
            // 1. Top 3 students based on average grades (only include students who have passed all courses with grades above 50)
            // Using LINQ Method Syntax
            var topStudents = StudentRepository.Students
                .Where(s => s.Courses.All(c => c.Grade > 50)) // Only students who passed all courses
                .OrderByDescending(s => s.AverageGrade)       // Order by average grade descending
                .Take(3)                                      // Take top 3
                .Select(s => new                             // Project to anonymous type for display
                {
                    StudentID = s.StudentId,
                    Name = s.FullName,
                    Department = s.Department,
                    AverageGrade = s.AverageGrade
                })
                .ToList();

            dgvTopStudents.DataSource = topStudents;

            // Format the DataGridView
            if (dgvTopStudents.Columns.Count > 0)
            {
                dgvTopStudents.Columns["StudentID"].HeaderText = "Student ID";
                dgvTopStudents.Columns["Name"].HeaderText = "Full Name";
                dgvTopStudents.Columns["Department"].HeaderText = "Department";
                dgvTopStudents.Columns["AverageGrade"].HeaderText = "Average Grade";
                dgvTopStudents.Columns["AverageGrade"].DefaultCellStyle.Format = "F2";
            }
        }



        private void LoadCourseAverages()
        {
            // 2. Average grade per course calculated across all students
            // Using LINQ Method Syntax
            var courseAverages = StudentRepository.Students
                .SelectMany(s => s.Courses)                    // Flatten all courses from all students
                .GroupBy(c => c.CourseName)                    // Group by course name
                .Select(g => new                               // Project to anonymous type
                {
                    CourseName = g.Key,
                    AverageGrade = Math.Round(g.Average(c => c.Grade), 2),
                    StudentCount = g.Count()
                })
                .OrderBy(c => c.CourseName)                    // Order alphabetically
                .ToList();

            dgvCourseAverage.DataSource = courseAverages;

            // Format the DataGridView
            if (dgvCourseAverage.Columns.Count > 0)
            {
                dgvCourseAverage.Columns["CourseName"].HeaderText = "Course Name";
                dgvCourseAverage.Columns["AverageGrade"].HeaderText = "Average Grade";
                dgvCourseAverage.Columns["StudentCount"].HeaderText = "Students";
                dgvCourseAverage.Columns["AverageGrade"].DefaultCellStyle.Format = "F2";
            }
        }


        private void LoadGenderStatistics()
        {
            // 3. Student count grouped by gender
            // Using LINQ Method Syntax
            var genderStats = StudentRepository.Students
                .GroupBy(s => s.Gender)                        // Group by gender
                .Select(g => new                               // Project to anonymous type
                {
                    Gender = g.Key,
                    Count = g.Count(),
                    Percentage = Math.Round((double)g.Count() / StudentRepository.Students.Count * 100, 1)
                })
                .OrderBy(g => g.Gender)                        // Order alphabetically
                .ToList();

            dgvGenderStats.DataSource = genderStats;

            // Format the DataGridView
            if (dgvGenderStats.Columns.Count > 0)
            {
                dgvGenderStats.Columns["Gender"].HeaderText = "Gender";
                dgvGenderStats.Columns["Count"].HeaderText = "Student Count";
                dgvGenderStats.Columns["Percentage"].HeaderText = "Percentage (%)";
                dgvGenderStats.Columns["Percentage"].DefaultCellStyle.Format = "F1";
            }
        }

        private void LoadStudentsUnder21()
        {
            // 4. Number of students under the age of 21
            // Using LINQ Method Syntax
            var currentDate = DateTime.Today;
            var studentsUnder21Count = StudentRepository.Students
                .Where(s => currentDate.Year - s.DateOfBirth.Year < 21 ||
                           (currentDate.Year - s.DateOfBirth.Year == 21 &&
                            currentDate.DayOfYear < s.DateOfBirth.DayOfYear)) // More accurate age calculation
                .Count();

            lbStudentsUnder21.Text = $"Students Under 21: {studentsUnder21Count}";
        }

        private void LoadAllStudentsPassedStatus()
        {
            // 5. Check if any or all students have passed all courses
            // Using LINQ Method Syntax
            if (!StudentRepository.Students.Any())
            {
                lbAllPassed.Text = "No Data";
                lbAllPassed.ForeColor = Color.Black;
                return;
            }

            var allStudentsPassed = StudentRepository.Students
                .All(s => s.Courses.All(c => c.Grade >= 50)); // All students passed all courses (>=50)

            var anyStudentPassed = StudentRepository.Students
                .Any(s => s.Courses.All(c => c.Grade >= 50)); // Any student passed all courses

            if (allStudentsPassed)
            {
                lbAllPassed.Text = "All Students passed";
            }
            else if (anyStudentPassed)
            {
                lbAllPassed.Text = "Some students failed";
            }
            else
            {
                lbAllPassed.Text = "None of the students passed";
            }
        }

    }
}
