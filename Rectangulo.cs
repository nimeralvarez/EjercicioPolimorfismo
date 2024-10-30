
namespace EjercicioPolimorfismo
{
    public class Rectangulo:Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public override double Area()
        {
            this.area= this.Base * this.Altura;
            return this.area;
        }

        public override double Perimetro()
        {
            this.perimetro= (2 * this.Altura) + (2 * this.Base);
            return this.perimetro;
        }

        
    }
}
