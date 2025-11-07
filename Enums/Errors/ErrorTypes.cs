using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Enums.Errors
{
    public enum ErrorTypes
    {
        [Display(Name = "")]
        None = 0,

        //Auth Error
        [Display(Name = "AUTH_PHONE_NUMBER_EXIST")]
        AUTH_PHONE_NUMBER_EXIST,

        [Display(Name = "AUTH_EMAIL_EXIST")]
        AUTH_EMAIL_EXIST,

        [Display(Name = "CREATE_ERROR")]
        CREATE_ERROR,

        [Display(Name = "UPDATE_ERROR")]
        UPDATE_ERROR,

        [Display(Name = "DELETE_ERROR")]
        DELETE_ERROR,








        [Display(Name = "EXCEPTION_ERROR")]
        EXCEPTION_ERROR = 1000,
    }
}
