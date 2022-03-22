using static AmbientCommon.Child.ChildEnums;
using AmbientCommon.Data.Export;
using System;
using Newtonsoft.Json;

namespace AmbientCommon.Models
{
    public class AmbientAction : BaseModel, IExportable
    {
        public long Id { get; set; }
        public string ObjectName { get; set; }
        public string InteractionTriggered { get; set; }
        public Actions ActionType { get; set; }
        public long AmbientOutcomeId { get; set; }
        public AmbientOutcome AmbientOutcome { get; set; }

        public AmbientAction() {}

        public AmbientAction(string objectName, string interactionTriggered, Actions actionType, int ambientOutcomeId)
        {
            ObjectName = objectName;
            InteractionTriggered = interactionTriggered;
            ActionType = actionType;
            AmbientOutcomeId = ambientOutcomeId;
        }

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
            return JsonConvert.SerializeObject(this);
        }
    }
}
