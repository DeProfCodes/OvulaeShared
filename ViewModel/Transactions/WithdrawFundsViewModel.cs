namespace OvulaeShared.ViewModel.Transactions
{
    public class WithdrawFundsViewModel
    {
        public string PlanName { get; set; }

        public int PlanId { get; set; }

        public double TotalAvailableMoneyForWithdrawal { get; set; }

        public double TotalPendingWithdrawalsAmount { get; set; }

        public double WithdrawableAmount { get; set; }

        public bool PlanSetAutoReInvest { get; set; }
    }
}
