using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class person
    {
        // class name and constructor name always same .
        public string FirstName { get; set; } // create property
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        // constructor 
        public person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;

        }
        public person(string firstName, string lastName) // constructor overloading 
        {
            FirstName = firstName;
            
            LastName = lastName;

        }
        // default constructor
        public person()
        {

        }

        public string getFullName()
        {
            string fullName = FirstName + " " + MiddleName + " " + LastName;
            return fullName;
        }
    }
}
