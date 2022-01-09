using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject.Views
{
    public interface IStudents
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string AcademicYear { get; set; }
    }
}
