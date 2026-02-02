using OvulaeShared.Enums.User;
using OvulaeShared.Models.App;

namespace OvulaeShared.Services.APIs.App
{
    public interface IAppService
    {
        public Task<AppVersionCheckResponse> VersionCheck(string version, int build, MobileDeviceType deviceType);
    }
}
