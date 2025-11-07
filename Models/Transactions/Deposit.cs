using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Transactions
{
    public class Deposit
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int TransactionId { get; set; }

        public string SubscriptionId { get; set; }

        public double Amount { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public StatusType Status { get; set; }

        public string Comment { get; set; }
    }
}
