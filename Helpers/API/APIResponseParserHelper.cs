using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OvulaeShared.Models.WebApi;

namespace OvulaeShared.Helpers.API
{
    public class APIResponseParserHelper
    {
        public static T ParseJsonToObject<T>(string json, bool isOneItem = false)
        {
            try
            {
                T result;

                if (isOneItem)
                {
                    var parsedObject = JsonConvert.DeserializeObject<List<T>>(json);

                    result = parsedObject.FirstOrDefault();
                }
                else
                {
                    result = JsonConvert.DeserializeObject<T>(json);
                }
                return result;
            }
            catch (Exception ex)
            {
                return default;
            }
        }
    }
}
