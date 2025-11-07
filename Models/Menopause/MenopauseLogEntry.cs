
namespace OvulaeShared.Models.Menopause
{
    public class MenopauseLogEntry
    {
        public int EntryId { get; set; } // Unique within user log
        public int MenopauseTrackerLogId { get; set; }
        public DateTime LogDate { get; set; }
        public string PhaseName { get; set; } // Perimenopause, Menopause, Postmenopause

        public List<string> Symptoms { get; set; } = new();
        public string SleepQuality { get; set; } // Good, Moderate, Poor
        public List<string> Moods { get; set; } // Happy, Sad, Irritable, Anxious

        public string HotFlashesSeverity { get; set; } // None, Mild, Moderate, Severe
        public string NightSweatsSeverity { get; set; }
        public string Libido { get; set; } // High, Normal, Low
        public string EnergyLevel { get; set; }

        public bool IsOnHormoneTherapy { get; set; }
        public string HormoneTherapyNotes { get; set; }

        public bool HadBleeding { get; set; } // Optional daily field
        public string BleedingType { get; set; } // e.g. Spotting, Light Period, Unexpected Flow
        public string BleedingColor { get; set; } // Optional, if needed

        // Health red flags
        public bool HadAbnormalBleeding { get; set; }
        public string BleedingPattern { get; set; }

        public bool HadPelvicPain { get; set; }
        public string PainSeverity { get; set; }

        public List<string> LifestyleFactors { get; set; } = new();

        public string Notes { get; set; } // User-written insights


        public int? UrinationRating { get; set; }

        public bool? CoughWeeYesNo { get; set; }
        public string? CoughWeeNotes { get; set; }
        
        public bool? SneezeWeeYesNo { get; set; }
        public string? SneezeWeeNotes { get; set; }

        public bool? LaughWeeYesNo { get; set; }
        public string? LaughWeeNotes { get; set; }

        public bool? BladderPainYesNo { get; set; }
        public string? BladderPainNotes { get; set; }

        public bool? HairLossYesNo { get; set; }
        public string? HairLossNotes { get; set; }

        public bool? WeightGainYesNo { get; set; }
        public string? WeightGainNotes { get; set; }
        public bool? WeightFluctuate { get; set; }
        public bool? WeightFluctuateNormal { get; set; }

        public bool? UTIOften {get; set; }

        public int? SkinDrynessRating { get; set; }

        public int? BreastTendernessRating { get; set; }

        public bool? BlemishShowing { get; set; }

        // Blood Pressure Monitoring
        public bool? BloodPressureDaily { get; set; }
        public string? BloodPressureReadings { get; set; }

        public string? DoctorsNotes { get; set; }
        public DateTime? DoctorResponseTime { get; set; }
    }
}
