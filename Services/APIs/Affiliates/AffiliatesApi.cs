using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Errors;
using OvulaeShared.Helpers.API;
using OvulaeShared.Helpers.CommonFunctions;
using OvulaeShared.Models.Affiliate;
using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.Account;
using OvulaeShared.ViewModel.Affiliates;

namespace OvulaeShared.Services.APIs.Affiliates
{
    public class AffiliatesApi : BaseApiService, IAffiliatesApi
    {
        public AffiliatesApi()
        {
            
        }

        #region CRUD - CREATE

        public async Task<GenericResult> ApplyForAffiliateProgramme(AffiliateProfile affiliateProfile)
        {
            try
            {
                var createResult = await _webAPI.PostData(OvulaeApiEndPoints.AFFILIATES.APPLY_FOR_AFFILIATE_PROGRAMME, affiliateProfile);

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

        public async Task<AffiliateClicks> GetAffiliateClicksByAndroidCode(string androidCode)
        {
            try
            {
                var endpoint = $"{OvulaeApiEndPoints.AFFILIATES.GET_AFFILIATE_CLICKS_BY_ANDROID_CODE}?androidCode={androidCode}";
                
                var data = await _webAPI.GetData<AffiliateClicks>(endpoint);

                return data;
            }
            catch
            {
                return null;
            }
        }

        public async Task<AffiliateDashboardViewModel> GetAffiliateDashboardDetails(SecureApiRequest secureDto)
        {
            try
            {
                var data = await _webAPI.PostDataObject<AffiliateDashboardViewModel>(OvulaeApiEndPoints.AFFILIATES.GET_AFFILIATE_DASHBOARD, secureDto);

                return data;
            }
            catch 
            {
                return null;
            }
        }

        #endregion

        #region CRUD - UPDATE

        public async Task<GenericResult> UpdateAffiliateModel(AffiliateUpdateViewModel affiliateUpdate)
        {
            try
            {
                DefaultValueHelper.SetDefaults(affiliateUpdate);
                var updateAffiliate = await _webAPI.PostData(OvulaeApiEndPoints.AFFILIATES.UPDATE_AFFILIATE_MODEL, affiliateUpdate);

                return updateAffiliate;
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to change password (mobile), error: {ex.Message}"
                };
            }
        }

        public async Task<GenericResult> UpdateAffiliateProfile(AffiliateProfile profile)
        {
            try
            {
                var updateAffiliate = await _webAPI.PostData(OvulaeApiEndPoints.AFFILIATES.UPDATE_AFFILIATE_PROFILE, profile);

                return updateAffiliate;
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to udpate affiliate profile. error: {ex.Message}"
                };
            }
        }

        #endregion

    }
}
