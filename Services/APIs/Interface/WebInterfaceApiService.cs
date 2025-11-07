using Newtonsoft.Json;
using OvulaeShared.Helpers.API;
using OvulaeShared.Helpers.CommonFunctions;
using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.Account;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Services.APIs.Interface
{
    public class WebInterfaceApiService : IWebInterfaceApiService
    {
        private HttpClient httpClient;

        public WebInterfaceApiService(string apiBaseAddress)
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(apiBaseAddress);
        }

        public WebInterfaceApiService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(OvulaeApiEndPoints.BASE_ADDRESS);
        }

        public async Task<bool> AuthorizeLoggedInUser()
        {
            try
            {
                string endpoint = "Auth/LoginToAPI";

                var payload = new LoginViewModel
                {
                    Email = "api.mobile@ovulae.com",
                    Password = "Ovulae25!"
                };

                var result = await PostData(endpoint, payload);

                if (result.Success)
                {
                    string token = result.Message;

                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    return true;
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception if needed
            }
            return false;
        }

        private bool RequiresReAuthentication(HttpResponseMessage apiResponse)
        {
            var code = apiResponse.StatusCode;
            return (code == HttpStatusCode.Unauthorized || code == HttpStatusCode.InternalServerError);
        }

        public async Task<GenericResult> PostData(string apiEndPoint, object payloadObject)
        {
            try
            {
                var jsonPayload = JsonConvert.SerializeObject(payloadObject);
                var httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                HttpResponseMessage apiResponse = null;

                apiResponse = await httpClient.PostAsync(apiEndPoint, httpContent);

                if (RequiresReAuthentication(apiResponse))
                {
                    var reAuth = await AuthorizeLoggedInUser();
                    if (reAuth)
                    {
                        apiResponse = await httpClient.PostAsync(apiEndPoint, httpContent);
                    }
                }

                var apiResult = await apiResponse.Content.ReadAsStringAsync();

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return new GenericResult
                    {
                        Success = false,
                        Message = $"API call failed with status code {apiResponse.StatusCode}: {apiResult}"
                    };
                }
                var result = JsonConvert.DeserializeObject<GenericResult>(apiResult);
                return result ?? new GenericResult { Success = false, Message = "Empty response from API." };
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"An error occurred: {ex.Message}"
                };
            }
        }


        public async Task<T> PostDataObject<T>(string apiEndPoint, object payloadObject)
        {
            try
            {
                var jsonPayload = JsonConvert.SerializeObject(payloadObject);
                var httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                var apiResponse = await httpClient.PostAsync(apiEndPoint, httpContent);

                if (RequiresReAuthentication(apiResponse))
                {
                    var reAuth = await AuthorizeLoggedInUser();
                    if (reAuth)
                    {
                        apiResponse = await httpClient.PostAsync(apiEndPoint, httpContent);
                    }
                }

                if (apiResponse.IsSuccessStatusCode)
                {
                    var apiResult = await apiResponse.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(apiResult);
                }
                return default(T);
            }
            catch (Exception)
            {
                return default(T);
            }
        }


        public async Task<GenericResult> PutData(string apiEndPoint, object payloadObject)
        {
            try
            {
                var jsonPayload = JsonConvert.SerializeObject(payloadObject);
                var httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                var apiResponse = await httpClient.PutAsync(apiEndPoint, httpContent);

                if (RequiresReAuthentication(apiResponse))
                {
                    var reAuth = await AuthorizeLoggedInUser();
                    if (reAuth)
                    {
                        apiResponse = await httpClient.PutAsync(apiEndPoint, httpContent);
                    }
                }

                var apiResult = await apiResponse.Content.ReadAsStringAsync();

                return new GenericResult
                {
                    Message = apiResult,
                    Success = apiResponse.IsSuccessStatusCode
                };
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"API call error: {ex.Message}"
                };
            }
        }

        public async Task<T> GetData<T>(string apiEndPoint)
        {
            try
            {
                var apiResponse = await httpClient.GetAsync(apiEndPoint);

                if (RequiresReAuthentication(apiResponse))
                {
                    var reAuth = await AuthorizeLoggedInUser();
                    if (reAuth)
                    {
                        apiResponse = await httpClient.GetAsync(apiEndPoint);
                    }
                }

                if (apiResponse.IsSuccessStatusCode)
                {
                    var json = await apiResponse.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(json);
                }

                return default(T);
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        public async Task<string> GetData(string apiEndPoint)
        {
            var apiResponse = await httpClient.GetAsync(apiEndPoint);

            if(RequiresReAuthentication(apiResponse))
            {
                var reAuth = await AuthorizeLoggedInUser();
                if (reAuth)
                {
                    apiResponse = await httpClient.GetAsync(apiEndPoint);
                }
            }

            if (apiResponse.IsSuccessStatusCode)
            {
                return await apiResponse.Content.ReadAsStringAsync();
            }

            return null;
        }
    }
}
