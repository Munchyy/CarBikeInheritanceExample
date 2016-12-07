using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBikeInheritanceExample
{
    class Car : Vehicle
    {
        public Car(string colour, string model) : base(colour, model)
        {
            gears.Add('R');
            this.wheelNumber = 4;
            this.hornSound = "honk honk";
        }

        public override string Drive()
        {
            return "vroom vroom";
        }

        public string Reverse()
        {
            return "reversing";
        }


    }
}
