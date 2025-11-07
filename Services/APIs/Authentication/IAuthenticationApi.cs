using OvulaeShared.Models;
using OvulaeShared.Models.User;
using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.Account;

namespace OvulaeShared.Services.APIs.Authentication
{
    public interface IAuthenticationApi
    {
        public Task<UserModel> Login(string username, string password);

        public Task<GenericResult> Register(RegisterViewModel registerViewModel);

        public Task<GenericResult> ChangePasswordEmail(string email, string password);

        public Task<GenericResult> ChangePasswordMobile(string countryCode, string phoneNumber, string password);

        public Task<bool> EmailNotRegistered(string email);
    }
}
