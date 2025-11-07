namespace OvulaeShared.Helpers.ModuleHelpers.DayLogging
{
    public class CycleTrackerDayLogItems
    {
        public static List<string> PeriodStartOptions = new()
        {
            "✅ Yes",
            "❌ No period",
            "🤔 Spotting only"
        };

        public static List<string> PeriodTimingOptions = new()
        {
            "🕛 Today",
            "⏪ Yesterday",
            "⏪⏪ 2 Days Ago",
            "🗓️ Different date..."
        };

        public static List<string> BleedingPresenceOptions = new()
        {
            "✅ Full flow 🩸",          // Regular period
            "💧 Light flow",            // Light period
            "⚠️ Spotting only",         // Minimal bleeding
            "🔄 Breakthrough bleeding", // Mid-cycle bleeding
        };

        // Blood Color Options (NEW)
        public static List<string> BloodColorOptions = new()
        {
            "🟥 Bright red",           // Fresh blood
            "🟫 Brown/dark",           // Old blood
            "🟪 Purple/clots",         // Possible endometriosis
            "🟦 Watery/pink",          // Very light flow
            "⚪ Other/unusual"         // Catch-all
        };

        // Flow Intensity (Enhanced)
        public static List<string> FlowIntensityOptions = new()
        {
            "💧 Light (1-2 pads/tampons)",
            "🌊 Medium (3-5 pads/tampons)",
            "🌋 Heavy (6+ pads/tampons)",
            "⚠️ Spotting (no protection needed)"
        };

        public static List<string> PainLevelOptions = new()
        {
            "😊 None",
            "😣 Mild",
            "😖 Moderate",
            "🤯 Severe"
        };

        public static List<string> HadPeriodBowelMovementOptions = new()
        {
            "✅ Yes",
            "❌ No"
        };

        public static List<string> PeriodBowelMovementIrregularityOptions = new()
        {
            "✅ Regular",
            "⚠️ Irregular"
        };

        public static List<string> PeriodBowelMovementFrequencyOptions = new()
        {
            "Once",
            "Twice",
            "More than twice"
        };
    }
}
