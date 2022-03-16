using static AmbientCommon.Child.ChildEnums;

namespace AmbientCommon.Models
{
    public class ChildColourCustomisation : BaseModel
    {
        public int Id { get; set; }
        public int GameConfigurationId { get; set; }
        public string DisplayText { get; set; }
        public CustomisationCategory Category { get; set; }
        public string Value { get; set; }

        public ChildColourCustomisation() {}

        public ChildColourCustomisation(string displayText, CustomisationCategory category, string value)
        {
            DisplayText = displayText;
            Category = category;
            Value = value;
        }
    }
}
