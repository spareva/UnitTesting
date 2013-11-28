using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateStudentNameTest()
        {
            Student student = new Student("", 11000, new School("asd"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateStudentNumberOutOfMinRangeTest()
        {
            Student student = new Student("asd", 100, new School("asd"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateStudentNumberOutOfMaxRangeTest()
        {
            Student student = new Student("asd", 100000, new School("asd"));
        }

        [TestMethod]
        public void StudentJoinCourseTest()
        {
            Student student = new Student("asd", 10000, new School("asd"));
            Course course = new Course("math");
            student.JoinCourse(course);
            Assert.IsTrue(student.Courses.Contains(course), "Student joining course failed");
        }

        [TestMethod]
        public void StudentLeaveCourseTest()
        {
            Student student = new Student("asd", 10000, new School("asd"));
            Course course = new Course("math");
            student.JoinCourse(course);
            student.LeaveCourse(course);
            Assert.IsFalse(student.Courses.Contains(course), "Student leaving course failed");
        }
                
    }
}
