using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransferFunds {
    [Table("Transfers")]
    public class Transfer {
        private int Id;
        public string SenderAccount { get; private set; }
        public string BeneficiaryAccount { get; private set; }
        private float _value;
        private TransferState CurrentStatus;
        
        
        public enum TransferState {
            Pending,
            Approved,
            Denied
        }
        public TransferState Status {
            get { return CurrentStatus;}
            set { CurrentStatus = value; }
        }

        static void create_new_transfer() {
            
            Console.WriteLine("Enter the origin account (numbers): ");
            string originAcc = Console.ReadLine();
            
            Console.WriteLine("Enter the destination account: ");
            string destinationAcc = Console.ReadLine();
            
            Console.WriteLine("Transfer value: ");
            float transferValue = float.Parse(Console.ReadLine());

            Transfer transfer = new Transfer();

            transfer.SenderAccount = originAcc;
            transfer.BeneficiaryAccount = destinationAcc;
            transfer._value = transferValue;

            transfer.Status = TransferState.Pending;
        }
            
    }
}