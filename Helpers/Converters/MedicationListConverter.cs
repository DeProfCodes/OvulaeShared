using Newtonsoft.Json;
using OvulaeShared.Models.Shared.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Helpers.Converters
{
    public class MedicationListConverter : JsonConverter<List<MedicationModel>>
    {
        public override List<MedicationModel> ReadJson(
            JsonReader reader,
            Type objectType,
            List<MedicationModel> existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            var medications = new List<MedicationModel>();

            if (reader.TokenType == JsonToken.StartArray)
            {
                reader.Read(); // Move to first element

                while (reader.TokenType != JsonToken.EndArray)
                {
                    if (reader.TokenType == JsonToken.String)
                    {
                        // Handle old string format: "🌿 Herbal Remedies"
                        var medicationName = (string)reader.Value;
                        medications.Add(new MedicationModel
                        {
                            Name = medicationName,
                            Dosage = string.Empty
                        });
                    }
                    else if (reader.TokenType == JsonToken.StartObject)
                    {
                        // Handle new object format: {"Name":"...","Dosage":"..."}
                        var medication = serializer.Deserialize<MedicationModel>(reader);
                        medications.Add(medication);
                    }
                    else if (reader.TokenType == JsonToken.Null)
                    {
                        // Handle null
                        medications.Add(null);
                    }

                    reader.Read(); // Move to next element
                }
            }
            else if (reader.TokenType == JsonToken.Null)
            {
                return medications;
            }
            else
            {
                throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing medications");
            }

            return medications;
        }

        public override void WriteJson(JsonWriter writer, List<MedicationModel> value, JsonSerializer serializer)
        {
            // Always write as objects
            serializer.Serialize(writer, value);
        }

        public override bool CanWrite => true;
    }
}
