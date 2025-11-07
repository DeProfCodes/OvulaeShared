using System;

namespace OvulaeShared.ViewModel.Transactions
{
    public class DepositsTransanctionViewModel
    {
        public string TransactionId { get; set; }

        public double Amount { get; set; }

        public string DepositDate { get; set; }

        public string ApprovalDate { get; set; }

        public string Method { get; set; }

        public string Status { get; set; }

        public string Comment { get; set; }
    }
}
