using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Helicopter : VerticalFlyLand
    {
        public int AscentSpeed { get; set; }
        public int NumberOfRotors { get; set; }

        public Helicopter(string name, int maxHorizontalSpeed, int maxAltitude, int ascentSpeed, int numberOfRotors)
            : base(name, maxHorizontalSpeed, maxAltitude)
        {
            AscentSpeed = ascentSpeed;
            NumberOfRotors = numberOfRotors;
        }
    }
}
