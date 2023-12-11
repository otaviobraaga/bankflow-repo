using System;
using System.Collections.Concurrent;
using System.Management.Instrumentation;

namespace BankAccount {
    public class ContaBancaria {
        public int AccountNumber { get; private set; } //Número da conta
        public string Titular { get; private set; } //Titular da conta
        private double Balance { get; set; } //Saldo da conta

        public ContaBancaria(int numero, string titular) {
            AccountNumber = numero;
            Titular = titular;

            if (!GetConfirmation("Haverá depósito inicial? (s/n)")) {
                Balance = 0;
                return;
            }

            Console.WriteLine("Digite o valor do depósito inicial: ");
            double initialDeposit;
            if (!double.TryParse(Console.ReadLine(), out initialDeposit) || initialDeposit < 0) {
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
                } else {
                    throw new InvalidOperationException("O valor do saldo deve ser maior ou igual a 0.");
                }
            }
        }

        public string Nome {
            get => Titular;
            set {
                if (value != null && value.Length >= 2) {
                    Titular = value;
                } else {
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
            return $"Conta: {AccountNumber}, Titular: {Titular}, Saldo: {Balance:C}";
        }

        public string WithdrawFunds(double amount) {
            if (IsValidAmount(amount) && Balance >= amount) {
                Balance -= amount;
                return $"Saque realizado com sucesso. Saldo atual: {Balance:C}";
            } else {
                return "Saque não realizado. Valor inválido ou saldo insuficiente.";
            }
        }

        public string DepositFunds(double amount) {
            if (IsValidAmount(amount)) {
                Balance += amount;
                return $"Depósito realizado com sucesso. Saldo atualizado: {Balance:C}";
            } else {
                return "Valor inválido.";
            }
        }

        private bool IsValidAmount(double amount) {
            return amount >= 0;
        }
    }
}