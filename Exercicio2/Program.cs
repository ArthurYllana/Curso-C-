using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProdutoNamespace{
    public class Program{
        static void Main(string[] args)
        {
            Produto p = new Produto();
            System.Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            System.Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine("Dados do produto: " + p);

            System.Console.WriteLine("------------------------------");
            System.Console.Write("Digite o número a ser adicionado ao estoque:");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + p);

            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("Digite quantidade para remover do estoque:");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + p);
        }
    }
}