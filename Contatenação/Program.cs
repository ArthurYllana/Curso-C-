using System;
using System.Collections.Generic;

/*int idade = 32;
double saldo = 10.3256;
string nome = "André";

System.Console.WriteLine("{0} tem {1} anos e seu saldo é de {2:C} rais", nome, idade, saldo);

System.Console.WriteLine($"{nome} tem {idade} anos e seu saldo é de {saldo:C} reais");

System.Console.WriteLine(nome + " tem " + idade + " anos e seu saldo é de R$" + saldo.ToString("F2") + " reais");

//System.Console.WriteLine(nome + " tem " + idade + " anos e seu saldo é de R$" + saldo.ToString("F2" ,CultureInfo.InvariantCulture) + " reais"); */

string produto1 = "Computador";
string produto2 = "Mesa de Escritório";

int idade = 30;
int codigo = 5902;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.2345;

System.Console.WriteLine("Produtos:");
System.Console.WriteLine($"{produto1}, cujo o preço é R$ {preco1:c}");
System.Console.WriteLine($"{produto2}, cujo o preço é R$ {preco2:c}");

System.Console.WriteLine($"Registro: {idade} anos de idade, código {codigo}, gênero: {genero}");
System.Console.WriteLine($"A medida mede {medida:F8} metros");
System.Console.WriteLine($"Arredondando {medida} para duas casas decimais temos {medida:F2}");