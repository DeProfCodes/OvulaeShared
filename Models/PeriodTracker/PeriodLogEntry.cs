
using Newtonsoft.Json;
using OvulaeShared.Helpers.Converters;
using OvulaeShared.Models.Shared.Logs;

namespace OvulaeShared.Models.PeriodTracker
{
    public class PeriodLogEntry
    {
        public int EntryId { get; set; }
        public int PeriodTrackerLogId { get; set; }

        public DateTime LogDate { get; set; }
        public string PhaseName { get; set; } // e.g., Menstrual, Follicular, Luteal

        // 🩸 Period Start
        public bool DidPeriodStartToday { get; set; }        // ✅ Yes / ❌ No
        public DateTime? PeriodStartDate { get; set; }       // Optional backdate
        public string PeriodStartOption { get; set; }        // "✅ Yes, today 🩸", etc.
        public string PeriodTimingOption { get; set; }       // "🕛 Today", "⏪ Yesterday", etc.

        // 🩸 Bleeding Details
        public bool HadBleeding { get; set; }
        public string BleedingColor { get; set; }            // e.g., Bright Red, Brown, Pink
        public string FlowIntensity { get; set; }            // e.g., Light, Medium, Heavy
        public string FlowIntensityOption { get; set; }      // e.g., "🌋 Heavy"
        public int DurationDays { get; set; }                // Estimated if ongoing
        public string BleedingPresence { get; set; }

        // 😖 Pain
        public string PainLevel { get; set; }                // e.g., "😣 Mild", "🤯 Severe"
        public bool HasPain => !string.IsNullOrEmpty(PainLevel) && !PainLevel.Contains("None", StringComparison.OrdinalIgnoreCase);


        // 🧠 Daily Health & Symptoms
        public List<string> Moods { get; set; } = new();
        public int? MoodsRating { get; set; }
        public string? MoodsNotes { get; set; }
        public List<string> Symptoms { get; set; } = new();   // e.g., cramps, bloating
        public int? SymptomsRating { get; set; }
        public string? SymptomsNotes { get; set; }
        public List<string> Emotions { get; set; } = new();   // mood log
        public int? EmotionsRating { get; set; }
        public string? EmotionsNotes { get; set; }
        public List<string> Cravings { get; set; } = new();   // sweets, caffeine, salty, etc.
        public int? CravingsRating { get; set; }
        public string? CravingsNotes { get; set; }

        // 🔐 Lifestyle / Contextual Factors
        public List<string> LifestyleFactors { get; set; } = new(); // hydration, stress, exercise
        public int? LifestyleRating { get; set; }
        public string? LifestyleNotes { get; set; }
        public List<string> IntercourseInfo { get; set; } = new();  // e.g., "📅 Protected"
        public int? IntercourseRating { get; set; }
        public string? IntercourseNotes { get; set; }
        public string ContraceptionMethodUsedToday { get; set; }    // Optional daily logging
        public string? ContraceptionsMethodNotes { get; set; }

        // 📝 User Notes
        public string Notes { get; set; } = "";

        // New Fields Change 2.0


        // Breast Self-Exam
        public string? BreastTendernessNotes { get; set; }
        public int? BreastTendernessRating { get; set; }

        // Bowel Movement
        public string? BowelMovementsRegularity { get; set; }
        public bool? HadBowelMovements { get; set; }
        public string? BowelMovementsFrequency { get; set; }

        [JsonConverter(typeof(MedicationListConverter))]
        public List<MedicationModel> Medications { get; set; } = new();

        public string MedicationNotes { get; set; }

        public string? DoctorsNotes { get; set; }
        public DateTime? DoctorResponseTime { get; set; }

        // PCOS Tracking Properties
        [JsonConverter(typeof(MedicationListConverter))]
        public List<MedicationModel> PcosMedications { get; set; } = new();
        public double PcosWaistMeasurement { get; set; }
        public double PcosHipMeasurement { get; set; }
        public double PcosWaistCircumference { get; set; }
        public double PcosWeight { get; set; }
        public DateTime PcosWeightDate { get; set; }
        public string PcosWeightNotes { get; set; } = "";
        public List<string> PcosSymptoms { get; set; } = new();
        public string PcosAdditionalSymptomsNotes { get; set; } = "";
        public string PcosSymptomsNotes { get; set; } = "";
        public int PcosSymptomsRating { get; set; }

        // Endometriosis Tracking Properties
        [JsonConverter(typeof(MedicationListConverter))]
        public List<MedicationModel> EndoMedications { get; set; } = new();
        public int EndoPainRating { get; set; }
        public string EndoPainComments { get; set; } = "";
        public string EndoPainLocation { get; set; } = "";
        public string EndoPainDuration { get; set; } = "";
        public double EndoWaistMeasurement { get; set; }
        public double EndoHipMeasurement { get; set; }
        public double EndoWaistCircumference { get; set; }
        public double EndoWeight { get; set; }
        public DateTime EndoWeightDate { get; set; }
        public string EndoWeightNotes { get; set; } = "";

        // Helper properties for UI
        public bool HasPcosTracking => PcosMedications.Any() ||
                                       PcosWaistMeasurement > 0 ||
                                       PcosHipMeasurement > 0 ||
                                       PcosWaistCircumference > 0 ||
                                       PcosWeight > 0 ||
                                       PcosSymptoms.Any() ||
                                       !string.IsNullOrEmpty(PcosWeightNotes) ||
                                       !string.IsNullOrEmpty(PcosAdditionalSymptomsNotes);

        public bool HasEndoTracking => EndoMedications.Any() ||
                                       EndoPainRating > 0 ||
                                       EndoWaistMeasurement > 0 ||
                                       EndoHipMeasurement > 0 ||
                                       EndoWaistCircumference > 0 ||
                                       EndoWeight > 0 ||
                                       !string.IsNullOrEmpty(EndoPainComments) ||
                                       !string.IsNullOrEmpty(EndoPainLocation) ||
                                       !string.IsNullOrEmpty(EndoPainDuration) ||
                                       !string.IsNullOrEmpty(EndoWeightNotes);
    }
}
