using System.Reflection;

namespace OvulaeShared.Helpers.CommonFunctions
{
    public static class DefaultValueHelper
    {
        public static void SetDefaults<T>(T obj)
        {
            if (obj == null)
                return;

            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in properties)
            {
                if (!prop.CanWrite || !prop.CanRead)
                    continue;

                var currentValue = prop.GetValue(obj);

                // Only set default if value is null
                if (currentValue == null)
                {
                    Type propType = prop.PropertyType;

                    // For nullable value types (e.g., DateTime?)
                    if (Nullable.GetUnderlyingType(propType) != null)
                    {
                        var defaultVal = Activator.CreateInstance(Nullable.GetUnderlyingType(propType));
                        prop.SetValue(obj, defaultVal);
                    }
                    // For reference types like string
                    else if (propType == typeof(string))
                    {
                        prop.SetValue(obj, string.Empty);
                    }
                    // For other reference types (optional – can be customized)
                    else if (!propType.IsValueType)
                    {
                        var defaultVal = Activator.CreateInstance(propType);
                        prop.SetValue(obj, defaultVal);
                    }
                }
            }
        }

        public static T CreateWithDefaults<T>() where T : new()
        {
            T obj = new T();

            var properties = typeof(T)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanWrite && p.CanRead);

            foreach (var prop in properties)
            {
                var currentValue = prop.GetValue(obj);
                var type = prop.PropertyType;

                if (currentValue != null)
                    continue;

                if (Nullable.GetUnderlyingType(type) != null)
                {
                    var defaultVal = Activator.CreateInstance(Nullable.GetUnderlyingType(type)!);
                    prop.SetValue(obj, defaultVal);
                }
                else if (type == typeof(string))
                {
                    prop.SetValue(obj, string.Empty);
                }
                else if (!type.IsValueType) // reference types
                {
                    try
                    {
                        var defaultVal = Activator.CreateInstance(type);
                        prop.SetValue(obj, defaultVal);
                    }
                    catch
                    {
                        // Skip if no parameterless constructor
                    }
                }
                else if (type.IsValueType)
                {
                    var defaultVal = Activator.CreateInstance(type);
                    prop.SetValue(obj, defaultVal);
                }
            }

            return obj;
        }

        public static int GetIntValueOrDefault(int? value)
        {
            return value.HasValue ? value.Value : 0;
        }

        public static string GetStringValueOrDefault(string? value)
        {
            return value != null ? value : "";
        }
    }
}
