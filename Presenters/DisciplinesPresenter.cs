using FacultyProject.Models;
using FacultyProject.Views;


namespace FacultyProject.Presenters
{
    public class DisciplinesPresenter
    {
        static IDisciplines disciplineView;


        public DisciplinesPresenter(IDisciplines view)
        {
            disciplineView = view;
        }

        public void SetDiscipline() 
        {
            Disciplines newDiscipline = new Disciplines();
            newDiscipline.AddDiscipline(disciplineView.DisciplineName, disciplineView.TeacherInfo, disciplineView.CreditHours);
        }

        
    }
}
