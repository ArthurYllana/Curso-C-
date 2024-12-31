﻿

System.Console.WriteLine("Quantidade de produtos: ");
int n = int.Parse(Console.ReadLine());

Product[] vect = new Product[n];

for(int i = 0; i < n; i++){
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine());
    vect[i] = new Product{
        Name = name,
        Price = price
    };
}

double sum = 0.0;
for (int i = 0; i < n; i++){
    sum += vect[i].Price;
}

double avg = sum / n;
System.Console.WriteLine("Preço média: " + avg.ToString("F2"));