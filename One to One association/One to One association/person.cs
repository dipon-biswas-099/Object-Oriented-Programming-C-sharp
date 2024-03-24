using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_to_One_association
{
    class person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        // new property for adress class with adress type 
        public Adress PresentAdress { get; set; }


        public string getFullName() // function
        {
            string FullName = FirstName +" " +MiddleName + " " + LastName;
            return FullName;
        }
    }
}
