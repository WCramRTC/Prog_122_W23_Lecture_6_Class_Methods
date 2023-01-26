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
    public class Student
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

        //Review: What’s the name for any field, constructor, property or method that is part of a class?
        // Members

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

        //Review: What are the 4 parts of declaring a method?
        // Access Modifier - return type - Name - Paremeters
        //What keyword allows you to access members related to the specific instance?
        public double StudentAverage()
        {
            return (_csiGrade + _genEdGrade) / 2;
        }

        // public double StudentAverage(double csigrade, double genedgrade)
        // return (csigrade + genedgrade) / 2


        // s.FirstName + " " + s.LastName + " " + s.CsiGrade + " " + s.GenEdGrade;

        //What does “override .ToString()” allow us to do?



        //What is a class method?
        // A class method directly interacts with the memebers of a class



        //A method build inside a class has access to what, even it’s access modifier is set to private?


        // How to override to string
        // First Name Last Name - CSI Grade - Gen Grade
        public override string ToString()
        {
            return $"{this._firstName} {this._lastName} - Gen Ed Grade: {this._genEdGrade} - CSI Grade {this._csiGrade} - Average {StudentAverage()}";
        } // ToString
    }
}
