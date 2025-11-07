using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Helpers.ModuleHelpers.DayLogging
{
    public class PregnancyDayLogItems
    {
        public static List<string> Moods = new()
        {
            "😐 Neutral", "😊 Happy", "😭 Emotional", "😠 Irritable", "😴 Tired", "😰 Anxious", "😢 Sad", "🥰 Calm"
        };

        public static List<string> Symptoms = new()
        {
            "🔥 Heartburn", "😴 Fatigue", "💨 Bloating", "🤢 Nausea", "🚽 Frequent urination", "💆 Headache", "💧 Vaginal Discharge",
            "🦴 Back Pain", "🍽️ Food Aversions", "🍫 Cravings", "💤 Insomnia", "🌡️ Hot Flashes", "🤒 Mild Fever"
        };

        public static List<string> BabyMovements = new()
        {
            "🐟 Flutters", "🌊 Rolling", "💥 Kicks", "🫧 Bubbles", "✨ Twists / Turns", "🚀 Strong Pushes", "⏸️ Less Active Today"
        };

        public static List<string> PregnancyActivities = new()
        {
            "🥗 Ate healthy meals", "🛏️ Got good sleep", "💧 Drank enough water", "🚶 Took a walk",
            "🧘 Practiced mindfulness", "📓 Reflected in journal", "🎵 Listened to relaxing music"
        };

        public static List<string> VitaminSupplements = new()
        {
            "✅ Took Prenatal Vitamin", "💊 Took Iron Supplement", "💊 Took Folic Acid", "🚫 Missed Today"
        };

        public static List<string> Checkups = new()
        {
            "📅 Doctor Visit", "🩺 Midwife Check-in", "📈 Ultrasound", "🧪 Lab Test", "📞 Virtual Consultation"
        };

        public static List<string> SleepQuality = new()
        {
            "😴 Slept Well", "🛌 Interrupted Sleep", "😕 Hard to Fall Asleep", "😣 Restless Night"
        };

        public static List<string> Discomforts = new()
        {
            "🤕 Pelvic Pain", "🦴 Joint Pain", "🦵 Leg Cramps", "🦶 Swollen Feet", "🫁 Shortness of Breath", "🧠 Brain Fog", "💧 Bladder pain"
        };

        public static List<string> BleedingOrLeakage = new()
        {
            "🩸 Light Spotting", "🩸 Moderate Bleeding", "💧 Amniotic Fluid Leak", "❗ Concern - Seek Help"
        };

        public static List<string> StressLevels = new List<string>
        {
            "🟢 Low", "🟡 Moderate", "🔴 High"
        };

        public static List<string> Cravings = new List<string>
        {
            "🍫 Sweets", "🍔 Junk food", "🍋 Sour foods", "🧀 Cheese", "🍉 Fruits",
            "🥩 Meat", "🧂 Salty snacks", "🥒 Pickles", "🥛 Dairy", "🍞 Carbs"
        };

        public static List<string> AppetiteLevels = new List<string>
        {
            "😐 Normal", "🍽️ Increased", "🙅‍♀️ Decreased"
        };

        public static List<string> EnergyLevels = new List<string>
        {
            "🔋 High", "🔋 Normal", "🔋 Low"
        };

        public static List<string> WaterIntakeCups = new List<string>
        {
            "0", "1", "2", "3", "4", "5", "6-10", "10+"
        };

        public static List<string> BrestFeeeling = new List<string>
        {
            "Swollen", "Tender", "Painful", "Normal", "Breast milk is leaking"
        };

        public static List<string> NightUrination = new List<string>
        {
            "1", "2", "3", "4", "5", "6", "7+"
        };
    }
}
