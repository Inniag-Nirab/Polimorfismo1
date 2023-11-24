namespace Polimorfismo
{
    public abstract class Forma
    {
        public abstract double CalcularArea();
    }

    public class Circulo : Forma
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }

    public class Rectangulo : Forma
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public override double CalcularArea()
        {
            return Ancho * Alto;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Forma circulo = new Circulo(5);
            Forma rectangulo = new Rectangulo(4, 6);

            Console.WriteLine($"El área del círculo es {circulo.CalcularArea():0.00}");
            Console.WriteLine($"El área del rectángulo es {rectangulo.CalcularArea():0.00}");
        }
    }
}

//Este programa crea una clase abstracta Forma con un método abstracto CalcularArea.
//Luego, crea las clases Circulo y Rectangulo que heredan de Forma y sobrescriben el método CalcularArea.
//En el método Main, se crean un Circulo y un Rectangulo, y se llama a su método CalcularArea.