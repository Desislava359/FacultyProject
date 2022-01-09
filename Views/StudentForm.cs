using FacultyProject.Presenters;
using System;
using System.Windows.Forms;

namespace FacultyProject.Views
{
    public partial class StudentForm : Form, IStudents
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        public string FirstName
        {
            get { return firstName.Text; }
            set { firstName.Text = value; }
        }
        public string LastName
        {
            get { return lastName.Text; }
            set { lastName.Text = value; }
        }
        public string AcademicYear
        {
            get { return academicYear.Text; }
            set { academicYear.Text = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StudentsPresenter newStudent = new StudentsPresenter(this);
            newStudent.SetStudent();

            FirstName = " ";
            LastName = " ";
            AcademicYear = " ";

            MessageBox.Show("Success!");
        }
    }
}
