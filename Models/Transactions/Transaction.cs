
using OvulaeShared.Enums.Status;
using OvulaeShared.Enums.Transactions;

namespace OvulaeShared.Models.Transactions
{
    public class Transaction
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public TransactionType Type { get; set; }

        public double Amount { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string Comment { get; set; }

        public StatusType Status { get; set; }

        public string Reference { get; set; }

        public string PaymentGatewayId { get; set; }
    }
}
