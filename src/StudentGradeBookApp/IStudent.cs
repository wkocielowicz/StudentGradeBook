namespace StudentGradeBookApp
{
    public interface IStudent
    {
        void AddGrade(string grade);
        void ShowGrades();
        Statistics GetStatistics();
        event BadGradeWarningDelegate BadGradeWarning;
        string Surname { get; set; }
        string Name { get; set; }
        string FullName { get; }
        void ChangeName(string name);
        void ChangeSurname(string surname);
    }
}