using OvulaeShared.Enums.Errors;

namespace OvulaeShared.Models.WebApi
{
    /// <summary>
    /// API generic result model for PUT, POST, DELETE api requests
    /// </summary>
    public class GenericResult
    {
        public bool Success { get; set; } = false;

        public string Message { get; set; } = "";

        public List<ErrorTypes> ErrorTypes { get; set; } = new();

        public string Note { get; set; }
    }
}
