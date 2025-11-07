using OvulaeShared.Enums;
using OvulaeShared.Enums.Errors;
using OvulaeShared.Enums.Status;
using OvulaeShared.Enums.User;
using OvulaeShared.Helpers.API;
using OvulaeShared.Models.User;
using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.Account;
using OvulaeShared.ViewModel.Admin;
using OvulaeShared.ViewModel.User;

namespace OvulaeShared.Services.APIs.Users
{
    public class UsersApi : BaseApiService, IUsersApi
    {
        public UsersApi()
        {
        }

        #region CRUD - CREATE
        public async Task<GenericResult> CreateUserDetailsForJoiningOvulae(UserFullProfileViewModel userJoinViewModel)
        {
            try
            {
                var createResult = await _webAPI.PostData(OvulaeApiEndPoints.USER.CREATE_USER_DETAILS, userJoinViewModel);

                return createResult;
            }
            catch (Exception ex)
            {
                var result = new GenericResult
                {
                    Success = false,
                    Message = $"An error occured:, {ex.Message}",
                };
                result.ErrorTypes.Add(ErrorTypes.EXCEPTION_ERROR);
                return result;
            }
        }

        public async Task<GenericResult> CreateUserPartner(UserPartnerViewModel userPartnerViewModel)
        {
            try
            {
                var createResult = await _webAPI.PostData(OvulaeApiEndPoints.USER.CREATE_USER_PARTNER, userPartnerViewModel);

                return createResult;
            }
            catch (Exception ex)
            {
                var result = new GenericResult
                {
                    Success = false,
                    Message = $"An error occured:, {ex.Message}",
                };
                result.ErrorTypes.Add(ErrorTypes.EXCEPTION_ERROR);
                return result;
            }
        }

        public async Task<GenericResult> CreateUserToken(UserMobileToken userToken)
        {
            try
            {
                var createResult = await _webAPI.PostData(OvulaeApiEndPoints.USER.CREATE_USER_TOKEN, userToken);

                return createResult;
            }
            catch (Exception ex)
            {
                var result = new GenericResult
                {
                    Success = false,
                    Message = $"An error occured:, {ex.Message}",
                };
                result.ErrorTypes.Add(ErrorTypes.EXCEPTION_ERROR);
                return result;
            }
        }

        #endregion

        #region CRUD - READ

        public async Task<List<UserFullProfileViewModel>> GetAllUsersAdmin()
        {
            try
            {
                var result = await _webAPI.GetData<List<UserFullProfileViewModel>>(OvulaeApiEndPoints.USER.GET_ALL_USERS_ADMIN);

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<UserAdminDetailsViewModel>> GetAllRoleUsers(UserRoleType userRole)
        {
            try
            {
                var endpoint = $"{OvulaeApiEndPoints.USER.GET_ALL_ROLE_USERS}?userRole={userRole}";

                var result = await _webAPI.GetData<List<UserAdminDetailsViewModel>>(endpoint);

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }   
        }

        public async Task<List<UserAdminAffiliateDetailsViewModel>> GetAllAffiliateUsers(UserRoleType userRole)
        {
            try
            {
                var endpoint = $"{OvulaeApiEndPoints.USER.GET_ALL_ROLE_USERS}?userRole={userRole}";

                var result = await _webAPI.GetData<List<UserAdminAffiliateDetailsViewModel>>(endpoint);

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<UserAdminDetailsViewModel>> GetAllPendingAffiliates()
        {
            try
            {
                var data = await GetAllRoleUsers(UserRoleType.Client);

                var result = data.Where(x => x.AccountStatus == AccountStatusType.PendingAffiliate).ToList();

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<AdminDashboardViewModel> GetAdminDashboardData()
        {
            try
            {
                var data = await _webAPI.GetData<AdminDashboardViewModel>(OvulaeApiEndPoints.USER.GET_ADMIN_DASHBOARD);

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion


        #region CRUD - UPDATE

        public async Task<GenericResult> ApproveRejectUser(ApproveRejectUserViewModel data)
        {
            try
            {
                var approveRejectRes = await _webAPI.PostData(OvulaeApiEndPoints.USER.APPROVE_REJECT_USER, data);

                return approveRejectRes;
            }
            catch(Exception ex) 
            {
                var result = new GenericResult
                {
                    Success = false,
                    Message = $"An error occured:, {ex.Message}",
                };
                result.ErrorTypes.Add(ErrorTypes.EXCEPTION_ERROR);
                return result;
            }
        }

        public async Task<GenericResult> UpdateUserCycleProfile(UserCycleProfile data)
        {
            try
            {
                var updateResult = await _webAPI.PostData(OvulaeApiEndPoints.USER.UPDATE_USER_CYCLE_PROFILE, data);

                return updateResult;
            }
            catch (Exception ex)
            {
                var result = new GenericResult
                {
                    Success = false,
                    Message = $"An error occured:, {ex.Message}",
                };
                result.ErrorTypes.Add(ErrorTypes.EXCEPTION_ERROR);
                return result;
            }
        }

        public async Task<GenericResult> UpdateUserDetails(UserDetailsUpdateViewModel updateViewModel)
        {
            try
            {
                var updateResult = await _webAPI.PostData(OvulaeApiEndPoints.USER.UPDATE_USER_DETAILS, updateViewModel);

                return updateResult;
            }
            catch (Exception ex)
            {
                var result = new GenericResult
                {
                    Success = false,
                    Message = $"An error occured:, {ex.Message}",
                };
                result.ErrorTypes.Add(ErrorTypes.EXCEPTION_ERROR);
                return result;
            }
        }

        public async Task<GenericResult> UpdateUserPhoneNumber(PasswordResetViewModel updateViewModel)
        {
            try
            {
                var updateResult = await _webAPI.PostData(OvulaeApiEndPoints.USER.UPDATE_USER_PHONE_NUMBER, updateViewModel);
                return updateResult;
            }
            catch (Exception ex)
            {
                var result = new GenericResult
                {
                    Success = false,
                    Message = $"An error occured:, {ex.Message}",
                };
                result.ErrorTypes.Add(ErrorTypes.EXCEPTION_ERROR);
                return result;
            }
        }

        public async Task<GenericResult> UpdateUserSubscription(UserSubscription userSubscription)
        {
            try
            {
                var updateResult = await _webAPI.PostData(OvulaeApiEndPoints.USER.UPDATE_USER_SUBSCRIPTION, userSubscription);
                return updateResult;
            }
            catch (Exception ex)
            {
                var result = new GenericResult
                {
                    Success = false,
                    Message = $"An error occured:, {ex.Message}",
                };
                result.ErrorTypes.Add(ErrorTypes.EXCEPTION_ERROR);
                return result;
            }
        }

        public async Task<GenericResult> UpdateBodyMetrics(UserBodyMetric data, string email)
        {
            try
            {
                var payload = new UserBodyMetricModifyViewModel
                {
                    Email = email,
                    UserBodyMetric = data
                };

                var updateResult = await _webAPI.PostData(OvulaeApiEndPoints.USER.UPDATE_USER_BODY_METRICS, payload);

                return updateResult;
            }
            catch (Exception ex)
            {
                var result = new GenericResult
                {
                    Success = false,
                    Message = $"An error occured:, {ex.Message}",
                };
                result.ErrorTypes.Add(ErrorTypes.EXCEPTION_ERROR);
                return result;
            }
        }

        public async Task<UserFullProfileViewModel> GetUserFullProfile(string userId, UserRoleType userRole)
        {
            try
            {
                var endpoint = "";
                if (userRole == UserRoleType.Client) endpoint = OvulaeApiEndPoints.USER.GET_FULL_USER_PROFILE;
                else if (userRole == UserRoleType.PartnerShare) endpoint = OvulaeApiEndPoints.USER.GET_PARTNER_FULL_USER_PROFILE;

                if (!string.IsNullOrEmpty(endpoint))
                {
                    var payload = new SecureApiRequest
                    {
                        UserId = userId
                    };

                    var userFullDetails = await _webAPI.PostDataObject<UserFullProfileViewModel>(endpoint, payload);

                    return userFullDetails;
                }
            }
            catch (Exception ex)
            {
                
            }
            return null;
        }

        public async Task<GenericResult> RevokePartnerSharing(SecureApiRequest secure)
        {
            try
            {
                var revokeRes = await _webAPI.PostData(OvulaeApiEndPoints.USER.REVOKE_PARTNER_ACCESS, secure);

                return revokeRes;
            }
            catch (Exception ex)
            {
                var result = new GenericResult
                {
                    Success = false,
                    Message = $"An error occured:, {ex.Message}",
                };
                result.ErrorTypes.Add(ErrorTypes.EXCEPTION_ERROR);
                return result;
            }
        }

        public async Task<GenericResult> ReActivatePartnerSharing(SecureApiRequest secure)
        {
            try
            {
                var reActivateRes = await _webAPI.PostData(OvulaeApiEndPoints.USER.REACTVATE_PARTNER_ACCESS, secure);

                return reActivateRes;
            }
            catch (Exception ex)
            {
                var result = new GenericResult
                {
                    Success = false,
                    Message = $"An error occured:, {ex.Message}",
                };
                result.ErrorTypes.Add(ErrorTypes.EXCEPTION_ERROR);
                return result;
            }
        }

        public async Task<StatusType> GetUserSubscriptionStatus(SecureApiRequest payload)
        {
            try
            {
                var uSubscriptionStatus = await _webAPI.PostDataObject<StatusType>(OvulaeApiEndPoints.USER.GET_USER_SUBSSCRIPTION_STATUS, payload);

                return uSubscriptionStatus;
            }
            catch
            {
                return StatusType.Error;
            }
        }

        #endregion

        #region DELETE
        public async Task<GenericResult> DeletePartnerSharing(SecureApiRequest secure)
        {
            try
            {
                var deleteRes = await _webAPI.PostData(OvulaeApiEndPoints.USER.DELETE_PARTNER_ACCESS, secure);

                return deleteRes;
            }
            catch (Exception ex)
            {
                var result = new GenericResult
                {
                    Success = false,
                    Message = $"An error occured:, {ex.Message}",
                };
                result.ErrorTypes.Add(ErrorTypes.EXCEPTION_ERROR);
                return result;
            }
        }

        public async Task<GenericResult> DeleteUserFullAccount(string userId)
        {
            try
            {
                SecureApiRequest secure = new SecureApiRequest
                {
                    UserId = userId,
                };
                var deleteRes = await _webAPI.PostData(OvulaeApiEndPoints.USER.DELETE_USER_FULL_ACCOUNT, secure);

                return deleteRes;
            }
            catch (Exception ex)
            {
                var result = new GenericResult
                {
                    Success = false,
                    Message = $"An error occured:, {ex.Message}",
                };
                result.ErrorTypes.Add(ErrorTypes.EXCEPTION_ERROR);
                return result;
            }
        }
        #endregion
    }
}