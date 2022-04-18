using System;
using StudentGradeBookApp;
using Xunit;

namespace Challenge.Tests
{
    public class TypeTests
    {
        private StudentInMemory GetStudentFromMemory(string name, string surname)
        {
            return new StudentInMemory(name, surname);
        }
        private StudentInMemory GetStudentFromFile(string name, string surname)
        {
            return new StudentInMemory(name, surname);
        }


        [Fact]
        public void GetReferencesDifferentObjects1()
        {
            var stud1 = GetStudentFromMemory("Jan", "Kowalski");
            var stud2 = GetStudentFromMemory("Piotr", "Nowak");
            Assert.Equal("Jan Kowalski", stud1.FullName);
            Assert.Equal("Piotr Nowak", stud2.FullName);
            Assert.False(Object.ReferenceEquals(stud1, stud2));
            Assert.NotSame(stud1, stud2);
            Assert.False(StudentInMemory.Equals(stud1, stud2));
        }

        [Fact]
        public void GetReferencesDifferentObjects2()
        {
            var stud1 = GetStudentFromFile("Jan", "Kowalski");
            var stud2 = GetStudentFromFile("Piotr", "Nowak");
            Assert.Equal("Jan Kowalski", stud1.FullName);
            Assert.Equal("Piotr Nowak", stud2.FullName);
            Assert.False(Object.ReferenceEquals(stud1, stud2));
            Assert.NotSame(stud1, stud2);
            Assert.False(StudentInMemory.Equals(stud1, stud2));
        }

        [Fact]
        public void GetReferencesSameObjects1()
        {
            var stud1 = GetStudentFromMemory("Jan", "Kowalski");
            var stud2 = stud1;
            Assert.Equal("Jan Kowalski", stud1.FullName);
            Assert.Equal("Jan Kowalski", stud2.FullName);
            Assert.True(Object.ReferenceEquals(stud1, stud2));
            Assert.Same(stud1, stud2);
            Assert.True(StudentInMemory.Equals(stud1, stud2));
        }

        [Fact]
        public void GetReferencesSameObjects2()
        {
            var stud1 = GetStudentFromFile("Jan", "Kowalski");
            var stud2 = stud1;
            Assert.Equal("Jan Kowalski", stud1.FullName);
            Assert.Equal("Jan Kowalski", stud2.FullName);
            Assert.True(Object.ReferenceEquals(stud1, stud2));
            Assert.Same(stud1, stud2);
            Assert.True(StudentInMemory.Equals(stud1, stud2));
        }
    }
}
