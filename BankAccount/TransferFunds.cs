using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccount {
    public enum TransferStateEnum {
        Pending,
        Approved,
        Denied,
        Failed,
    }

    [Table("Transfers")]
    internal class Transfer {
        public int Id { get; set; }
        public string SenderAccount { get; set; }
        public string BeneficiaryAccount { get; set; }
        public float Value { get; set; }
        public TransferStateEnum Status { get; set; }

        public Transfer() {
            Status = TransferStateEnum.Pending;
        }

        public void ProcessTransfer(ContaBancaria senderAccount, ContaBancaria beneficiaryAccount) {
            if (senderAccount.Saldo < Value) {
                Console.WriteLine("Saldo insuficiente.");
                Status = TransferStateEnum.Failed;
            }
            else if (senderAccount == beneficiaryAccount) {
                Console.WriteLine("Não é possível transferir para você mesmo.");
                Status = TransferStateEnum.Denied;
            }
            else {
                senderAccount.Saldo -= Value;
                beneficiaryAccount.Saldo += Value;
                Status = TransferStateEnum.Approved;
            }
        }

        public string StatusDescription() {
            switch (Status) {
                case TransferStateEnum.Pending:
                    return "Pending";
                case TransferStateEnum.Approved:
                    return "Approved";
                case TransferStateEnum.Failed:
                    return "Failed";
                case TransferStateEnum.Denied:
                    return "Denied";
                default:
                    return "Unknown";
            }
        }
    }
}