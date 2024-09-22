using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomeForms
{
    class Patrat
    { public double Latura { get; set; }
      public double Perimetru()
        {
            return 4 * Latura;
        }
      public double Arie()
        { return Math.Pow(Latura, 2); }
    }
}

