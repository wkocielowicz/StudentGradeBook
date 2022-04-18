using StudentGradeBookApp;
using Xunit;

namespace Challenge.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1aLowGrade()
        {
            // arrange
            var stud1 = new StudentInMemory("Jan", "Kowalski");
            stud1.AddGrade("4");
            stud1.AddGrade("2");
            stud1.AddGrade("1+");
            stud1.AddGrade("5-");
            stud1.AddGrade("3");
            var stat = stud1.GetStatistics();
            // act
            var actual = stat.lowGrade;

            // assert
            Assert.Equal(1.5, actual);
        }

        [Fact]
        public void Test1bLowGrade()
        {
            // arrange
            var stud1 = new StudentInFile("Jan", "Kowalski");
            stud1.AddGrade("4");
            stud1.AddGrade("2");
            stud1.AddGrade("1+");
            stud1.AddGrade("5-");
            stud1.AddGrade("3");
            var stat = stud1.GetStatistics();
            // act
            var actual = stat.lowGrade;

            // assert
            Assert.Equal(1.5, actual);
        }

        [Fact]
        public void Test2aHighGrade()
        {
            // arrange
            var stud1 = new StudentInMemory("Jan", "Kowalski");
            stud1.AddGrade("4");
            stud1.AddGrade("2");
            stud1.AddGrade("1+");
            stud1.AddGrade("5-");
            stud1.AddGrade("3");
            var stat = stud1.GetStatistics();
            // act
            var actual = stat.highGrade;

            // assert
            Assert.Equal(4.75, actual);
        }

        [Fact]
        public void Test2bHighGrade()
        {
            // arrange
            var stud1 = new StudentInFile("Jan", "Kowalski");
            stud1.AddGrade("4");
            stud1.AddGrade("2");
            stud1.AddGrade("1+");
            stud1.AddGrade("5-");
            stud1.AddGrade("3");
            var stat = stud1.GetStatistics();
            // act
            var actual = stat.highGrade;

            // assert
            Assert.Equal(4.75, actual);
        }

        [Fact]
        public void Test3aAverage()
        {
            // arrange
            var stud1 = new StudentInMemory("Jan", "Kowalski");
            stud1.AddGrade("4");
            stud1.AddGrade("2");
            stud1.AddGrade("1+");
            stud1.AddGrade("5-");
            stud1.AddGrade("3");
            var stat = stud1.GetStatistics();
            // act
            var actual = stat.Average;

            // assert
            Assert.Equal(3.05, actual);
        }

        [Fact]
        public void Test3bAverage()
        {
            // arrange
            var stud1 = new StudentInFile("Jan", "Kowalski");
            stud1.AddGrade("4");
            stud1.AddGrade("2");
            stud1.AddGrade("1+");
            stud1.AddGrade("5-");
            stud1.AddGrade("3");
            var stat = stud1.GetStatistics();
            // act
            var actual = stat.Average;

            // assert
            Assert.Equal(3.05, actual);
        }

        [Fact]
        public void ChangeNameTest1()
        {
            var stud1 = new StudentInMemory("Jan", "Kowalski");
            stud1.ChangeName("P321iotr");
            Assert.Equal("Jan", stud1.Name);
            stud1.ChangeName("Marcin");
            Assert.Equal("Marcin", stud1.Name);
        }

        [Fact]
        public void ChangeNameTest2()
        {
            var stud1 = new StudentInFile("Jan", "Kowalski");
            stud1.ChangeName("P321iotr");
            Assert.Equal("Jan", stud1.Name);
            stud1.ChangeName("Marcin");
            Assert.Equal("Marcin", stud1.Name);
        }
    }
}
