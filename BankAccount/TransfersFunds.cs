using System;

namespace TransferFunds {
    public class Transfer {
        private int Id { get; set; }
        private string SenderAccount { get; set; }
        private string BeneficiaryAccount { get; set; }
        private float Value { get; set; }
        private string CurrentStatus { get; set; }

        public enum TransferState {
            Pending,
            Approved,
            Denied
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
            transfer.Value = transferValue;

        }
            
    }
}