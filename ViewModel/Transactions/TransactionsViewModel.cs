using System;
using System.Collections.Generic;

namespace OvulaeShared.ViewModel.Transactions
{
    public class TransactionsViewModel
    {
        public List<TransactViewModel> AllTransactions { get; set; }

        public List<EarningsTransanctionViewModel> EarningsTransactions { get; set; }

        public List<WithdrawalsTransanctionViewModel> WithdrawalsTransactions { get; set; }

        public List<DepositsTransanctionViewModel> DepositsTransactions { get; set; }

        public string Extra { get; set; }

        public string UserId { get; set; }

        public string FullName { get; set; }
    }
}
