using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Get_Property
{
    class Class1
    {
        private string firstName;
       
      //  public string 
        public string FirstName  // property  first latter capital 
        {
            set
            {
                if(value.Length >= 2)
                {
                    firstName = value;
                }
            }
            get
            {
                return firstName;

            }
        }
    }
}
