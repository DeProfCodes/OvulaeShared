using System.ComponentModel.DataAnnotations;

namespace OvulaeShared.Enums.Support
{
    public enum SupportErrorType
    {
        [Display(Name = "", Description = "")]
        None,

        [Display(Name = "InvoiceFail", Description = "Invoicing Failure")]
        InvoiceFail,

        [Display(Name = "SubscriptionFail", Description = "Failed to Create/Modify Subscription")]
        SubscriptionFail,

        [Display(Name = "ExceptionError", Description = "An error occured, an exception not sure exactly where.")]
        ExceptionError,

    }
}
