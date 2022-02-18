using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Animal
    {
        public string Nombre { get; set; }
        public string Clasificacion { get; set; }
        public string Color { get; set; }

        public object clone()
        {
            return this.MemberwiseClone();
        }
    }
}
