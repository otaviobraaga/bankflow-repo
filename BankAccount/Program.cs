using System;
using Dapper;

namespace BankAccount {
    internal class Program {
        
        public static void Main(string[] args) {
            Console.WriteLine("Bem-vindo ao banco Penes Preto!");
            ContaBancaria conta = new ContaBancaria();
            
            int option;

            do {
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("1 - Sacar Dinheiros");
                Console.WriteLine("2 - Depositar Dinheiros");
                Console.WriteLine("0 - Sair do programa");

                option = int.Parse(Console.ReadLine());

                switch (option) {
                    case 1:
                        Console.WriteLine("Digite o valor a ser sacado: ");
                        double valorSaque = double.Parse(Console.ReadLine());
                        string resultadoSaque = conta.withdraw_funds(valorSaque);
                        Console.WriteLine(resultadoSaque);
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor a ser depositado: ");
                        double valorDeposito = double.Parse(Console.ReadLine());
                        string resultadoDeposito = conta.deposit_funds(valorDeposito);
                        Console.WriteLine(resultadoDeposito);
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa");
                        break;
                    default:
                        Console.WriteLine("Opçao inválida. Tente novamente");
                        break;
                }
            } while (option != 0);
        }
    }
}