using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Helpers.ModuleHelpers.DayLogging
{
    public class PeriodTrackerDayLogItems
    {
        public static List<string> Moods = new()
        {
            "😊 Happy",
            "😐 Neutral",
            "😭 Sensitive",
            "😡 Irritable",
            "😢 Emotional",
            "😴 Tired",
            "😣 Stressed",
            "🤯 Overwhelmed",
            "😶 Flat"
        };

        public static List<string> Symptoms = new()
        {
            "⚡ Cramps",
            "💆 Headache",
            "💧 Bloating",
            "😴 Fatigue",
            "🤢 Nausea",
            "🚽 Frequent Urination",
            "🔥 Hot Flashes",
            "🩸 Heavy Flow",
            "🩸 Light Flow",
            "❄️ Chills"
        };

        public static List<string> Emotions = new()
        {
            "😊 Happy",
            "😐 Neutral",
            "😭 Sensitive",
            "😡 Irritable",
            "😢 Emotional",
            "😣 Stressed",
            "😴 Tired"
        };

        public static List<string> Cravings = new()
        {
            "🍫 Chocolate",
            "🍕 Salty Food",
            "🍦 Sweet Treats",
            "☕ Caffeine",
            "🍞 Carbs",
            "🥤 Sugary Drinks"
        };

        public static List<string> LifestyleFactors = new()
        {
            "🥗 Healthy Eating",
            "💧 Hydrated",
            "🚶 Light Exercise",
            "🛌 Good Sleep",
            "🧘 Relaxation",
            "😵 Stressful Day",
            "🍫 Ate Sweets",
            "☕ Had Caffeine"
        };

        public static List<string> IntercourseOptions = new()
        {
            "📅 Unprotected",
            "📅 Protected",
            "💊 Emergency Contraception",
            "❌ No Intercourse"
        };

        public static List<string> ContraceptionMethods = new()
        {
            "❌ None",
            "💊 Birth Control Pills",
            "🌀 IUD",
            "🩲 Condoms",
            "✨ Other"
        };

        public static List<string> CommonMedications = new()
        {
            "💊 Painkillers (Ibuprofen, etc.)",
            "🌿 Herbal Remedies",
            "🧴 Heating Pad",
            "🩺 Hormonal Pills"
        };

    }
}
