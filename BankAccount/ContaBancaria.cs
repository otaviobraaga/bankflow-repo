using System;

namespace BankAccount {
    public class ContaBancaria {
        private string accNumber;
        private string name;
        private double balance;

        public ContaBancaria(string accNumber, string name, double balance) {
            this.accNumber = accNumber;
            this.name = name;
            this.balance = balance;
        }

        public double current_balance => balance;

        public string deposit_funds(double value) {
            balance += value;
            return $"Saldo atual: {balance:C}";
        }

        public string withdraw_funds(double value) {
            if (value <= balance) {
                balance -= value;
                return $"Saldo atual: {balance:C}";
            }
            else {
                return "Saldo insuficiente";
            }
        }

        public string get_acc_number() => accNumber;
        public string get_owner_name() => name;
    }
}