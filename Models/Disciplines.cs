using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace FacultyProject.Models
{
    public class Disciplines
    {
        public string DisciplineName { get; set; }
        public int TeacherInfo { get; set; }
        public string CreditHours { get; set; }

      

        public void AddDiscipline(string disciplineName, int teacherInfo, string creditHours)
        {
            using (SqlConnection connection = new SqlConnection(Helper.CnnValue("ProjectCS")))
            {

                DisciplineName = disciplineName;
                TeacherInfo = teacherInfo;
                CreditHours = creditHours;

                connection.Execute($"INSERT INTO [dbo].[disciplines](name, teacher_id, credit_hours) VALUES ('{DisciplineName}', {TeacherInfo}, '{CreditHours}')");
            }
        }

        
        public void Choose(ComboBox choose, string query, string value, string id)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(Helper.CnnValue("ProjectCS")))
            {
                connection.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader myReader = cmd.ExecuteReader();

                    dt.Load(myReader);

                    cmd.Parameters.AddWithValue(value, choose);

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                    return;
                }

                choose.DataSource = dt;
                choose.ValueMember = id;
                choose.DisplayMember = value;

            }
        }
  
    }
}
