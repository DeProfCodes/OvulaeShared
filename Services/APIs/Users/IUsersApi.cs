using OvulaeShared.Enums.Status;
using OvulaeShared.Enums.User;
using OvulaeShared.Models.User;
using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.Account;
using OvulaeShared.ViewModel.Admin;
using OvulaeShared.ViewModel.User;

namespace OvulaeShared.Services.APIs.Users
{
    public interface IUsersApi
    {
        #region CRUD - CREATE
        public Task<GenericResult> CreateUserDetailsForJoiningOvulae(UserFullProfileViewModel userJoinViewModel);

        public Task<GenericResult> CreateUserPartner(UserPartnerViewModel userPartnerViewModel);

        public Task<GenericResult> CreateUserToken(UserMobileToken userToken);

        #endregion

        #region CRUD - READ

        public Task<List<UserFullProfileViewModel>> GetAllUsersAdmin();

        public Task<List<UserAdminDetailsViewModel>> GetAllRoleUsers(UserRoleType userRole);

        public Task<List<UserAdminAffiliateDetailsViewModel>> GetAllAffiliateUsers(UserRoleType userRole);

        public Task<List<UserAdminDetailsViewModel>> GetAllPendingAffiliates();

        public Task<AdminDashboardViewModel> GetAdminDashboardData();

        public Task<StatusType> GetUserSubscriptionStatus(SecureApiRequest payload);
        
        #endregion

        #region CRUD - UPDATE

        public Task<GenericResult> ApproveRejectUser(ApproveRejectUserViewModel data);

        public Task<GenericResult> UpdateUserCycleProfile(UserCycleProfile data);

        public Task<GenericResult> UpdateUserDetails(UserDetailsUpdateViewModel updateViewModel);

        public Task<GenericResult> UpdateUserPhoneNumber(PasswordResetViewModel updateViewModel);

        public Task<GenericResult> UpdateUserSubscription(UserSubscription userSubscription);

        public Task<GenericResult> UpdateBodyMetrics(UserBodyMetric data, string email);

        public Task<UserFullProfileViewModel> GetUserFullProfile(string userId, UserRoleType userRole);

        public Task<GenericResult> RevokePartnerSharing(SecureApiRequest secure);

        public Task<GenericResult> ReActivatePartnerSharing(SecureApiRequest secure);
        #endregion

        #region CRUD - DELETE
        public Task<GenericResult> DeletePartnerSharing(SecureApiRequest secure);

        public Task<GenericResult> DeleteUserFullAccount(string userId);

        #endregion
    }
}
