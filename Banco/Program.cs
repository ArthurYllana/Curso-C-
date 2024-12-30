using System;

namespace Banco{
    class Program{
        static void Main(string[] args){

            System.Console.WriteLine("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Entre o nome do titular da conta: ");
            string titular = Console.ReadLine();
            System.Console.WriteLine("Haverá depósito inicial (s/n)? ");
            if (resp =='s' || resp == 'S'){
                System.Console.WriteLine("Entre o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
            } 
            else {
                conta = new ContaBancaria(numero,titular);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Dados da Conta: ");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();
            System.Console.WriteLine("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());    
            conta.Depositar(valorDeposito);
            System.Console.WriteLine("Dados da conta atualizados: ");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();
            System.Console.WriteLine("Entre um valor para saque: ");
            valorDeposito = double.Parse(Console.ReadLine());    
            conta.Sacar (valorDeposito);
            System.Console.WriteLine("Dados da conta atualizados: ");
            System.Console.WriteLine(conta);
        }
    }
}