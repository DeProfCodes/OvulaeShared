using OvulaeShared.Enums.Transactions;

namespace OvulaeShared.ViewModel.Transactions
{
    public class EarningsViewModel
    {
        public DateTime EarningsDate { get; set; }

        public double Earnings { get; set; }

        public double ExtraEarnings { get; set; }

        public double TotalEarnings { get; set; }

        public double TotalEarningsRate { get; set; }

        public double TotalNetEarnings { get; set; }

        public EarningsType EarningsType { get; set; }

    }
}
