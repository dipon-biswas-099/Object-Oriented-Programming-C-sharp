using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("d","v","d");

            string finalName = person1.GetFullName();
            Console.WriteLine(finalName);
            // Console.ReadKey();

            Person person2 = new Person("e","r","d");

            Person person3 = new Person("data","hiding","1");
            string newName = person3.getFirstName();
            Console.WriteLine(newName);


             finalName = person2.GetFullName();
            Console.WriteLine(finalName);

            Console.ReadKey();



        }
    }
}
