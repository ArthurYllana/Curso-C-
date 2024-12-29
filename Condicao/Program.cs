System.Console.WriteLine("Entre com um número inteiro: ");
int x = int.Parse(Console.ReadLine());

if(x % 2 == 0){
    System.Console.WriteLine("Par!");
}
else{
    System.Console.WriteLine("Ímpar!");
}


System.Console.WriteLine("Que horas são ?");
int hora = int.Parse(Console.ReadLine());

if(hora < 12){
    System.Console.WriteLine("Bom dia!");
}
else if(hora >= 12 && hora < 18){
    System.Console.WriteLine("Boa tarde!");
}
else{
    System.Console.WriteLine("Boa noite!");
}


System.Console.WriteLine("Digite o preço: ");
double preco = double.Parse(Console.ReadLine());
double desconto = 0.0;

if (preco > 100){
    desconto = preco * 0.1;
}
System.Console.WriteLine(desconto);

namespace Condicao {
    class Program {
        static void Main(string[] args) {
            System.Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            System.Console.WriteLine("O maior número é: " + resultado);
        }

        static int Maior(int a, int b, int c) {
            int m;
            if (a >= b && a >= c) {
                m = a;
            } else if (b >= a && b >= c) {
                m = b;
            } else {
                m = c;
            }
            return m; // Corrigido: Retorno da variável 'm'.
        }
    }
}

