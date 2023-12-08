using System;

namespace BankAccount {
    public class ContaBancaria {
        private string _accNumber;
        private string _name;
        private double _balance;

        public ContaBancaria(string accNumber, string name, double balance) {
            this._accNumber = accNumber;
            this._name = name;
            this._balance = balance;
        }

        public string Account {
            get => _accNumber;
            set {
                Console.Write("Haverá deposito inicial ? (s/n)");
                char response = Console.ReadLine()[0];
                if (response == 's' || response == 'S') {
                    Console.WriteLine("Digite o valor do depósito inicial: ");
                    double balance = double.Parse(Console.ReadLine());
                    if (balance >= 0) {
                        _balance = balance;
                    }
                    else {
                        Console.WriteLine("O valor do depósito inicial deve ser maior ou igual a 0: ");
                    }
                }
                else {
                    _balance = 0;
                }
            }
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
            _balance += value;
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

        public string get_acc_number() => _accNumber;
        public string get_owner_name() => _name;
    }
}