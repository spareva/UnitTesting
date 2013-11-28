using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolTest
{
    [TestClass]
    public class TestSchool
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCreateSchool()
        {
            School school = new School("");            
        }

        [TestMethod]
        public void TestNameSchool()
        {
            School school = new School("school");
            Assert.AreEqual("school", school.Name, "Name not assigned properly");
        }

        [TestMethod]
        public void TestStudentJoinSchool()
        {
            Student student = new Student("asd", 10000, new School("asd"));
            School school = new School("school");
            school.AddStudent(student);
            Assert.IsTrue(school.AllStudents.Contains(student), "Student joining school failed");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentSameUniqueNumberJoinSchool()
        {
            School school = new School("school");
            Student student = new Student("asd", 10000, school);
            Student student2 = new Student("asd2", 10000, school);
            school.AddStudent(student);
            school.AddStudent(student2);
        }

        [TestMethod]
        public void TestStudentSameUniqueNumberJoinDifferentSchools()
        {
            School someschool = new School("someschool");
            School someschool2 = new School("someschool");
            School school = new School("school");
            School school2 = new School("school2");
            Student student = new Student("asd", 10002, someschool);
            Student student2 = new Student("asd2", 10002, someschool2);
            school.AddStudent(student);
            school2.AddStudent(student2);
        }
    }
}
