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
    public partial class StudentEntryForm : Form
    {
        // Specify the maximum date of birth allowed (students must be born on or before this date)
        private readonly DateTime MaximumDateOfBirth = new DateTime(2007, 12, 12);

        public StudentEntryForm()
        {
            InitializeComponent();
        }

        private void StudentEntryForm_Load(object sender, EventArgs e)
        {
            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
            cmbDepartment.Items.AddRange(new string[] { "Networking", "IT", "S/W Testing" });

            cmbGender.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;

            dtpDOB.Value = new DateTime(2007, 12, 12);
        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // Validate all input fields
            if (!ValidateInput())
            {
                return; // Stop if validation fails
            }

            try
            {
                // Parse grades
                double javaGrade = double.Parse(txtJJava.Text.Trim());
                double testingGrade = double.Parse(txtTesting.Text.Trim());
                double networkingGrade = double.Parse(txtNetworking.Text.Trim());

                // Create new student object
                Student newStudent = new Student
                {
                    StudentId = StudentRepository.GetNextId(),
                    FullName = txtName.Text.Trim(),
                    Gender = cmbGender.SelectedItem?.ToString() ?? string.Empty,
                    DateOfBirth = dtpDOB.Value,
                    Department = cmbDepartment.SelectedItem?.ToString() ?? string.Empty
                };

                // Add course grades
                newStudent.Courses.Add(new CourseGrade
                {
                    CourseName = "Java Programming",
                    Grade = javaGrade
                });

                newStudent.Courses.Add(new CourseGrade
                {
                    CourseName = "S/W Testing",
                    Grade = testingGrade
                });

                newStudent.Courses.Add(new CourseGrade
                {
                    CourseName = "Networking",
                    Grade = networkingGrade
                });

                // No need to assign AverageGrade, it is computed property

                // Add student to repository
                StudentRepository.Students.Add(newStudent);




                // Clear the form after successful save
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the student: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private bool ValidateInput()
        {
            // Validate Name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the student's name.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // Validate Gender selection
            if (cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus();
                return false;
            }

            // Validate Department selection
            if (cmbDepartment.SelectedItem == null)
            {
                MessageBox.Show("Please select a department.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDepartment.Focus();
                return false;
            }

            // Validate Date of Birth (should not be in the future)
            if (dtpDOB.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Date of birth cannot be in the future.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDOB.Focus();
                return false;
            }

            // Validate Date of Birth (should not be after maximum allowed date)
            if (dtpDOB.Value.Date > MaximumDateOfBirth)
            {
                MessageBox.Show($"Students born after {MaximumDateOfBirth:MM/dd/yyyy} are not accepted.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDOB.Focus();
                return false;
            }

            // Validate Java Programming grade
            if (!ValidateGrade(txtJJava.Text, "Java Programming"))
            {
                txtJJava.Focus();
                return false;
            }

            // Validate S/W Testing grade
            if (!ValidateGrade(txtTesting.Text, "S/W Testing"))
            {
                txtTesting.Focus();
                return false;
            }

            // Validate Networking grade
            if (!ValidateGrade(txtNetworking.Text, "Networking"))
            {
                txtNetworking.Focus();
                return false;
            }

            return true; // All validations passed
        }

        private bool ValidateGrade(string gradeText, string courseName)
        {
            // Check if grade field is empty
            if (string.IsNullOrWhiteSpace(gradeText))
            {
                MessageBox.Show($"Please enter a grade for {courseName}.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if grade is a valid number
            if (!double.TryParse(gradeText.Trim(), out double grade))
            {
                MessageBox.Show($"Please enter a valid numeric grade for {courseName}.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if grade is within valid range (0-100)
            if (grade < 0 || grade > 100)
            {
                MessageBox.Show($"Grade for {courseName} must be between 0 and 100.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            // Clear all input fields
            txtName.Clear();
            txtJJava.Clear();
            txtTesting.Clear();
            txtNetworking.Clear();

            // Reset ComboBoxes to default selections
            cmbGender.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;

            // Reset DateTimePicker to today's date
            dtpDOB.Value = new DateTime(2007, 12, 12);

            // Set focus to the first field
            txtName.Focus();
        }
    }
}