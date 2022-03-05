using static ambient_common.Child.ChildEnums;
using ambient_common.Data.Export;
using System.Text.Json;
using System;

namespace ambient_common.Models
{
    public class AmbientAction : BaseModel, IExportable<AmbientAction>
    {
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public string InteractionTriggered { get; set; }
        public Actions ActionType { get; set; }
        public int AmbientOutcomeId { get; set; }

        public string GetCSVHeaders()
        {
            return "id,objectName,interactionTriggered,actionType,ambientOutcomeId,created";
        }

        public string GetAsCSVRow(bool enumAsName)
        {
            var actionType = enumAsName ? Enum.GetName(typeof(Actions), ActionType) : $"{(int)ActionType}";
            return $"{Id},{ObjectName},{InteractionTriggered},{actionType},{AmbientOutcomeId},{Created}";
        }

        public string GetAsJSONItem()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
