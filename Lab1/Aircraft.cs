using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Изначально был создан абстрактый класс Aircraft в нем были два основных значения,
// которые были во всех исследуемых классах техники, но потом я решил добавить еще названия,
// чтобы визуально было потом удобно читать при выводе задачи по распределению взлетной модели
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
        // some comment
        
        public abstract void Land();
    }
}
