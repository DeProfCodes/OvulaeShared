using System;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.ViewModel.Transactions
{
    public class TransactionViewModel
    {
        public int TransactionId { get; set; }

        public string UserId { get; set; }

        public DateTime Date { get; set; }

        public string TransactionType { get; set; }

        public double Amount { get; set; }

        public string CreateDate { get; set; }

        public string Comment { get; set; }

        public string TransactionStatus { get; set; }

        public StatusType TransactionStatusEnum { get; set; }
    }

}
