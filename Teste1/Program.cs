double XA, XB, XC, YA, YB, YC;

System.Console.WriteLine("Entre com as medidas do triângulo X: ");
XA = double.Parse(Console.ReadLine());
XB = double.Parse(Console.ReadLine());
XC = double.Parse(Console.ReadLine());

System.Console.WriteLine("Entre com as medidas do triângulo Y: ");
YA = double.Parse(Console.ReadLine());
YB = double.Parse(Console.ReadLine());
YC = double.Parse(Console.ReadLine());

double p = (XA + XB + XC)  / 2.0;
double areaX = Math.Sqrt(p * (p - XA) * (p - XB) * (p - XC));

p = (YA + YB + YC)  / 2.0;
double areaY = Math.Sqrt(p * (p - YA) * (p - YB) * (p - YC));

System.Console.WriteLine($"A área do triângulo X é: {areaX:c}");
System.Console.WriteLine($"A área do triângulo Y é: {areaY:c}");

if (areaX > areaY){
    System.Console.WriteLine("O triângulo X é maior que o triângulo Y");
}
else if (areaX < areaY){
    System.Console.WriteLine("O triângulo Y é maior que o triângulo X");
}
else{
    System.Console.WriteLine("Os triângulos X e Y são iguais");
}