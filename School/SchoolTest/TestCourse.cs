using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolTest
{
    [TestClass]
    public class TestCourse     // I have no idea why dotcover doesn't recognize this part and claims the Course class is never tested
    {                           // I cannot see my coverage in any way, but I don't think I have missed much
        [TestMethod]
        public void TestAddStudent()
        {
            Course math = new Course("math");
            Student someStudent = new Student("Penka", 11000, new School("school"));
            math.AddStudent(someStudent);
            Assert.AreEqual(1, math.StudentsInCourse.Count, "Student not added correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestFullStudents()
        {
            Course course = new Course("course");
            School college = new School("college");
            for (int i = 10001; i < 10033; i++)
            {
                course.AddStudent(new Student("asd", i, college));
            }
        }

        [TestMethod]
        public void TestRemoveStudent()
        {
            Course math = new Course("math");
            Student someStudent = new Student("Penka", 11000, new School("school"));
            math.AddStudent(someStudent);
            Student someStudent2 = new Student("Penka", 11001, new School("school"));
            math.AddStudent(someStudent2);
            math.RemoveStudent(someStudent);
            Assert.AreEqual(1, math.StudentsInCourse.Count, "Student not added correctly");
        }
    }
}
