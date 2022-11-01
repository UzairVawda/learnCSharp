using System;
namespace Classes
{
    public class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string studentName, string studentMajor, double studentGPA)
        {
            name = studentName;
            major = studentMajor;
            gpa = studentGPA;
        }

        public bool HasHonors()
        {
            if (gpa>=3.5)
            {
                return true;
            }
            return false;
        }
    }
}

