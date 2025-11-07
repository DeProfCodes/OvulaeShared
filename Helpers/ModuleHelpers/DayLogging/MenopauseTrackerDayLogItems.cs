namespace OvulaeShared.Helpers.ModuleHelpers.DayLogging
{
    public static class MenopauseTrackerDayLogItems
    {
        public static List<string> Symptoms = new List<string>
        {
            "🔥 Hot Flashes", "💦 Night Sweats", "😴 Fatigue", "💤 Insomnia", "😡 Irritability", "😭 Mood Swings",
            "🥶 Chills", "🧠 Brain Fog", "💧 Vaginal Dryness", "🎯 Weight Gain", "💔 Palpitations", "🦴 Joint Pain"
        };

        public static List<string> SleepQuality = new List<string>
        {
            "😴 Good", "😐 Moderate", "💤 Poor"
        };

        public static List<string> Mood = new List<string>
        {
            "😊 Happy", "😢 Sad", "😠 Irritable", "😰 Anxious", "😐 Flat", "😭 Overwhelmed"
        };

        public static List<string> HotFlashesSeverity = new List<string>
        {
            "✅ None", "🌡️ Mild", "🔥 Moderate", "🔥🔥 Severe"
        };

        public static List<string> NightSweatsSeverity = new List<string>
        {
            "✅ None", "💧 Mild", "💦 Moderate", "💦💦 Severe"
        };

        public static List<string> Libido = new List<string>
        {
            "🔥 High", "🙂 Normal", "😶 Low"
        };


        public static List<string> HormoneTherapyNotesSuggestions = new List<string>
        {
            "💊 Started HRT", "📆 Adjusted Dosage", "🛑 Stopped HRT", "🤔 Considering HRT", "✅ Doing Well", "⚠️ Side Effects"
        };

        // 🩸 Bleeding-related
        public static List<string> PeriodHad = new List<string>
        {
            "🩸 I had my period", "❌ I did not have my period"
        };

        public static List<string> BleedingTypes = new List<string>
        {
            "🔸 Spotting", "🩸 Light Flow", "🌊 Unexpected Period", "❗ Heavy Bleeding"
        };

        public static List<string> BleedingColors = new List<string>
        {
            "🟥 Bright Red", "🟠 Orange-Tinged", "🟤 Brown", "🩶 Pinkish", "🧊 Watery"
        };

        public static List<string> BleedingPatterns = new List<string>
        {
            "📈 Increasing", "📉 Decreasing", "🔁 Recurring", "❗ Sudden & Unusual", "📆 One-time"
        };

        // 🤕 Pelvic Pain
        public static List<string> HadPelvicPain = new List<string>
        {
            "✅ Yes", "❌ No", 
        };

        public static List<string> PelvicPainSeverity = new List<string>
        {
            "✅ None", "😣 Mild", "😖 Moderate", "🤯 Severe"
        };

        // 🌱 Lifestyle factors
        public static List<string> LifestyleFactors = new List<string>
        {
            "🥗 Healthy Eating", "💧 Hydrated", "🛌 Slept Well", "🚶 Light Activity", "🧘 Relaxation",
            "😵 Stressful Day", "☕ Caffeine", "🍫 Sugar Cravings", "📴 Disconnected / Rested", "🏥 Doctor Visit"
        };
    }
}