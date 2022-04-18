namespace StudentGradeBookApp
{
    public abstract class StudentBase : People, IStudent
    {
        public StudentBase() : base()
        {
        }

        public StudentBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public abstract event BadGradeWarningDelegate BadGradeWarning;

        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();

        public abstract void ShowGrades();
    }
}