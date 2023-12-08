using System;

namespace BankAccount {
    internal abstract class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Bem-vindo ao banco Penes Preto!");
            ContaBancaria conta = new ContaBancaria();

            int option;
            conta.Account = 

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
}
