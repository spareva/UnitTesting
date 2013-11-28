using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class School
{
    private string name;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (value == null || value == "")
            {
                throw new ArgumentException("Name of school missing");
            }
            this.name = value;
        }
    }

    public List<Student> AllStudents = new List<Student>();

    public School(string name)
    {
        this.Name = name;
    }

    public void AddStudent(Student student)
    {
        foreach (var person in this.AllStudents)
        {
            if (person.UniqueNumber == student.UniqueNumber)
            {
                throw new ArgumentException("Student number is not unique");
            }
        }
        this.AllStudents.Add(student);
    }

}
