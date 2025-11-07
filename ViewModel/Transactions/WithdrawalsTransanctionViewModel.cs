using System;

namespace OvulaeShared.ViewModel.Transactions
{
    public class WithdrawalsTransanctionViewModel
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int TransactionId { get; set; }

        public double Amount { get; set; }

        public double WithdrawalFees { get; set; }

        public double WithdrawalOriginal { get; set; }

        public string RequestDate { get; set; }

        public string ApproveDate { get; set; }

        public string CurrencyType { get; set; }

        public string CoinNetwork { get; set; }

        public string CryptoAddress { get; set; }

        public string Status { get; set; }
    }
}
