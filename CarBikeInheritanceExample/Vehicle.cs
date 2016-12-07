using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBikeInheritanceExample
{
    abstract class Vehicle
    {
        protected string colour;
        protected string model;
        protected List<char> gears;
        protected string hornSound;
        protected int wheelNumber;

        public Vehicle(string colour, string model)
        {
            this.gears = new List<char>(new char[] { 'N', '1', '2', '3', '4', '5' });
            this.colour = colour;
            this.model = model;
        }

        public string Horn()
        {
            return hornSound;
        }

        abstract public string Drive();

        public string Info()
        {
            string returnString = String.Format("VEHICLE INFO:\n Vehicle type - {0}\n Colour - {1}\n Model - {2}", GetType().Name, colour, model);
            return returnString;
        }

    }
}
