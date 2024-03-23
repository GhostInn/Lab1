using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Bomber : HorizontalFlyLand
    {
        public int MaxPayload { get; set; }
        public int Wingspan { get; set; }

        public Bomber(string name, int maxHorizontalSpeed, int maxAltitude, int maxPayload, int wingspan)
            : base(name, maxHorizontalSpeed, maxAltitude)
        {
            MaxPayload = maxPayload;
            Wingspan = wingspan;
        }
    }
}
