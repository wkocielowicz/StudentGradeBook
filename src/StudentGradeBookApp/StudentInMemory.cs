using System;
using System.Collections.Generic;

namespace StudentGradeBookApp
{
    public delegate void BadGradeWarningDelegate(object sender, EventArgs args);

    public class StudentInMemory : StudentBase
    {
        public override event BadGradeWarningDelegate BadGradeWarning;

        private List<double> grades = new List<double>();

        public StudentInMemory() : base()
        {
        }
        public StudentInMemory(string name, string surname) : base(name, surname)
        {
        }

        public override void AddGrade(string grade)
        {
            int gradeInt;
            if (int.TryParse(grade, out gradeInt) && gradeInt >= 1 && gradeInt <= 6)
            {
                this.grades.Add(gradeInt);

                if (gradeInt <= 3 && BadGradeWarning != null)
                {
                    BadGradeWarning(this, new EventArgs());
                }
            }
            else
            {
                switch (grade)
                {
                    case ("1+"):
                        this.grades.Add(1.5);
                        if (BadGradeWarning != null)
                        {
                            BadGradeWarning(this, new EventArgs());
                        }
                        break;
                    case ("2-"):
                        this.grades.Add(1.75);
                        if (BadGradeWarning != null)
                        {
                            BadGradeWarning(this, new EventArgs());
                        }
                        break;
                    case ("2+"):
                        this.grades.Add(2.5);
                        if (BadGradeWarning != null)
                        {
                            BadGradeWarning(this, new EventArgs());
                        }
                        break;
                    case ("3-"):
                        this.grades.Add(2.75);
                        if (BadGradeWarning != null)
                        {
                            BadGradeWarning(this, new EventArgs());
                        }
                        break;
                    case ("3+"):
                        this.grades.Add(3.5);
                        break;
                    case ("4-"):
                        this.grades.Add(3.75);
                        break;
                    case ("4+"):
                        this.grades.Add(4.5);
                        break;
                    case ("5-"):
                        this.grades.Add(4.75);
                        break;
                    case ("5+"):
                        this.grades.Add(5.5);
                        break;
                    case ("6-"):
                        this.grades.Add(5.75);
                        break;
                    default: throw new ArgumentException($"Invalid argument: {nameof(grade)}");
                }
            }
        }

        public override void ShowGrades()
        {
            Console.WriteLine($"{this.Name} {this.Surname}'s grades: ");
            if (this.grades.Count == 0)
            {
                Console.WriteLine("--empty--");
                Console.WriteLine("Add some grades in main menu.");
            }
            else
            {
                foreach (double grade in this.grades)
                {
                    Console.WriteLine(grade);
                }
            }
        }
        public override Statistics GetStatistics()
        {
            if (this.grades.Count == 0)
            {
                return null;
            }
            else
            {
                var statistic = new Statistics();
                foreach (double grade in this.grades)
                {
                    statistic.Add(grade);
                }
                return statistic;
            }
        }
    }
}
