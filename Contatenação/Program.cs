int idade = 32;
double saldo = 10.3256;
string nome = "André";

System.Console.WriteLine("{0} tem {1} anos e seu saldo é de {2:C} rais", nome, idade, saldo);

System.Console.WriteLine($"{nome} tem {idade} anos e seu saldo é de {saldo:C} reais");

System.Console.WriteLine(nome + " tem " + idade + " anos e seu saldo é de R$" + saldo.ToString("F2") + " reais");
