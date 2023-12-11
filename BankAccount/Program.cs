using System;
using BankAccount;

internal abstract class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Bem-vindo ao Banco Pão!");

        Console.WriteLine("Digite o número da conta: ");
        string accNumber = Console.ReadLine();

        Console.WriteLine("Digite o nome do proprietário: ");
        string ownerName = Console.ReadLine();

        Console.WriteLine("Haverá depósito inicial? (s/n)");
        char response = Console.ReadLine()[0];

        double initialBalance = 0;
        if (response == 's' || response == 'S') {
            Console.WriteLine("Digite o valor do depósito inicial: ");
            double.TryParse(Console.ReadLine(), out initialBalance);
        }
        
        ContaBancaria conta = new ContaBancaria {
            AccNumber = accNumber,
            Nome = ownerName,
            Account = initialBalance.ToString() // Set the initial balance
        };

        int option;

        do {
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Sacar Dinheiro");
            Console.WriteLine("2 - Depositar Dinheiro");
            Console.WriteLine("0 - Sair do programa");

            if (!int.TryParse(Console.ReadLine(), out option)) {
                Console.WriteLine("Entrada inválida. Tente novamente.");
                continue;
            }

            switch (option) {
                case 1:
                    Console.WriteLine("Digite o valor a ser sacado: ");
                    if (!double.TryParse(Console.ReadLine(), out double valorSaque)) {
                        Console.WriteLine("Valor inválido. Tente novamente.");
                        continue;
                    }

                    string resultadoSaque = conta.withdraw_funds(valorSaque);
                    Console.WriteLine(resultadoSaque);
                    break;
                case 2:
                    Console.WriteLine("Digite o valor a ser depositado: ");
                    if (!double.TryParse(Console.ReadLine(), out double valorDeposito)) {
                        Console.WriteLine("Valor inválido. Tente novamente.");
                        continue;
                    }

                    string resultadoDeposito = conta.add_balance(valorDeposito);
                    Console.WriteLine(resultadoDeposito);
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente");
                    break;
            }
        } while (option != 0);
    }
}