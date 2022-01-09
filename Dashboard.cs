using FacultyProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyProject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            TeachersForm tForm = new TeachersForm();
            tForm.Show();

        }

        private void disciplineButton_Click(object sender, EventArgs e)
        {
            DisciplineForm dForm = new DisciplineForm();
            dForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm sForm = new StudentForm();
            sForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentsAndDisciplinesForm sdForm = new StudentsAndDisciplinesForm();
            sdForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InformationForm iForm = new InformationForm();
            iForm.Show();
        }
    }
}
