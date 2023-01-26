using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_W23_Lecture_6_Class_Methods
{
    public class Course
    {
        string _courseName;
        string _teacher;
        List<Student> _courseRoster = new List<Student>();

        public Course(string courseName, string teacher)
        {
            _courseName = courseName;
            _teacher = teacher;
        }

        public string CourseName { get => _courseName; set => _courseName = value; }
        public string Teacher { get => _teacher; set => _teacher = value; }
        internal List<Student> CourseRoster { get => _courseRoster; }

        // Methods
        public void EnrollStudent(Student student)
        {
            _courseRoster.Add(student);
        }

        public double RosterAverage()
        {
            double sum = 0;
            foreach (Student student in _courseRoster)
            {
                sum += student.StudentAverage();

            }

            return sum / _courseRoster.Count;
        }

    }
}
