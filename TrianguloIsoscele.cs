using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class TrianguloIsoscele : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double LadoIgual { get; set; }

        public TrianguloIsoscele(double Base, double Altura, double LadoIgual)
        {
            this.Base = Base;
            this.Altura = Altura;
            this.LadoIgual = LadoIgual;
        }

        public override double Area()
        {
            this.area= (this.Base * this.Altura) / 2;
            return area;
        }

        public override double Perimetro()
        {
            this.perimetro = this.Base + (this.LadoIgual * 2);
            return perimetro;
        }
    }
}
