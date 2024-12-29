using System;
using System.Globalization;

/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número: ");
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while (x >= 0.0)
        {
            double raiz = Math.Sqrt(x); // Corrigido para Math.Sqrt
            Console.WriteLine("A raiz quadrada de " + x.ToString("F2", CultureInfo.InvariantCulture) + " é " + raiz.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Digite outro número: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Corrigido para Console.ReadLine
        }
    }
}
*/

System.Console.WriteLine("Quantos números você vai digitar? ");
int N = int.Parse(Console.ReadLine());
int soma = 0;

for (int i = 1; i <= N; i++){
    System.Console.Write("Valor #{00}: " , i);
    int valor = int.Parse(Console.ReadLine());
    soma += valor;
}
System.Console.WriteLine("Soma: " + soma);