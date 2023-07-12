using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace dz2.Model
{
    internal class FruitsVegs
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public double Calory { get; set; }

        public override string ToString()
        {
            return String.Format($"{ID} {Name} {Type} {Color} {Calory.ToString("F2")}");
        }
    }

   
}
