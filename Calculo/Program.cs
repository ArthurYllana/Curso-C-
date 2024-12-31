namespace Calculo{
    class Program{
        static void Main(string[] args){
           int a = 10;
           int Triple;
           Calculadora.Triple(a, out Triple);
           System.Console.WriteLine(Triple);
        }
    }
}