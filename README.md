# StudentGradeBook
Simple Student's Grade Book console app.

Student Grade Book is a program where you can insert name and surname of student, assign him/her grades
in range { "1", "1+", "2-", "2", "2+", "3-", "3", "3+", "4-", "4", "4+", "5-", "5", "5+", "6" },
and display statistics (high grade, low grade, average). You can select one of two application operating mode:
1 - memory mode - everything is done in computer's memory. The data will be lost when the program is closed.
2 - file mode - grades are saved in and read from text file ("grade.txt"). In addition, an "audit.txt" file is created,
which contains logs with the date and time of the created grades.

Initial requirements for creating this application:
1. Inserting name, surname.
2. Changing name or surname.
3. Adding grades.
4. Displaying grades on console.
5. Calculating and displaying statistics (high grade, low grade, average).
6. Saving grades in text file.
7. Reading grades from text file.
8. Validating the correctness of entered data.
9. Displaying warning message when grade is less than or equal to 3.
10. Operation via interactive menu.

-----------MANUAL------------

Steps:
1. Open app (in cmd console: ...\StudentGradeBook\src\StudentGradeBookApp > dotnet run)
2. You will see the message: "Welcome to the student's grade book. Select the application operating mode:".
   Enter '1' if you want work on computer memory. Enter '2' if you want save grades in file "grade.txt".
   (Addition info: In operating mode '2' files "grade.txt" and "audit.txt" are created in the path:
    ".\StudentGradeBook\src\StudentGradeBookApp\bin\Debug\net5.0\").
3. Then you will see menu. Select options entering numbers on console [1-6] and follow the on-screen messages.

Enjoy!
