using FacultyProject.Models;
using FacultyProject.Presenters;
using System;
using System.Windows.Forms;

namespace FacultyProject.Views
{
    public partial class StudentsAndDisciplinesForm : Form, IStudentsAndDisciplines
    {
        StudentsAndDisciplines record = new StudentsAndDisciplines();
        public StudentsAndDisciplinesForm()
        {
            InitializeComponent();
        }

        public int StudentInfo
        {
            get { return (int)chooseStudent.SelectedValue; }
            set { chooseStudent.SelectedValue = value; }
        }
        public int DisciplineInfo
        {
            get { return (int)chooseDiscipline.SelectedValue; }
            set { chooseDiscipline.SelectedValue = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StudentsAndDisciplinesPresenter newRecord = new StudentsAndDisciplinesPresenter(this);
            newRecord.SetRecord();

            MessageBox.Show("Success");
        }

        private void StudentsAndDisciplinesForm_Load(object sender, EventArgs e)
        {
            string sQuery = $"SELECT student_id, first_name, last_name, first_name + ' ' + last_name AS full_name FROM students;";
            string sValue = "full_name";
            string sId = "student_id";

            string dQuery = $"SELECT discipline_id, name FROM disciplines;";
            string dValue = "name";
            string dId = "discipline_id";

            record.Choose(chooseStudent, sQuery, sValue, sId);
            record.Choose(chooseDiscipline, dQuery, dValue, dId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM students_and_disciplines WHERE student_id LIKE {StudentInfo} AND discipline_id LIKE {DisciplineInfo}";
            record.RemoveRecord(query);

            MessageBox.Show("Success!");
        }
    }
}
