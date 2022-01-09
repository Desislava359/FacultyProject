using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace FacultyProject.Models
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AcademicYear { get; set; }

        public Students(string firstName, string lastName, string academicYear)
        {
            FirstName = firstName;
            LastName = lastName;
            AcademicYear = academicYear;
        }

        public void AddStudent() 
        {
            using (SqlConnection connection = new SqlConnection(Helper.CnnValue("ProjectCS")))
            {
                connection.Execute($"INSERT INTO [dbo].[students](first_name, last_name, academic_year) VALUES ('{FirstName}', '{LastName}', '{AcademicYear}')");
            }
        }
    }
}
