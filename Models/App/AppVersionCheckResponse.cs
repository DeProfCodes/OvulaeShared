namespace OvulaeShared.Models.App
{
    public class AppVersionCheckResponse
    {
        public bool IsUpdateRequired { get; set; }
        public bool IsUpdateAvailable { get; set; }
        public string MinSupportedVersion { get; set; }
        public string LatestVersion { get; set; }
        public string Message { get; set; }
        public string StoreUrl { get; set; }
    }
}
