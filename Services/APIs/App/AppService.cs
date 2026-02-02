using OvulaeShared.Enums.User;
using OvulaeShared.Helpers.API;
using OvulaeShared.Models.App;

namespace OvulaeShared.Services.APIs.App
{
    public class AppService : BaseApiService, IAppService
    {
        public AppService()
        {
            
        }

        public async Task<AppVersionCheckResponse> VersionCheck(string version, int build, MobileDeviceType deviceType)
        {
            try
            {
                var endpoint = $"{OvulaeApiEndPoints.APP.VERSION_CHECK}?version={version}&build={build}&deviceType={deviceType}";
                var versionCheckRes = await _webAPI.GetData<AppVersionCheckResponse>(endpoint);
                
                return versionCheckRes;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
