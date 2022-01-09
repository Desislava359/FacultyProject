using FacultyProject.Models;
using FacultyProject.Presenters;
using System;
using System.Windows.Forms;

namespace FacultyProject.Views
{
    public partial class DisciplineForm : Form, IDisciplines
    {
        public DisciplineForm()
        {
            InitializeComponent();
        }

        public string DisciplineName
        {
            get { return disciplineName.Text; }
            set { disciplineName.Text = value; }
        }
        public int TeacherInfo 
        {
            get { return (int)chooseTeacher.SelectedValue; }
            set { chooseTeacher.SelectedValue = value; }
        }
        public string CreditHours 
        {
            get { return creditHours.Text; }
            set { creditHours.Text = value; }
        }

        private void addNewDiscipline_Click(object sender, EventArgs e)
        {
            DisciplinesPresenter discipline = new DisciplinesPresenter(this);
            discipline.SetDiscipline();

            DisciplineName = " ";
            CreditHours = " ";
            MessageBox.Show("Success!");
        }

        private void DisciplineForm_Load(object sender, EventArgs e)
        {
            Disciplines discipline = new Disciplines();

            string query = $"SELECT teacher_id, first_name, last_name, first_name + ' ' + last_name AS full_name FROM teacher_info;";
            string value = "full_name";
            string id = "teacher_id";

            discipline.Choose(chooseTeacher, query, value, id);
        }

        private void chooseTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
