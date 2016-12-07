using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBikeInheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike myDadsBike = new Bike("Light Blue", "Triumph", 200);
            Car myCar = new Car("Silver", "Peugeot");

            Console.WriteLine(myDadsBike.Info());
            Console.WriteLine(myCar.Info());
            Console.ReadLine();
        }
    }
}
