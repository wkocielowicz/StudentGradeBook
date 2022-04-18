using System;
using System.IO;
using System.Collections.Generic;

namespace StudentGradeBookApp
{
    public class StudentInFile : StudentBase
    {
        public override event BadGradeWarningDelegate BadGradeWarning;
        private List<string> rightValuesOfGrades;
        private List<string> badGrades;
        private const string fileName = "grades.txt";
        public StudentInFile() : base()
        {
            rightValuesOfGrades = new List<string> { "1", "1+", "2-", "2", "2+", "3-", "3", "3+", "4-", "4", "4+", "5-", "5", "5+", "6" };
            badGrades = new List<string> { "1", "1+", "2-", "2", "2+", "3-", "3" };
        }

        public StudentInFile(string name, string surname) : base(name, surname)
        {
            rightValuesOfGrades = new List<string> { "1", "1+", "2-", "2", "2+", "3-", "3", "3+", "4-", "4", "4+", "5-", "5", "5+", "6" };
            badGrades = new List<string> { "1", "1+", "2-", "2", "2+", "3-", "3" };
        }

        public override void AddGrade(string grade)
        {
            using (var gradesWriter = File.AppendText(fileName))
            {
                if (rightValuesOfGrades.Contains(grade))
                {
                    gradesWriter.WriteLine(grade);
                    if (badGrades.Contains(grade) && BadGradeWarning != null)
                    {
                        BadGradeWarning(this, new EventArgs());
                    }
                    using (var gradesLogWriter = File.AppendText($"audit.txt"))
                    {
                        gradesLogWriter.WriteLine($"{grade}, {DateTime.UtcNow}");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong value! Try again.");
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            try
            {
                using (var gradesReader = File.OpenText(fileName))
                {
                    var line = gradesReader.ReadLine();
                    while (line != null)
                    {
                        switch (line)
                        {
                            case ("1"):
                                result.Add(1);
                                break;
                            case ("1+"):
                                result.Add(1.5);
                                break;
                            case ("2-"):
                                result.Add(1.75);
                                break;
                            case ("2"):
                                result.Add(2);
                                break;
                            case ("2+"):
                                result.Add(2.5);
                                break;
                            case ("3-"):
                                result.Add(2.75);
                                break;
                            case ("3"):
                                result.Add(3);
                                break;
                            case ("3+"):
                                result.Add(3.5);
                                break;
                            case ("4-"):
                                result.Add(3.75);
                                break;
                            case ("4"):
                                result.Add(4);
                                break;
                            case ("4+"):
                                result.Add(4.5);
                                break;
                            case ("5-"):
                                result.Add(4.75);
                                break;
                            case ("5"):
                                result.Add(5);
                                break;
                            case ("5+"):
                                result.Add(5.5);
                                break;
                            case ("6-"):
                                result.Add(5.75);
                                break;
                            case ("6"):
                                result.Add(6);
                                break;
                        }
                        line = gradesReader.ReadLine();
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
            }
            if (result.sum == 0)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public override void ShowGrades()
        {
            Console.WriteLine($"{this.Name} {this.Surname}'s grades: ");
            try
            {
                using (var gradesReader = File.OpenText(fileName))
                {
                    var line = gradesReader.ReadLine();
                    Console.WriteLine(line);
                    while (line != null)
                    {
                        line = gradesReader.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("--empty--");
                Console.WriteLine("Add some grades in main menu.");
            }
        }
    }
}
