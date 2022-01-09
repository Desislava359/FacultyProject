using System;
using System.Data.SqlClient;
using Dapper;

namespace FacultyProject.Models
{
    public class Teachers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AcademicRank { get; set; }

        public Teachers(string firstName, string lastName, string academicYear) 
        {
            FirstName = firstName;
            LastName = lastName;
            AcademicRank = academicYear;
        }

        public void AddTeacher()
        {
            using (SqlConnection connection = new SqlConnection(Helper.CnnValue("ProjectCS")))
            {
                connection.Execute($"INSERT INTO [dbo].[teacher_info](first_name, last_name, academic_rank) VALUES ('{FirstName}', '{LastName}', '{AcademicRank}')");
            }
        }
    }
}
