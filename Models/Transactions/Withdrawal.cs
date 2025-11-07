using System;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Transactions
{
    public class Withdrawal
    {
        public int Id { get; set; }

        public int TransactionId { get; set; }

        public string UserId { get; set; }

        public double Amount { get; set; }

        public double Fee { get; set; }

        public DateTime RequestDate { get; set; }

        public DateTime ResponseDate { get; set; }

        public StatusType Status { get; set; }

        public string BankDetailsJson { get; set; }

        public string Comment { get; set; }
    }
}
