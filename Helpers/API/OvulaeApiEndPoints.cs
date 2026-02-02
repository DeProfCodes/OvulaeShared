using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Helpers.API
{
    public class OvulaeApiEndPoints
    {
        //Base
        public const string BASE_ADDRESS = "https://api.ovulae.com/";

        //AUTH
        public static class AUTH
        {
            public const string LOGIN = "Auth/Login";
            public const string REGISTER = "Auth/Register";
            public const string CHANGE_PASSWORD_EMAIL = "Auth/ChangePasswordEmail";
            public const string CHANGE_PASSWORD_MOBILE = "Auth/ChangePasswordMobile";
            public const string VERIFY_EMAIL = "Auth/VerifyEmail";
        }

        //AUTH
        public static class APP
        {
            public const string VERSION_CHECK = "App/VersionCheck";
        }

        //User
        public static class USER
        {
            //Create
            public const string CREATE_USER_DETAILS = "Users/CreateUserDetailsForJoiningOvulae";
            public const string CREATE_USER_PARTNER = "Users/CreateUserPartner";
            public const string CREATE_USER_TOKEN = "Users/RegisterUserToken";
            //Read
            public const string GET_FULL_USER_PROFILE = "Users/GetUserFullProfile";
            public const string GET_PARTNER_FULL_USER_PROFILE = "Users/GetPartnerUserFullProfile";
            public const string GET_ALL_USERS_ADMIN = "Users/GetAllUsersAdmin";
            public const string GET_ALL_ROLE_USERS = "Users/GetAllRoleUsers";
            public const string GET_ADMIN_DASHBOARD = "Users/GetAdminDashboardData";
            public const string GET_USER_SUBSSCRIPTION_STATUS = "Users/GetUserSubscriptionStatus";
            //Update
            public const string APPROVE_REJECT_USER = "Users/ApproveRejectUser";
            public const string UPDATE_USER_CYCLE_PROFILE = "Users/UpdateUserCycleProfile";
            public const string UPDATE_USER_DETAILS = "Users/UpdateUserDetails";
            public const string UPDATE_USER_PHONE_NUMBER = "Users/UpdateUserPhoneNumber";
            public const string UPDATE_USER_BODY_METRICS = "Users/UpdateUserBodyMetric";
            public const string UPDATE_USER_SUBSCRIPTION = "Users/UpdateUserSubscription";
            public const string REVOKE_PARTNER_ACCESS = "Users/RevokePartnerSharing";
            public const string REACTVATE_PARTNER_ACCESS = "Users/ReActivatePartnerSharing";
            public const string DELETE_PARTNER_ACCESS = "Users/DeletePartnerSharing";
            public const string DELETE_USER_FULL_ACCOUNT = "Users/DeleteUserAccount";
        }

        //Messaging
        public static class MESSAGING
        {
            public const string SEND_SMS = "Messaging/SendPasswordResetSMS";
            public const string SEND_EMAIL = "Messaging/SendPasswordResetEmail";
        }

        //Updates
        public static class UPDATES
        {
            public const string GET_MODULE_HISTORY = "Updates/GetModuleUpdateHistory";
            public const string GET_FEATURE_HISTORY = "Updates/GetFeatureUpdateHistory";
            public const string GET_MODULE_FEATURE_HISTORY = "Updates/GetModuleFeatureUpdateHistory";
            public const string GET_ALL_HISTORY = "Updates/GetAllUpdateHistories";
        }

        //Pregnancy
        public static class PREGNANCY
        {
            public const string GET_PREGNANCY_DATA = "PregnancyData/GetAllPregnancyWeekGroups";
            public const string GET_PREGNANCY_ALL_DATA = "PregnancyData/GetPregnancyAllData";
        }

        //Education
        public static class EDUCATION
        {
            public const string GET_EDUCATION_DATA = "Education/GetEducationGroupsWithItems";
        }

        //Education
        public static class TIPS
        {
            public const string GET_TIPS_DATA = "Tips/GetTipsGroupsWithItems";
        }

        //Symptoms
        public static class SYMPTOMS
        {
            public const string GET_SYMPTOMS_DATA = "Symptoms/GetSymptomsGroupsWithItems";
        }

        //Symptoms
        public static class DIET
        {
            public const string GET_DIET_DATA = "Diet/GetDietGroupsWithItems";
        }

        //Pregnancy
        public static class PREGNANCY_LOG
        {
            public const string CREATE_PREG_LOG = "PregnancyLog/CreatePregnancyLog";
            public const string GET_USER_PREG_LOG = "PregnancyLog/GetLogsByUserByEmail";
            public const string UPDATE_PREG_LOG = "PregnancyLog/UpdatePregnancyLog";
            public const string DELETE_PREG_LOG = "PregnancyLog/DeletePregnancyLog";
        }

        public static class AFFILIATES
        {
            public const string GET_AFFILIATE_DASHBOARD = "Affiliate/GetAffiliateDashboardDetails";
            public const string GET_AFFILIATE_CLICKS_BY_ANDROID_CODE = "Affiliate/GetUserAffiliateClicksByAndroidCode";
            public const string UPDATE_AFFILIATE_MODEL = "Affiliate/UpdateAffiliateModel";
            public const string APPLY_FOR_AFFILIATE_PROGRAMME = "Affiliate/ApplyForAffiliateProgramme";
            public const string UPDATE_AFFILIATE_PROFILE = "Affiliate/UpdateAffiliateProfile";
        }

        public static class DOCTORS
        {
            public const string GET_DOCTORS_DASHBOARD = "Doctors/GetDoctorDashboardDetails";
            public const string GET_DOCTORS_ALL_PATIENTS = "Doctors/GetDoctorAllPatientsList";
            public const string GET_DOCTORS_PATIENT_DETAILS = "Doctors/GetDoctorsPatientProfile";
        }

        public static class TRANSACTIONS
        {
            public const string GET_USER_TRANSACTIONS = "Transactions/GetUserAllTransactions";
        }
        
        public static class MODULE_LOGS
        {
            // Pregnancy
            public const string GET_PREGNANCY_LOGS = "ModuleLogs/pregnancy/all";
            public const string UPDATE_PREGNANCY_LOG_ENTRY = "ModuleLogs/UpdatePregnancyLogEntry";
            public const string UPDATE_PREGNANCY_LOG_ENTRY_DR = "ModuleLogs/UpdatePregnancyLogEntryDR";
            public const string UPDATE_BABY_DETAILS = "ModuleLogs/UpdateBabyDetails";

            // Period
            public const string GET_PERIOD_LOGS = "ModuleLogs/period/all";
            public const string UPDATE_PERIOD_LOG_ENTRY = "ModuleLogs/UpdatePeriodLogEntry";
            public const string UPDATE_PERIOD_LOG_ENTRY_DR = "ModuleLogs/UpdatePeriodLogEntryDR";

            // Ovulation
            public const string GET_OVULATION_LOGS = "ModuleLogs/ovulation/all";
            public const string UPDATE_OVULATION_LOG_ENTRY = "ModuleLogs/UpdateOvulationLogEntry";
            public const string UPDATE_OVULATION_LOG_ENTRY_DR = "ModuleLogs/UpdateOvulationLogEntryDR";

            // Menopause
            public const string GET_MENOPAUSE_LOGS = "ModuleLogs/menopause/all";
            public const string UPDATE_MENOPAUSE_LOG_ENTRY = "ModuleLogs/UpdateMenopauseLogEntry";
            public const string UPDATE_MENOPAUSE_LOG_ENTRY_DR = "ModuleLogs/UpdateMenopauseLogEntryDR";
        }

        public static class PAYMENTS
        {
            public const string RETRY_SUBSCRIPTION_ACTIVATION = "Payments/RetrySubscriptionPaySuccess";
            public const string SUBSCRIPTION_ACTIVATION_IOS = "Payments/SubscriptionPaySuccessIOS";
        }

    }
}
