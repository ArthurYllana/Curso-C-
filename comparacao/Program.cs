System.Console.WriteLine("Digite um preço: ");
double preco = double.Parse(Console.ReadLine());

double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
System.Console.WriteLine(desconto);
/*
if(preco < 20.0){
    desconto = preco * 0.1
}
else{
    desconto = preco * 0.05
}

*/