using System;
using System.Globalization;


string frase = Console.ReadLine();

System.Console.WriteLine("Você digitou: " + frase);

string s = Console.ReadLine();
string[] vet = s.Split(' ');
string a = vet[0];
string b = vet[1];
string c = vet[2];

System.Console.WriteLine(a);
System.Console.WriteLine(b);
System.Console.WriteLine(c);


int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string[] vet = Console.ReadLine().Split(' ');
string nome = vet[0];
char sexo = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


System.Console.WriteLine("Você digitou:");
System.Console.WriteLine(n1);
System.Console.WriteLine(ch);
System.Console.WriteLine(n2);
System.Console.WriteLine(nome);
System.Console.WriteLine(sexo);
System.Console.WriteLine(idade);
System.Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


System.Console.WriteLine("Entre com o seu nome completo:");
string nome = Console.ReadLine();
System.Console.WriteLine("Quantos quartos tem na sua casa?");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Entre com o preço em que você está vendendo a casa: R$");
double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.WriteLine("Entre seu último nome, idade e altura: ");
string[] vet = Console.ReadLine().Split(' ');
string sobrenome = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
System.Console.WriteLine("Você digitou:");
System.Console.WriteLine(sobrenome);
System.Console.WriteLine(idade);
System.Console.WriteLine(altura);