using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person("dip", "kumar", "bissas");
            person person2 = new person("dip", "bissas"); // constructor overloading 
            person person3 = new person(); // this object for default constructor 
            string fullName = person1.getFullName();
            Console.WriteLine(fullName);
            Console.ReadKey();
        }
    }
}
