using FacultyProject.Models;
using FacultyProject.Views;


namespace FacultyProject.Presenters
{
    public class StudentsAndDisciplinesPresenter
    {
        IStudentsAndDisciplines recordView;

        public StudentsAndDisciplinesPresenter(IStudentsAndDisciplines view)
        {
            recordView = view;
        }

        public void SetRecord() 
        {
            StudentsAndDisciplines newRecord = new StudentsAndDisciplines();
            newRecord.AddRecord(recordView.StudentInfo, recordView.DisciplineInfo);
        }
    }
}
