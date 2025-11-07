using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OvulaeShared.Enums.HealthProfile;
using OvulaeShared.Models.Extra;

namespace OvulaeShared.Models.User
{
    public class UserCycleProfile
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        // Common cycle data
        public DateTime? LastPeriodDate { get; set; }
        public int? CycleLengthDays { get; set; }
        public int? PeriodLengthDays { get; set; }
        public string OvulaePrimaryGoal { get; set; }
        public string AllOvulaeGoalsJson { get; set; }
        public PeriodIrregularityType PeriodIrregularityType { get; set; }
        public string TreatmentsJson { get; set; }
        public string HealthConditionsJson { get; set; }
        public string BirthControlMethodsJson { get; set; }
        public string SymptomsJson { get; set; }
        public DateTime? TrackingStartDate { get; set; }
        public string CycleTrackingHistoryJson { get; set; }

        // Convenience properties (not mapped)
        [NotMapped]
        public List<string> AllOvulaeGoals
        {
            get => JsonConvert.DeserializeObject<List<string>>(AllOvulaeGoalsJson ?? "[]");
            set => AllOvulaeGoalsJson = JsonConvert.SerializeObject(value ?? new List<string>());
        }

        [NotMapped]
        public List<string> Treatments
        {
            get => JsonConvert.DeserializeObject<List<string>>(TreatmentsJson ?? "[]");
            set => TreatmentsJson = JsonConvert.SerializeObject(value ?? new List<string>());
        }

        [NotMapped]
        public List<string> HealthConditions
        {
            get => JsonConvert.DeserializeObject<List<string>>(HealthConditionsJson ?? "[]");
            set => HealthConditionsJson = JsonConvert.SerializeObject(value ?? new List<string>());
        }

        [NotMapped]
        public List<string> BirthControlMethods
        {
            get => JsonConvert.DeserializeObject<List<string>>(BirthControlMethodsJson ?? "[]");
            set => BirthControlMethodsJson = JsonConvert.SerializeObject(value ?? new List<string>());
        }

        [NotMapped]
        public List<string> Symptoms
        {
            get => JsonConvert.DeserializeObject<List<string>>(SymptomsJson ?? "[]");
            set => SymptomsJson = JsonConvert.SerializeObject(value ?? new List<string>());
        }

        [NotMapped]
        public List<MenstrualProfile> CycleTrackingHistory
        {
            get => JsonConvert.DeserializeObject<List<MenstrualProfile>>(CycleTrackingHistoryJson ?? "[]");
            set => CycleTrackingHistoryJson = JsonConvert.SerializeObject(value ?? new List<MenstrualProfile>());
        }

        // Pregnancy setup
        public DateTime? EstimatedDueDate { get; set; }
        public bool FirstPregnancy { get; set; }
        public string PregnancyGoal { get; set; } 

        // Ovulation-specific
        public DateTime? OvulationStartDate { get; set; }
        public bool IsTryingToConceive { get; set; }

        // Menstrual cycle tracking
        public bool? UsedHPVvaccine { get; set; }
        public string? UsingTampon { get; set; }
        public int? PCOSYears { get; set; }
        public int? PCOSMonths { get; set; }
        public bool? PCOSDiet { get; set; }
        public int? EndometriosisYears { get; set; }
        public int? EndometriosisMonths { get; set; }
        public bool? EndometriosisDiet { get; set; }

        public DateTime? LastBreastExamDate { get; set; }

        // Meta
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
}
