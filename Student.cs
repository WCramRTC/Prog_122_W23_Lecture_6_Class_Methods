using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_W23_Lecture_6_Class_Methods
{
    // internal
    // public
    // private
    // protected
    class Student
    {
        // Field
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;

        // Constructor
        //public Student(string firstName)
        //{
        //    this._firstName = firstName;
        //}
        public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }


        // Properties
        //    string _firstName;
        public string FirstName
        {
            // get and set
            // allows the user to read the value
            // allows the user to change the value
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName { get => _lastName; set => _lastName = value; }
        public double CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public double GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }



        // Method

        // What is a method?
        // A block of code that is given a name, and runs when it is called

        //What is the purpose of a method?
        // Easy to code, easy to read, easy to refactor, and easy to resuse

        //What is a class method?

    }
}
