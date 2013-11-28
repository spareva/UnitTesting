using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    protected string name;
    protected int uniqueNumber;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value == null || value == "")
            {
                throw new ArgumentException("Name cannot be omitted");
            }
            this.name = value;
        }
    }
    public int UniqueNumber
    {
        get
        {
            return this.uniqueNumber;
        }
        protected set
        {
            if (value < 10000 || value > 99999)
            {
                throw new ArgumentOutOfRangeException("Invalid student number");
            }
            this.uniqueNumber = value;
        }
    }

    public List<Course> Courses = new List<Course>();

    public Student(string name, int number, School school)
    {
        this.Name = name;
        this.UniqueNumber = number;
        school.AddStudent(this);
    }

    public void JoinCourse(Course course)
    {
        this.Courses.Add(course);
        course.AddStudent(this);
    }

    public void LeaveCourse(Course course)
    {
        this.Courses.Remove(course);
        course.RemoveStudent(this);
    }
}
