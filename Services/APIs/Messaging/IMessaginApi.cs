using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Models;
using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.Account;

namespace OvulaeShared.Services.APIs.Messaging
{
    public interface IMessagingApi
    {
        public Task<GenericResult> SendPasswordResetSMS(string countryCode, string phoneNumber);

        public Task<GenericResult> SendPasswordResetEmail(string email);
    }
}
