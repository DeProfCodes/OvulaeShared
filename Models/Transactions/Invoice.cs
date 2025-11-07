using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Transactions
{
    public class Invoice
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int TransactionId { get; set; }

        public double Amount { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public StatusType Status { get; set; }
    }
}
