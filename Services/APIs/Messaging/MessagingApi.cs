using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Helpers.API;
using OvulaeShared.Models;
using OvulaeShared.Models.WebApi;
using OvulaeShared.Services.APIs.Interface;
using OvulaeShared.ViewModel.Account;

namespace OvulaeShared.Services.APIs.Messaging
{
    public class MessagingApi : BaseApiService, IMessagingApi
    {
        public MessagingApi()
        {
        }

        public async Task<GenericResult> SendPasswordResetSMS(string countryCode, string phoneNumber)
        {
            try
            {
                var verifyPhoneVM = new VerifyPhoneNumberViewModel
                {
                    CountryCode = countryCode,
                    PhoneNumber = phoneNumber
                };

                var sendSMSResult = await _webAPI.PostDataObject<GenericResult>(OvulaeApiEndPoints.MESSAGING.SEND_SMS, verifyPhoneVM);

                return sendSMSResult;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public async Task<GenericResult> SendPasswordResetEmail(string email)
        {
            try
            {
                var verifyEmailVM = new VerifyEmailViewModel
                {
                    Email = email
                };

                var sendEmailResult = await _webAPI.PostData(OvulaeApiEndPoints.MESSAGING.SEND_EMAIL, verifyEmailVM);

                return sendEmailResult;
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
