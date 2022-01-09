using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject.Views
{
    public interface ITeachers
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string AcademicRank { get; set; }
    }
}
