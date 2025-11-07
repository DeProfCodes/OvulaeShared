using OvulaeShared.Helpers.Constants;

namespace OvulaeShared.Helpers.CommonFunctions
{
    public class OvulaeLevelsHelper
    {
        public static int GetAffiliateNextLevel(int currentAffiliatesJoined)
        {
            if (currentAffiliatesJoined < OvulaeConstants.AFFILIATE_LEVEL_1) return OvulaeConstants.AFFILIATE_LEVEL_1;
            if (currentAffiliatesJoined < OvulaeConstants.AFFILIATE_LEVEL_2) return OvulaeConstants.AFFILIATE_LEVEL_2;
            if (currentAffiliatesJoined < OvulaeConstants.AFFILIATE_LEVEL_3) return OvulaeConstants.AFFILIATE_LEVEL_3;
            if (currentAffiliatesJoined < OvulaeConstants.AFFILIATE_LEVEL_4) return OvulaeConstants.AFFILIATE_LEVEL_4;
            if (currentAffiliatesJoined < OvulaeConstants.AFFILIATE_LEVEL_5) return OvulaeConstants.AFFILIATE_LEVEL_5;
            if (currentAffiliatesJoined < OvulaeConstants.AFFILIATE_LEVEL_6) return OvulaeConstants.AFFILIATE_LEVEL_6;
            if (currentAffiliatesJoined < OvulaeConstants.AFFILIATE_LEVEL_7) return OvulaeConstants.AFFILIATE_LEVEL_7;
            if (currentAffiliatesJoined < OvulaeConstants.AFFILIATE_LEVEL_8) return OvulaeConstants.AFFILIATE_LEVEL_8;

            return 0;
        }

        public static int GetAffiliateCurrentLevel(int referals)
        {
            if (referals < OvulaeConstants.AFFILIATE_LEVEL_1) return 0;
            if (referals < OvulaeConstants.AFFILIATE_LEVEL_2) return 1;
            if (referals < OvulaeConstants.AFFILIATE_LEVEL_3) return 2;
            if (referals < OvulaeConstants.AFFILIATE_LEVEL_4) return 3;
            if (referals < OvulaeConstants.AFFILIATE_LEVEL_5) return 4;
            if (referals < OvulaeConstants.AFFILIATE_LEVEL_6) return 5;
            if (referals < OvulaeConstants.AFFILIATE_LEVEL_7) return 6;
            if (referals < OvulaeConstants.AFFILIATE_LEVEL_8) return 7;

            return 0;
        }

        public static int GetSubscriptionNextLevel(int currentSubscriptions)
        {
            if (currentSubscriptions < OvulaeConstants.SUBSCRIPTION_LEVEL_1) return OvulaeConstants.SUBSCRIPTION_LEVEL_1;
            if (currentSubscriptions < OvulaeConstants.SUBSCRIPTION_LEVEL_2) return OvulaeConstants.SUBSCRIPTION_LEVEL_2;
            if (currentSubscriptions < OvulaeConstants.SUBSCRIPTION_LEVEL_3) return OvulaeConstants.SUBSCRIPTION_LEVEL_3;
            if (currentSubscriptions < OvulaeConstants.SUBSCRIPTION_LEVEL_4) return OvulaeConstants.SUBSCRIPTION_LEVEL_4;
            if (currentSubscriptions < OvulaeConstants.SUBSCRIPTION_LEVEL_5) return OvulaeConstants.SUBSCRIPTION_LEVEL_5;

            return 1;
        }

        public static int GetSubscriptionLevel(int currentSubscriptions)
        {
            if (currentSubscriptions < OvulaeConstants.SUBSCRIPTION_LEVEL_1) return 1;
            if (currentSubscriptions < OvulaeConstants.SUBSCRIPTION_LEVEL_2) return 2;
            if (currentSubscriptions < OvulaeConstants.SUBSCRIPTION_LEVEL_3) return 3;
            if (currentSubscriptions < OvulaeConstants.SUBSCRIPTION_LEVEL_4) return 4;
            if (currentSubscriptions < OvulaeConstants.SUBSCRIPTION_LEVEL_5) return 5;

            return 1;
        }
    }
}
