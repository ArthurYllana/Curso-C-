using System;
using System.Globalization;

namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {
            Produto2 p = new Produto2("TV", 500.0, 10);
            System.Console.WriteLine(p.GetNome);
        }
    }
}
