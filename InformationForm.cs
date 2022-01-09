using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FacultyProject
{
    public partial class InformationForm : Form
    {
        Information info = new Information();
        public InformationForm()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string query = $"SELECT t.first_name AS FirstName, t.last_name AS LastName, CAST(COUNT(d.teacher_id) AS varchar) AS DisciplinesCount, 'Teacher' AS Type" +
                           $" FROM teacher_info AS t" +
                           $" INNER JOIN disciplines AS d" +
                           $" ON t.teacher_id = d.teacher_id " +
                           $"GROUP BY t.first_name, t.last_name " +
                           $"UNION ALL SELECT s.first_name, s.last_name, s.academic_year, 'Student' " +
                           $"FROM students AS s" +
                           $" ORDER BY t.first_name, t.last_name; ";

            info.GetInfo(query, dataInformation);
        }

        private void choosenDisciplinesButton_Click(object sender, EventArgs e)
        {
            string query = $"SELECT s.first_name, s.last_name, d.name" +
                           $" FROM students AS s " + 
                           $"INNER JOIN students_and_disciplines AS sd" + 
                           $" ON sd.student_id = s.student_id" + 
                           $" INNER JOIN disciplines AS d" + 
                           $" ON sd.discipline_id = d.discipline_id";

            info.GetInfo(query, dataInformation);
        }

        private void creditHoursButton_Click(object sender, EventArgs e)
        {
            string query = $"SELECT s.first_name AS FirstName, s.last_name AS LastName, SUM(d.credit_hours) AS CreditHours" +
                           $" FROM students AS s INNER JOIN students_and_disciplines AS sd" +
                           $" ON s.student_id = sd.student_id" +
                           $" INNER JOIN disciplines AS d" +
                           $" ON d.discipline_id = sd.discipline_id" +
                           $" GROUP BY s.first_name, s.last_name; ";

            info.GetInfo(query, dataInformation);
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            string query = $"SELECT t.first_name AS FirstName, t.last_name AS LastName, d.name AS DisciplineName, COUNT(sd.student_id) AS StudentsCount" +
                           $" FROM teacher_info AS t INNER JOIN disciplines AS d ON t.teacher_id = d.teacher_id" +
                           $" INNER JOIN students_and_disciplines AS sd" +
                           $" ON sd.discipline_id = d.discipline_id" +
                           $" GROUP BY t.first_name, t.last_name, d.name; ";

            info.GetInfo(query, dataInformation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT TOP 3 disciplines.name AS DisciplineName, COUNT(students_and_disciplines.student_id) AS StudentsCount " +
                           $"FROM disciplines INNER JOIN students_and_disciplines ON" +
                           $" disciplines.discipline_id = students_and_disciplines.discipline_id" +
                           $" GROUP BY disciplines.name" +
                           $" ORDER BY COUNT(students_and_disciplines.student_id) DESC; ";

            info.GetInfo(query, dataInformation);
        }
    }
}
