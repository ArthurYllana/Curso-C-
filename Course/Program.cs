using System;

namespace Course{
    class Program{
        static void Main(string[] args){
            byte n1 = 254;
            float f = 4.5f;
            char genero = 'F';
            char letra = '\u0041';
            int m1 = int.MinValue;
            int m2 = int.MaxValue;
            decimal m3 = decimal.MaxValue;

            Console.WriteLine(n1);
            System.Console.WriteLine(genero);
            System.Console.WriteLine(letra);
            Console.WriteLine(f);
            System.Console.WriteLine(m1);
            System.Console.WriteLine(m2);
            System.Console.WriteLine(m3);
        }
    }
}