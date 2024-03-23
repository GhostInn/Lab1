using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class Aircraft
    {
        public string Name { get; set; }
        public int MaxHorizontalSpeed { get; set; }
        public int MaxAltitude { get; set; }

        public Aircraft(string name, int maxHorizontalSpeed, int maxAltitude)
        {
            Name = name;
            MaxHorizontalSpeed = maxHorizontalSpeed;
            MaxAltitude = maxAltitude;
        }
    }
}
