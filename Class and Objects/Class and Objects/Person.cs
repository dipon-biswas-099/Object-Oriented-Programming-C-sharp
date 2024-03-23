using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Objects
{
    public class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;

        public Person( string fname , string mname, string lname)
        {
            firstName = fname;
            middleName = mname;
            lastName = lname;
        }

        public void setFirstName(string firstName)
        {
            if(firstName.Length >=2)
            {
                this.firstName = firstName; 
            }
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string GetFullName() // method 
        {
            string FullName = firstName + " " + middleName + " " + lastName;
            return FullName;
        }

    }
}
