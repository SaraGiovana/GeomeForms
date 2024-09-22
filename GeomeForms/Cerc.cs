using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomeForms
{
    class Cerc
    {
        public double Raza 
            { get; set; }
        public double Perimetru()
        { return 2 * Math.PI * Raza;
        }
        public double Arie()
        { return Math.PI*Math.Pow(Raza, 2); }
        }
}