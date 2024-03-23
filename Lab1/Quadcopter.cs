using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Quadcopter : VerticalFlyLand
    {
        public string Type { get; set; }
        public string ControlProtocol { get; set; }

        public Quadcopter(string name, int maxHorizontalSpeed, int maxAltitude, string type, string controlProtocol)
            : base(name, maxHorizontalSpeed, maxAltitude)
        {
            Type = type;
            ControlProtocol = controlProtocol;
        }
    }
}
