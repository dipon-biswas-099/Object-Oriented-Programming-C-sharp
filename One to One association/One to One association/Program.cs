using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_to_One_association
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            adress.HouseNo = "102";
            adress.RoadNo = " Road - 2 ";
            adress.District = "Rajbari";
            adress.PostCode = "7745";

            person person1 = new person();
            person1.PresentAdress = adress;
            // Adress type 
            Adress myAdress = person1.PresentAdress;
            string houseNo = person1.PresentAdress.HouseNo;
            Console.WriteLine(houseNo);
            Console.ReadKey();

        }
    }
}
