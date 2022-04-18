using System;

namespace StudentGradeBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Welcome to the student's grade book. Select the application operating mode:");
            Console.WriteLine("Select '1' if you want to save the grades in the computer memory. The data will be lost when the program is closed.");
            Console.WriteLine("Select '2' if you want to save the grades in the text file.");
            input = Console.ReadLine();
            while (input != "1" & input != "2")
            {
                Console.WriteLine("Wrong value. Select '1' or '2':");
                input = Console.ReadLine();
            }

            if (input == "1")
            {
                var student = new StudentInMemory();
                student.BadGradeWarning += OnBadGradeWarning;
                student.AddPeople();
                Menu(student);
            }
            else
            {
                var student = new StudentInFile();
                student.BadGradeWarning += OnBadGradeWarning;
                student.AddPeople();
                Menu(student);
            }
        }

        private static void Menu(IStudent st)
        {
            while (true)
            {
                Console.WriteLine("\nSelect what you want to do:");
                Console.WriteLine("'1' - add grades, '2' - show grades, '3' - show statistics, '4' - change student's name, '5' - change student's surname, '6' - close program.");
                string input = Console.ReadLine();
                switch (input)
                {
                    case ("1"):
                        EnterGrade(st);
                        break;
                    case ("2"):
                        st.ShowGrades();
                        break;
                    case ("3"):
                        ShowStatistics(st);
                        break;
                    case ("4"):
                        {
                            Console.WriteLine("Enter new name of student: ");
                            string newName = Console.ReadLine();
                            st.ChangeName(newName);
                        }
                        break;
                    case ("5"):
                        {
                            Console.WriteLine("Enter new surname of student: ");
                            string newSurname = Console.ReadLine();
                            st.ChangeSurname(newSurname);
                        }
                        break;
                    case ("6"):
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong value! Try again.");
                        break;
                }
            }
        }

        private static void EnterGrade(IStudent st)
        {
            while (true)
            {
                Console.WriteLine($"Enter a grade for {st.FullName}. Enter 'f' for finish:");
                string input = Console.ReadLine();
                if (input == "f")
                {
                    break;
                }
                try
                {
                    st.AddGrade(input);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"{ex.Message}. Try again: ");
                }
            }
        }

        private static void ShowStatistics(IStudent st)
        {
            var statistic = new Statistics();
            statistic = st.GetStatistics();
            Console.WriteLine($"{st.FullName}'s statistic:");
            if (statistic == null)
            {
                Console.WriteLine("--empty--");
                Console.WriteLine("Add some grades in main menu.");
            }
            else
            {
                Console.WriteLine($"High grade: {statistic.highGrade}");
                Console.WriteLine($"Low grade: {statistic.lowGrade}");
                Console.WriteLine($"Average: {statistic.Average}");
            }
        }

        static void OnBadGradeWarning(object sender, EventArgs args)
        {
            Console.WriteLine("Oh no! We should inform student’s parents about this fact.");
        }
    }
}