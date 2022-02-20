using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ambient_common.Data.Export
{
    public static class ExportImport
    {
        public static string GetExportableCollectionAsCSVString<T>(this IEnumerable<T> items, bool enumAsName = false) where T : IExportable<T>
        {
            if (!items.Any())
            {
                return "";
            }

            var sb = new StringBuilder();
            sb.Append($"{items.First().GetCSVHeaders()}\n");

            foreach (var item in items)
            {
                sb.AppendLine(item.GetAsCSVRow(enumAsName));
            }
                
            return sb.ToString();
        }

        public static string GetExportableCollectionAsJSONString<T>(this IEnumerable<T> items, bool enumAsName = false) where T : IExportable<T>
        {
            var converter = enumAsName ? new JsonSerializerOptions() { Converters = { new JsonStringEnumConverter() } } : null;
            return JsonSerializer.Serialize(items, converter);
        }

        public static List<T> GetExportableCollectionFromJSONString<T>(string json, bool enumAsName = false) where T : IExportable<T>
        {
            var converter = enumAsName ? new JsonSerializerOptions() { Converters = { new JsonStringEnumConverter() } } : null;
            return JsonSerializer.Deserialize<List<T>>(json, converter);
        }
    }
}
