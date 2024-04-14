using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DeliverySystem.Infrastructure
{
    internal static class ParametersHelper
    {
        public static Dictionary<string, object> ToDictionary(object obj)
        {
            var json = JsonSerializer.Serialize(obj);
            var dictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
            return dictionary;
        }
    }
}
