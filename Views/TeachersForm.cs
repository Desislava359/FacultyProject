using FacultyProject.Presenters;
using System;
using System.Windows.Forms;

namespace FacultyProject.Views
{
    public partial class TeachersForm : Form, ITeachers
    {
        public TeachersForm()
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
        public string AcademicRank 
        {
            get { return academicRank.Text; }
            set { academicRank.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeachersPresenter teacher = new TeachersPresenter(this);
            teacher.SetTeacher();

            FirstName = " ";
            LastName = " ";
            AcademicRank = " ";

            MessageBox.Show("Success!");
        }
    }
}
