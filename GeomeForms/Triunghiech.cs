using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomeForms
{
    class Triunghiech
    {
     public double Latura { get; set; }
    
    public double Perimetru()
    { return 3*Latura;
    }
    public double Arie()
    { return (Math.Pow(Latura, 2) * Math.Sqrt(3)) / 4; }
    }
}