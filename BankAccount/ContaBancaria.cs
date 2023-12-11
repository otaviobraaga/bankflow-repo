using System;
using System.Collections.Concurrent;
using System.Management.Instrumentation;

namespace BankAccount {
    public class ContaBancaria {
        public int AccNumber { get; private set; } //Numero da conta
        public string Titular { get; private set; } //Titular da conta
        private double Balance { get; set; } //Saldo da conta

        public ContaBancaria(int numero, string titular) {
            AccNumber = numero;
            Titular = titular;

            if (!GetConfirmation("Haverá depósito inicial ? (s/n)")) {
                Balance = 0;
                return;
            }

            Console.WriteLine("Digite o valor do depósito inicial: ");
            if (!double.TryParse(Console.ReadLine(), out double initialDeposit) || initialDeposit < 0) {
                Console.WriteLine("O valor do depósito deve ser maior ou igual a 0.");
                return;
            }

            Balance = initialDeposit;
        }

        public double Saldo {
            get => Balance;
            set {
                if (value >= 0) {
                    Balance = value;
                }
                else {
                    throw new InvalidOperationException("O valor do saldo deve ser maior ou igual a 0.");
                }
            }
        }

        public string Nome {
            get => Titular;
            set {
                if (value != null && value.Length > 1) {
                    Titular = value;
                }
                else {
                    throw new InvalidOperationException("O nome do titular deve ter pelo menos dois caracteres.");
                }
            }
        }

        private static bool GetConfirmation(string message) {
            Console.Write(message);
            char response = Console.ReadLine()[0];
            return response == 's' || response == 'S';
        }
        public override string ToString() {
            return $"Conta: {AccNumber}, Titular: {Titular}, Saldo: {Balance:C}";
        }
        public string withdraw_funds(double amount) {
            if (amount > 0 && amount <= Balance) {
                Balance -= amount;
                return $"Saque realizado com sucesso. Saldo atual {Balance:C}";
            }
            else {
                return "Deposito não realizado. Valor inválido";
            }
        }
        public string deposit_funds(double amount) {
            if (amount > 0) {
                Balance += amount;
                return $"Deposito realizado com sucesso. Saldo atualizado: {Balance:C}";
            }
            else {
                return "Valor invalido";
            }
        }

    }

}