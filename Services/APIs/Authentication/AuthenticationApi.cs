using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Errors;
using OvulaeShared.Helpers.API;
using OvulaeShared.Models;
using OvulaeShared.Models.User;
using OvulaeShared.Models.WebApi;
using OvulaeShared.Services.APIs.Interface;
using OvulaeShared.ViewModel.Account;

namespace OvulaeShared.Services.APIs.Authentication
{
    public class AuthenticationApi : BaseApiService, IAuthenticationApi
    {
        public AuthenticationApi() 
        {
        }

        public async Task<UserModel> Login(string username, string password)
        {
            try
            {
                var endpoint = $"{OvulaeApiEndPoints.AUTH.LOGIN}";
                var payload = new LoginViewModel
                {
                    Email = username,
                    Password = password
                };

                var userModel = await _webAPI.PostDataObject<UserModel>(endpoint, payload);

                return userModel;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<GenericResult> Register(RegisterViewModel registerViewModel)
        {
            try
            {
                var registerRes = await _webAPI.PostData(OvulaeApiEndPoints.AUTH.REGISTER, registerViewModel);
                return registerRes;
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to register user, error: {ex.Message}"
                };
            }
        }

        public async Task<GenericResult> ChangePasswordEmail(string email, string password)
        {
            try
            {
                var payload = new PasswordResetViewModel { Email = email, Password = password, CountryCode = "", PhoneNumber = "", PasswordResetCode = "" };
                var passChangeRes = await _webAPI.PostData(OvulaeApiEndPoints.AUTH.CHANGE_PASSWORD_EMAIL, payload);

                return passChangeRes;
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to change password (email), error: {ex.Message}"
                };
            }
        }

        public async Task<GenericResult> ChangePasswordMobile(string countryCode, string phoneNumber, string password)
        {
            try
            {
                var payload = new PasswordResetViewModel { CountryCode = countryCode, PhoneNumber = phoneNumber, Password = password, Email = "", PasswordResetCode = "" };
                var passChangeRes = await _webAPI.PostDataObject<GenericResult>(OvulaeApiEndPoints.AUTH.CHANGE_PASSWORD_MOBILE, payload);

                return passChangeRes;
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

        public async Task<bool> EmailNotRegistered(string email)
        {
            try
            {
                var payload = new VerifyEmailViewModel { Email = email };
                var verifyEmailRes = await _webAPI.PostData(OvulaeApiEndPoints.AUTH.VERIFY_EMAIL, payload);

                var emailNotInDB = !verifyEmailRes.Success;

                return emailNotInDB;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
