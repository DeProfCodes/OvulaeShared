using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Affiliate
{
    public class AffiliateWallet
    {
        public int Id { get; set; }

        public string AffiliateUserId { get; set; }

        public double TotalRevenue { get; set; }

        public double TotalPaidOut { get; set; }

        public StatusType Status { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }
    }
}
