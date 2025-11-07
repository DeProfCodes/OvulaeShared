using OvulaeShared.Models.WebApi;

namespace OvulaeShared.Services.APIs.Interface
{
    public interface IWebInterfaceApiService
    {
        public Task<GenericResult> PostData(string apiEndPoint, object payloadObject);

        public Task<T> PostDataObject<T>(string apiEndPoint, object payloadObject);

        public Task<GenericResult> PutData(string apiEndPoint, object payloadObject);

        public Task<T> GetData<T>(string apiEndPoint);

        public Task<string> GetData(string apiEndPoint);
    }
}
