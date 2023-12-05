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
            string origin_acc = Console.ReadLine();
            
            Console.WriteLine("Enter the destination account: ");
            string destination_acc = Console.ReadLine();
            
            Console.WriteLine("Transfer value: ");
            float transfer_value = float.Parse(Console.ReadLine());

            Transfer transfer = new Transfer();

            transfer.SenderAccount = origin_acc;
            transfer.BeneficiaryAccount = destination_acc;
            transfer.Value = transfer_value;

        }
            
    }
}