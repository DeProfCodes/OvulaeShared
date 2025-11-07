using OvulaeShared.Models.User;

namespace OvulaeShared.ViewModel.Account
{
    public class SettingsViewModel
    {
        public string Email { get; set; }

        public UserBank BankDetails { get; set; }
    }
}
