
namespace EjercicioPolimorfismo
{
    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(double Radio)
        {
            this.Radio = Radio;
        }

        public override double Area()
        {
            this.area = Math.PI * Math.Pow(this.Radio, 2);
            return this.area;
        }

        public override double Perimetro()
        {
            this.perimetro= (2 * Math.PI) * this.Radio;
            return this.perimetro;
        }


    }
}
