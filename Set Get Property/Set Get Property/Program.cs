using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Get_Property
{
    class Program
    {
        static void Main(string[] args)
        {
             string firstName = "data";
            Class1 obj = new Class1();
            obj.FirstName = firstName;

            Console.WriteLine(firstName);
            Console.ReadKey();
        }
    }
}
