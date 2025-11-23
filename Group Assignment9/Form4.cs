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


    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadReportsData();
        }

        private void LoadReportsData()
        {
            try
            {
                // Debug: Check student count
                int studentCount = StudentRepository.Students?.Count ?? 0;

                // Check if there are any students
                if (studentCount == 0)
                {
                    ShowNoDataMessage();
                    return;
                }

                LoadHighAchievers();
                LoadDepartmentStatistics();
                LoadFailures();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reports data: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowNoDataMessage()
        {
            // Clear all data grids and show no data message
            dvgHighAchivers.DataSource = null;
            dvgByDepartment.DataSource = null;
            dvgFailures.DataSource = null;

            MessageBox.Show("No student data available. Please add students first.", "No Data",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadHighAchievers()
        {
            try
            {
                // Students with an average grade above 70
                // Using LINQ Query Syntax
                var highAchievers = (from student in StudentRepository.Students
                                     where student.AverageGrade > 70
                                     orderby student.AverageGrade descending
                                     select new
                                     {
                                         StudentID = student.StudentId,
                                         Name = student.FullName,
                                         Gender = student.Gender,
                                         Department = student.Department,
                                         AverageGrade = student.AverageGrade,
                                         Status = student.AverageGrade >= 85 ? "Excellent" :
                                                student.AverageGrade >= 75 ? "Good" : "Satisfactory"
                                     }).ToList();
                dvgHighAchivers.DataSource = null;
                dvgHighAchivers.DataSource = highAchievers;

                // Format the DataGridView
                if (dvgHighAchivers.Columns.Count > 0)
                {
                    dvgHighAchivers.Columns["StudentID"].HeaderText = "Student ID";
                    dvgHighAchivers.Columns["Name"].HeaderText = "Full Name";
                    dvgHighAchivers.Columns["Gender"].HeaderText = "Gender";
                    dvgHighAchivers.Columns["Department"].HeaderText = "Department";
                    dvgHighAchivers.Columns["AverageGrade"].HeaderText = "Average Grade";
                    dvgHighAchivers.Columns["Status"].HeaderText = "Performance Status";
                    dvgHighAchivers.Columns["AverageGrade"].DefaultCellStyle.Format = "F2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading high achievers: {ex.Message}", "Error");
            }
        }

        private void LoadDepartmentStatistics()
        {
            // Students grouped by department, showing the count of students in each department
            // Using LINQ Query Syntax
            var departmentStats = (from student in StudentRepository.Students
                                   group student by student.Department into deptGroup
                                   orderby deptGroup.Key
                                   select new
                                   {
                                       Department = deptGroup.Key,
                                       StudentCount = deptGroup.Count(),
                                       AverageGrade = Math.Round(deptGroup.Average(s => s.AverageGrade), 2),
                                       HighestGrade = Math.Round(deptGroup.Max(s => s.AverageGrade), 2),
                                       LowestGrade = Math.Round(deptGroup.Min(s => s.AverageGrade), 2)
                                   }).ToList();

            dvgByDepartment.DataSource = null;
            dvgByDepartment.DataSource = departmentStats;

            // Format the DataGridView
            if (dvgByDepartment.Columns.Count > 0)
            {
                dvgByDepartment.Columns["Department"].HeaderText = "Department";
                dvgByDepartment.Columns["StudentCount"].HeaderText = "Students";
                dvgByDepartment.Columns["AverageGrade"].HeaderText = "Avg Grade";
                dvgByDepartment.Columns["HighestGrade"].HeaderText = "Highest";
                dvgByDepartment.Columns["LowestGrade"].HeaderText = "Lowest";
                dvgByDepartment.Columns["AverageGrade"].DefaultCellStyle.Format = "F2";
                dvgByDepartment.Columns["HighestGrade"].DefaultCellStyle.Format = "F2";
                dvgByDepartment.Columns["LowestGrade"].DefaultCellStyle.Format = "F2";
            }
        }

        private void LoadFailures()
        {
            // Students who have failed in any course (i.e., any grade below 50)
            // Using LINQ Query Syntax
            var failures = (from student in StudentRepository.Students
                            from course in student.Courses
                            where course.Grade < 50
                            group new { student, course } by new { student.StudentId, student.FullName, student.Department } into studentGroup
                            orderby studentGroup.Key.FullName
                            select new
                            {
                                StudentID = studentGroup.Key.StudentId,
                                Name = studentGroup.Key.FullName,
                                Department = studentGroup.Key.Department,
                                FailedCourses = string.Join(", ", studentGroup.Select(x => x.course.CourseName)),
                                FailedGrades = string.Join(", ", studentGroup.Select(x => x.course.Grade.ToString("F1"))),
                                FailureCount = studentGroup.Count()
                            }).ToList();

            dvgFailures.DataSource = failures;

            // Format the DataGridView
            if (dvgFailures.Columns.Count > 0)
            {
                dvgFailures.Columns["StudentID"].HeaderText = "Student ID";
                dvgFailures.Columns["Name"].HeaderText = "Full Name";
                dvgFailures.Columns["Department"].HeaderText = "Department";
                dvgFailures.Columns["FailedCourses"].HeaderText = "Failed Courses";
                dvgFailures.Columns["FailedGrades"].HeaderText = "Grades";
                dvgFailures.Columns["FailureCount"].HeaderText = "Failed Count";

                // Set column widths for better readability
                dvgFailures.Columns["StudentID"].FillWeight = 15;
                dvgFailures.Columns["Name"].FillWeight = 25;
                dvgFailures.Columns["Department"].FillWeight = 15;
                dvgFailures.Columns["FailedCourses"].FillWeight = 30;
                dvgFailures.Columns["FailedGrades"].FillWeight = 10;
                dvgFailures.Columns["FailureCount"].FillWeight = 5;
            }
        }

        private void ReportsForm_Load_1(object sender, EventArgs e)
        {
            LoadReportsData();
        }

        private void dvgFailures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
