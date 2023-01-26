using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_W23_Lecture_6_Class_Methods.DataExample
{
    internal record class User
    {
        string _firstName;
        string _lastName;
        string _occupation;

        public User(string firstName, string lastName, string occupation)
        {
            _firstName = firstName;
            _lastName = lastName;
            _occupation = occupation;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Occupation { get => _occupation; set => _occupation = value; }
    }
}
