using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Convertiplane : VerticalFlyLand
    {
        public int AscentSpeed { get; set; }
        public int Wingspan { get; set; }

        public Convertiplane(string name, int maxHorizontalSpeed, int maxAltitude, int ascentSpeed, int wingspan)
            : base(name, maxHorizontalSpeed, maxAltitude)
        {
            AscentSpeed = ascentSpeed;
            Wingspan = wingspan;
        }
    }
}
