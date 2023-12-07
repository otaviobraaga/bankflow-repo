using System;

namespace BankAccount {
    public class ContaBancaria {
        private string _accNumber;
        private string _name;
        private double _balance;

        public ContaBancaria(string accNumber, string name, double balance) {
            _accNumber = accNumber;
            _name = name;
            _balance = balance;
        }

        public string AccNumber {
            get => _accNumber;
        }

        public string Nome {
            get => _name;
            set {
                if (value != null && value.Length > 1) {
                    _name = value;
                }
            }
        }

        public string add_balance(double value) {
            return $"Saldo atual: {_balance:C}";
        }

        public string withdraw_funds(double value) {
            if (value <= _balance) {
                _balance -= value;
                return $"Saldo atual: {_balance:C}";
            }
            else {
                return "Saldo insuficiente";
            }
        }
    }
}