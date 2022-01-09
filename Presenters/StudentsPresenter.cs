using FacultyProject.Models;
using FacultyProject.Views;

namespace FacultyProject.Presenters
{
    public class StudentsPresenter
    {
        IStudents studentView;

        public StudentsPresenter(IStudents view)
        {
            studentView = view;
        }


        public void SetStudent()
        {
            Students newDiscipline = new Students(studentView.FirstName, studentView.LastName, studentView.AcademicYear);
            newDiscipline.AddStudent();
        }
    }
}
