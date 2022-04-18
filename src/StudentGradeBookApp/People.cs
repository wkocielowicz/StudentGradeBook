using System;

namespace StudentGradeBookApp
{
    public class People
    {
        public string Surname { get; set; }

        public string Name { get; set; }
        public string FullName
        {
            get
            {
                return this.Name + " " + this.Surname;
            }
        }
        public People()
        {
        }
        public void AddPeople()
        {
            bool nameIsWrong;
            do
            {
                nameIsWrong = false;
                Console.WriteLine("Enter the name of the student: ");
                this.Name = Console.ReadLine();
                foreach (var character in this.Name)
                {
                    if (Char.IsDigit(character))
                    {
                        Console.WriteLine($"{character} is digit.");
                        nameIsWrong = true;
                    }
                }
                if (nameIsWrong)
                {
                    Console.WriteLine("The value provided is not valid. Try again.");
                }
                else
                {
                    Console.WriteLine($"The name has been added.");
                }
            } while (nameIsWrong);

            bool surnameIsWrong;
            do
            {
                surnameIsWrong = false;
                Console.WriteLine("Enter the surname of the student: ");
                this.Surname = Console.ReadLine();
                foreach (var character in this.Surname)
                {
                    if (Char.IsDigit(character))
                    {
                        Console.WriteLine($"{character} is digit.");
                        surnameIsWrong = true;
                    }
                }
                if (surnameIsWrong)
                {
                    Console.WriteLine("The value provided is not valid. Try again.");
                }
                else
                {
                    Console.WriteLine($"The surname has been added.");
                }
            } while (surnameIsWrong);
        }
        public void ChangeName(string name)
        {
            bool nameIsWrong = false;
            foreach (var character in name)
            {
                if (Char.IsDigit(character))
                {
                    Console.WriteLine($"{character} is digit.");
                    nameIsWrong = true;
                }
            }
            if (nameIsWrong)
            {
                Console.WriteLine("The value provided is not valid. The name hasn't been changed.");
            }
            else
            {
                this.Name = name;
                Console.WriteLine($"The name has been chagend. The student's full name is: {this.FullName}");
            }
        }
        public void ChangeSurname(string surname)
        {
            bool SurnameIsWrong = false;
            foreach (var character in surname)
            {
                if (Char.IsDigit(character))
                {
                    Console.WriteLine($"{character} is digit.");
                    SurnameIsWrong = true;
                }
            }
            if (SurnameIsWrong)
            {
                Console.WriteLine("The value provided is not valid. The surname hasn't been changed.");
            }
            else
            {
                this.Surname = surname;
                Console.WriteLine($"The surname has been chagend. The student's full name is: {this.FullName}");
            }
        }
    }
}