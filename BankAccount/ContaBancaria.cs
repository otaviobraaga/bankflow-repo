using System;

namespace BankAccount {
    public class ContaBancaria {
        private string accNumber;
        private string name;
        private double saldo;

        // Props para acessos controlados.

        public string AccNumber {
            get => accNumber;
            set => accNumber = accNumber = value;
        }

        public string Name {
            get => name;
            set => name = value;
        }

        public double Saldo {
            get => saldo;
            set => saldo = value;
        }

        public string getSaldo() {
            return $"Saldo: {Saldo}";
        }
        public string Deposit(double value) {
            if (value > 0) {
                saldo += value;
                return $"Depósito de {value} realizado com sucesso!";
            }
            else {
                return $"Valor do depósito invalido";
            }
        }
        public string Withdraw(double value) {
            if (value > 0 && value <= saldo) {
                saldo -= value;
                return $"Saque realizado com sucesso. Saldo total: {Saldo:C}";
            }
            else {
                return $"Valor de saque invalido ou saldo insuficiente.";
            }
        }
    }
}