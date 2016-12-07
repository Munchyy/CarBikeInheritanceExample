using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBikeInheritanceExample
{
    class Bike : Vehicle
    {
        int cc;

        public Bike(string colour, string model, int cc) : base(colour, model)
        {
            this.cc = cc;
            this.hornSound = "beep beep";
            this.wheelNumber = 2;
        }

        public override string Drive()
        {
            if (cc > 100)
                return "VRROOOOMM";
            if (cc > 50)
                return "vroom";

            return "weeee";
        }
    }
}
