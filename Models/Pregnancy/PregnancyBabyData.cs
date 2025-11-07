using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Pregnancy
{
    public class PregnancyBabyData
    {
        public int Id { get; set; }

        public string Title { get; set; }

        // JSON string columns
        public string BabyIntroInfoJson { get; set; }
        public string FeaturesJson { get; set; }
        public string MotherChangesJson { get; set; }
        public string InsightsJson { get; set; }

        public string BabySizeFruit { get; set; }

        public bool ShowDidYouKnow { get; set; }

        // FK
        public int PregnancyDataId { get; set; }

        public StatusType Status { get; set; }
        public DateTime CreateData { get; set; }
        public DateTime LastUpdateDate { get; set; }

        // Convenience properties (not mapped)
        [NotMapped]
        public List<string> BabyIntroInfo
        {
            get => JsonConvert.DeserializeObject<List<string>>(BabyIntroInfoJson ?? "[]");
            set => BabyIntroInfoJson = JsonConvert.SerializeObject(value ?? new List<string>());
        }

        [NotMapped]
        public List<string> Features
        {
            get => JsonConvert.DeserializeObject<List<string>>(FeaturesJson ?? "[]");
            set => FeaturesJson = JsonConvert.SerializeObject(value ?? new List<string>());
        }

        [NotMapped]
        public List<string> MotherChanges
        {
            get => JsonConvert.DeserializeObject<List<string>>(MotherChangesJson ?? "[]");
            set => MotherChangesJson = JsonConvert.SerializeObject(value ?? new List<string>());
        }

        [NotMapped]
        public List<string> Insights
        {
            get => JsonConvert.DeserializeObject<List<string>>(InsightsJson ?? "[]");
            set => InsightsJson = JsonConvert.SerializeObject(value ?? new List<string>());
        }
    }

}
