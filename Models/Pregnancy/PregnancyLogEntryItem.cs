
namespace OvulaeShared.Models.Pregnancy
{
    public class PregnancyLogEntryItem
    {
        public int EntryId { get; set; }
        public int PregnancyTrackerLogId { get; set; }

        public int Week { get; set; }              // 1 to 42
        public int DayOfWeekNo { get; set; }       // 1 (Mon) - 7 (Sun)
        public DateTime LogDate { get; set; }

        // Emotional/Mental State
        public List<string> Moods { get; set; } = new();
        public int? MoodsRating { get; set; }
        public string? MoodsNotes { get; set; }

        public string StressLevel { get; set; }    // e.g., Low, Moderate, High
        public int? StressRating { get; set; }
        public string? StressNotes { get; set; }

        // Physical Health
        public List<string> Symptoms { get; set; } = new();
        public int? SymptomsRating { get; set; }
        public string? SymptomsNotes { get; set; }

        public List<string> Cravings { get; set; } = new();
        public int? CravingsRating { get; set; }
        public string? CravingsNotes { get; set; }

        public string AppetiteLevel { get; set; }  // Normal, Increased, Decreased
        public int? AppetiteRating { get; set; }
        public string? AppetiteNotes { get; set; }

        public string EnergyLevel { get; set; }    // High, Normal, Low
        public int? EnergyRating { get; set; }
        public string? EnergyNotes { get; set; }

        // Baby-related
        public List<string> BabyMovements { get; set; } = new(); // e.g., Kicks, Hiccups, Rolls
        public int? BabyMovementsRating { get; set; }
        public string? BabyMovementsNotes { get; set; }

        public bool FeltBabyMove { get; set; }
        public string MovementFrequency { get; set; } // e.g., None, Rare, Frequent

        // Lifestyle
        public List<string> Activities { get; set; } = new();    // Walking, Yoga, Resting, etc.
        public int? ActivitiesRating { get; set; }
        public string? ActivitiesNotes { get; set; }

        public List<string> Vitamins { get; set; }
        public int? VitaminsRating { get; set; }
        public string? VitaminsNotes { get; set; }

        public List<string> Checkups { get; set; }                // Antenatal visit log
        
        public string SleepQuality { get; set; }                 // Good, Fair, Poor
        public int? SleepRating { get; set; }
        public string? SleepNotes { get; set; }

        // Health Alerts
        public bool HadUnusualDiscomfort { get; set; }
        public List<string> DiscomfortDescription { get; set; }        // Free-text (if above is true)
        public int? DiscomfortRating { get; set; }
        public string? DiscomfortNotes { get; set; }


        // Bleeding or Leakage
        public bool ExperiencedBleedingOrLeakage { get; set; }
        public string BleedingDetails { get; set; }
        public int? BleedingRating { get; set; }
        public string? BleedingNotes { get; set; }

        // Journaling
        public string Reflection { get; set; }                   // Free-text: user thoughts, milestones, etc.

        
        // Bowel Movement
        public string? BowelMovementsRegularity { get; set; }
        public bool? HadBowelMovements { get; set; }
        public string? BowelMovementsFrequency { get; set; }

        public string? DoctorsNotes { get; set; }
        public DateTime? DoctorResponseTime { get; set; }

        public string? WaterIntake { get; set; }
        public string? NighlyUrination { get; set; }

        // Blood Pressure Monitoring
        public bool? BloodPressureDaily { get; set; }
        public string? BloodPressureReadings { get; set; }
        public bool? OnBloodPressureMedication { get; set; }
        
        public string? BrestFeeling { get; set; }
        public int? BrestFeelingRating { get; set; }
        public string? BrestFeelingNotes { get; set; }

        public bool? UTIOften { get; set; }
    }
}
