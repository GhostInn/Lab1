using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class FighterJet : HorizontalFlyLand
    {
        public int Wingspan { get; set; }
        public int ThrustSpeed { get; set; }

        public FighterJet(string name, int maxHorizontalSpeed, int maxAltitude, int wingspan, int thrustSpeed)
            : base(name, maxHorizontalSpeed, maxAltitude)
        {
            Wingspan = wingspan;
            ThrustSpeed = thrustSpeed;
        }
    }
}
