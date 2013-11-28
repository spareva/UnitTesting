using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Course
{
    public string Name { get; protected set; }

    public List<Student> StudentsInCourse = new List<Student>();

    public Course(string name)
    {
        this.Name = name;
    }

    public void AddStudent(Student student)
    {
        if (this.StudentsInCourse.Count >= 30)
        {
            throw new ArgumentOutOfRangeException("Over 30 students in course are not allowed");
        }
        this.StudentsInCourse.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        if (this.StudentsInCourse.Count == 0)
        {
            throw new ArgumentException("No students in this course");
        }
        else if (this.StudentsInCourse.IndexOf(student) == -1)
        {
            throw new ArgumentException("No such student found");
        }
        this.StudentsInCourse.Remove(student);
    }
}
