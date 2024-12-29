using System;
using System.Globalization;

namespace Estatico1{
    class Program{
        static double Pi = 3.14;
        static void Main(string[] args){

            System.Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            System.Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circunferencia(double raio){
            return 2.0 * Pi * raio;
        }
        
        static double Volume(double raio){
            return (4.0/3.0) * Pi * raio * raio * raio;
        }
    }
}
