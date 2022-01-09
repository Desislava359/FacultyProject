using FacultyProject.Models;
using FacultyProject.Views;

namespace FacultyProject.Presenters
{
    public class TeachersPresenter
    {
        ITeachers teacherView;

        public TeachersPresenter(ITeachers view)
        {
            teacherView = view;
        }

        public void SetTeacher() 
        {
            Teachers newTeacher = new Teachers(teacherView.FirstName, teacherView.LastName, teacherView.AcademicRank);
            newTeacher.AddTeacher();
        }
    }
}
