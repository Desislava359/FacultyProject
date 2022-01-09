using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace FacultyProject.Models
{
    public class StudentsAndDisciplines
    {
        public int StudentInfo { get; set; }
        public int DisciplineInfo { get; set; }

        public void AddRecord(int studentInfo, int disciplineInfo) 
        {
            using (SqlConnection connection = new SqlConnection(Helper.CnnValue("ProjectCS")))
            {
                StudentInfo = studentInfo;
                DisciplineInfo = disciplineInfo;

                connection.Execute($"INSERT INTO [dbo].[students_and_disciplines](discipline_id, student_id) VALUES ({DisciplineInfo}, {StudentInfo})");
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

        
        public void RemoveRecord(string query)
        {
            using (SqlConnection connection = new SqlConnection(Helper.CnnValue("ProjectCS")))
            {
                
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader myReader;

                try
                {
                    connection.Open();
                    myReader = cmd.ExecuteReader();

                    while (myReader.Read())
                    {

                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
