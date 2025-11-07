using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace OvulaeShared.Enums
{
    public static class EnumHelper
    {
        /// <summary>
        /// Display the name set in annotation DisplayName on top of enum value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDisplayName(this Enum value)
        {
            return value.GetType()?
                            .GetMember(value.ToString())?.First()?
                                .GetCustomAttribute<DisplayAttribute>()?
                                    .Name ?? "NaN";
        }

        /// <summary>
        /// Display the name set in annotation DisplayShortName on top of enum value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDisplayShortName(this Enum value)
        {
            return value.GetType()?
                            .GetMember(value.ToString())?.First()?
                                .GetCustomAttribute<DisplayAttribute>()?
                                    .ShortName ?? "NaN";
        }

        /// <summary>
        /// Display the name set in annotation DisplayGroupName on top of enum value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDisplayGroupName(this Enum value)
        {
            return value.GetType()?
                            .GetMember(value.ToString())?.First()?
                                .GetCustomAttribute<DisplayAttribute>()?
                                    .GroupName ?? "NaN";
        }


        /// <summary>
        /// Display the name set in annotation DisplayDescription on top of enum value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDisplayDescription(this Enum value)
        {
            return value.GetType()?
                            .GetMember(value.ToString())?.First()?
                                .GetCustomAttribute<DisplayAttribute>()?
                                    .Description ?? "NaN";
        }

        /// <summary>
        /// Display the integer value assigned to enum
        /// </summary>
        /// <param name="argEnum"></param>
        /// <returns></returns>
        public static int GetIntValue(this Enum argEnum)
        {
            return Convert.ToInt32(argEnum);
        }

        public static Enum ConvertDisplayNameToEnum(string displayName, Type type)
        {
            var enumOptions = Enum.GetValues(type);

            foreach (var option in enumOptions)
            {
                var enumOption = (Enum)option;
                if (enumOption.GetDisplayName() == displayName)
                {
                    return enumOption;
                }
            }
            return new DefaultEnum();
        }

        public static Enum ConvertIntValueToEnum(int enumInt, Type type)
        {
            var enumOptions = Enum.GetValues(type);

            foreach (var option in enumOptions)
            {
                var enumOption = (Enum)option;
                if (enumOption.GetIntValue() == enumInt)
                {
                    return enumOption;
                }
            }
            return new DefaultEnum();
        }

        public static TEnum GetEnumValueFromName<TEnum>(string displayName) where TEnum : struct, Enum
        {
            // Handle null, empty, or whitespace safely
            if (string.IsNullOrWhiteSpace(displayName))
                displayName = string.Empty;

            var fields = typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                var attr = field.GetCustomAttribute<DisplayAttribute>();
                var name = attr?.Name ?? field.Name;

                if (string.Equals(name.ToLower(), displayName.ToLower(), StringComparison.OrdinalIgnoreCase))
                {
                    return (TEnum)field.GetValue(null);
                }
            }

            // Try to find a fallback [Display(Name = "")]
            foreach (var field in fields)
            {
                var attr = field.GetCustomAttribute<DisplayAttribute>();
                if (attr?.Name == string.Empty)
                {
                    return (TEnum)field.GetValue(null);
                }
            }

            // Final fallback: return default enum value (e.g. 0th enum member)
            return default;
        }

        public static TEnum GetEnumValueFromShortName<TEnum>(string displayShortName) where TEnum : struct, Enum
        {
            // Handle null, empty, or whitespace safely
            if (string.IsNullOrWhiteSpace(displayShortName))
                displayShortName = string.Empty;

            var fields = typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                var attr = field.GetCustomAttribute<DisplayAttribute>();
                var name = attr?.ShortName ?? field.Name;

                if (string.Equals(name.ToLower(), displayShortName.ToLower(), StringComparison.OrdinalIgnoreCase))
                {
                    return (TEnum)field.GetValue(null);
                }
            }

            // Try to find a fallback [Display(Name = "")]
            foreach (var field in fields)
            {
                var attr = field.GetCustomAttribute<DisplayAttribute>();
                if (attr?.ShortName == string.Empty)
                {
                    return (TEnum)field.GetValue(null);
                }
            }

            // Final fallback: return default enum value (e.g. 0th enum member)
            return default;
        }
    }
}
