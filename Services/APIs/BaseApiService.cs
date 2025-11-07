using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Helpers.API;
using OvulaeShared.Services.APIs.Interface;

namespace OvulaeShared.Services.APIs
{
    public class BaseApiService
    {
        public readonly IWebInterfaceApiService _webAPI;
        
        public BaseApiService()
        {
            _webAPI = new WebInterfaceApiService(OvulaeApiEndPoints.BASE_ADDRESS);
        }
    }
}
