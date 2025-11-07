using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Status;
using OvulaeShared.Enums.User;

namespace OvulaeShared.ViewModel.Affiliates
{
    public class UserAffiliateReferalDetails
    {
        public DateTime JoinDate { get; set; }

        public string ReferalId { get; set; }

        public MobileDeviceType DeviceType { get; set; }

        public SubscriptionType SubscriptionType { get; set; }

        public string CountryCode { get; set; }

        public double Commission { get; set; }

        public StatusType ReferalStatus { get; set; }
    }
}
