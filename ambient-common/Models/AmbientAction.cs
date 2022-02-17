using static ambient_common.Child.ChildEnums;

namespace ambient_common.Models
{
    public class AmbientAction : BaseModel
    {
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public string InteractionTriggered { get; set; }
        public Actions ActionType { get; set; }
        public int AmbientOutcomeId { get; set; }
    }
}
