using static ambient_common.Child.ChildEnums;

namespace ambient_common.Models
{
    public class ChildColourCustomisation
    {
        public int Id { get; set; }
        public int GameConfigurationId { get; set; }
        public string DisplayText { get; set; }
        public CustomisationCategory Category { get; set; }
        public string Value { get; set; }
    }
}
