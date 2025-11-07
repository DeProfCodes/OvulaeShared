using System;

namespace OvulaeShared.ViewModel.Transactions
{
    public class EarningsTransanctionViewModel
    {
        public int TransactionId { get; set; }

        public double Amount { get; set; }

        public string TransactionDate { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }

        public string Comment { get; set; }
    }
}
