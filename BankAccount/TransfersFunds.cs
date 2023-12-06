using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransferFunds {
    [Table("Transfers")]
    public class Transfer {
        private int Id;
        private string SenderAccount;
        private string BeneficiaryAccount;
        private float Value;
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
            string origin_acc = Console.ReadLine();
            
            Console.WriteLine("Enter the destination account: ");
            string destination_acc = Console.ReadLine();
            
            Console.WriteLine("Transfer value: ");
            float transfer_value = float.Parse(Console.ReadLine());

            Transfer transfer = new Transfer();

            transfer.SenderAccount = origin_acc;
            transfer.BeneficiaryAccount = destination_acc;
            transfer.Value = transfer_value;

            transfer.Status = TransferState.Pending;
        }
            
    }
}