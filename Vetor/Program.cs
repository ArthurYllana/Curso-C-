﻿using System;
using System.Globalization;

System.Console.WriteLine("Digite um número inteiro: ");
int n = int.Parse(Console.ReadLine());

double[] vect = new double[n];

for(int i = 0; i < n; i++){
    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double sum = 0.0;
for (int i = 0; i < n; i++){
    sum += vect[i];
}

double avg = sum / n;

System.Console.WriteLine("Algura média: " + avg.ToString("F2", CultureInfo.InvariantCulture));
