using OvulaeShared.Models.Affiliate;
using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.Affiliates;

namespace OvulaeShared.Services.APIs.Affiliates
{
    public interface IAffiliatesApi
    {
        public Task<GenericResult> ApplyForAffiliateProgramme(AffiliateProfile affiliateProfile);

        public Task<AffiliateClicks> GetAffiliateClicksByAndroidCode(string androidCode);

        public Task<AffiliateDashboardViewModel> GetAffiliateDashboardDetails(SecureApiRequest secureDto);

        public Task<GenericResult> UpdateAffiliateModel(AffiliateUpdateViewModel affiliateUpdate);
    }
}
