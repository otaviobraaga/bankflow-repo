using System;

namespace BankAccount {
    public class ContaBancaria {
        public string AccNumber;
        public string Name { get; private set; }
        private double _balance;

        public ContaBancaria() {
        }

        public double Balance {
            get => _balance;
            set { }
        }

        public string Account {
            get => AccNumber;
            set {
                Console.Write("Haverá depósito inicial? (s/n)");
                char response = Console.ReadLine()[0];
                if (response == 's' || response == 'S') {
                    Console.WriteLine("Digite o valor do depósito inicial: ");
                    double initialDeposit;
                    if (double.TryParse(Console.ReadLine(), out initialDeposit) && initialDeposit >= 0) {
                        _balance = initialDeposit;
                    }
                    else {
                        Console.WriteLine("O valor do depósito inicial deve ser maior ou igual a 0.");
                    }
                }
                else {
                    _balance = 0;
                }
            }
        }


        public string Nome {
            get => Name;
            set {
                if (value != null && value.Length > 1) {
                    Name = value;
                }
            }
        }

        public string add_balance(double value) {
            _balance += value;
            return $"Saldo atual: {_balance:C}";
        }

        public string withdraw_funds(double value) {
            if (value > 0 && value <= _balance) {
                _balance -= value;
                return $"Saldo atual: {_balance:C}";
            }
            else {
                return "Saldo insuficiente ou valor invalido";
            }
        }

        public string get_acc_number() => AccNumber;
        public string get_owner_name() => Name;
    }
}