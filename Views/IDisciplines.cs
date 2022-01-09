using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject.Views
{
    public interface IDisciplines
    {
        string DisciplineName { get; set; }
        int TeacherInfo { get; set; }
        string CreditHours { get; set; }
    }
}

