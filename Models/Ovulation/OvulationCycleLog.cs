using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Models.Ovulation
{
    public class OvulationCycleLog
    {
        public int EntryId { get; set; }
        public int OvulationTrackerLogId { get; set; }

        public DateTime LogDate { get; set; }
        public string PhaseName { get; set; } // Follicular, Ovulation, Luteal, etc.
        public DateTime? ExpectedOvulationDate { get; set; }

        // Fertility & Intercourse
        public bool HadIntercourse { get; set; }
        public string IntercourseTiming { get; set; } // Before Ovulation, Peak Day, After Ovulation
        public bool UsedProtection { get; set; }
        public string ContraceptiveMethod { get; set; }

        // Mucus & Temp
        public string CervicalMucusType { get; set; } // Sticky, Creamy, Egg-white, Watery
        public double? BasalBodyTempCelsius { get; set; }

        // 🔴 Optional Bleeding Info
        public bool HadBleeding { get; set; }
        public string BleedingColor { get; set; }
        public string FlowIntensity { get; set; } // e.g. Light, Spotting
        public string FlowIntensityOption { get; set; } // UI emoji version
        public int? BleedingDurationDays { get; set; } // Optional; nullable to avoid false 0s
        public string BleedingPresence { get; set; }
        public string PainLevel { get; set; }

        // Mood & Symptoms - with ratings and notes
        public List<string> Moods { get; set; } = new();
        public int? MoodsRating { get; set; }
        public string? MoodsNotes { get; set; }

        public List<string> Symptoms { get; set; } = new();
        public int? SymptomsRating { get; set; }
        public string? SymptomsNotes { get; set; }

        public List<string> Emotions { get; set; } = new();
        public int? EmotionsRating { get; set; }
        public string? EmotionsNotes { get; set; }

        public List<string> Cravings { get; set; } = new();
        public int? CravingsRating { get; set; }
        public string? CravingsNotes { get; set; }

        public string EnergyLevel { get; set; }
        public int? EnergyRating { get; set; }
        public string? EnergyNotes { get; set; }

        // Lifestyle Factors
        public List<string> LifestyleFactors { get; set; } = new();
        public int? LifestyleRating { get; set; }
        public string? LifestyleNotes { get; set; }

        public string Notes { get; set; } = "";

        // Diagnostic Observations
        public string LHTestResult { get; set; } // Positive, Negative, NotTaken
        public bool HadMidCycleSpotting { get; set; }
        public string SpottingDetails { get; set; }
        public string CervixPosition { get; set; } // Low, High
        public string CervixFeel { get; set; } // Soft, Firm, Open, Closed

        // Breast Tenderness
        public string? BreastTendernessNotes { get; set; }
        public int? BreastTendernessRating { get; set; }

        // Bowel Movements
        public string? BowelMovementsRegularity { get; set; }
        public bool? HadBowelMovements { get; set; }
        public string? BowelMovementsFrequency { get; set; }

        // Flags
        public bool IsFertileWindow { get; set; }
        public bool MarkedAsPeakDay { get; set; }

        // Doctor's Notes
        public string? DoctorsNotes { get; set; }
        public DateTime? DoctorResponseTime { get; set; }

        // Helper Properties
        public bool HasPain => !string.IsNullOrEmpty(PainLevel) && !PainLevel.Contains("None", StringComparison.OrdinalIgnoreCase);
    }
}
