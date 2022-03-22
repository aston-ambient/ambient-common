using System.ComponentModel.DataAnnotations;
using static AmbientCommon.Child.ChildEnums;

namespace AmbientCommon.Models
{
    public class TalkReference : BaseModel
    {
        public long Id { get; set; }
        [MaxLength(100)]
        public string DisplayText { get; set; }
        public TalkTypes TalkType { get; set; }
        public bool ActiveWhenNearParent { get; set; }

        public long GameConfigurationId { get; set; }
        public GameConfiguration GameConfiguration { get; set; }

        public TalkReference() {}

        public TalkReference(string displayText, TalkTypes talkType, bool activeWhenNearParent)
        {
            DisplayText = displayText;
            TalkType = talkType;
            ActiveWhenNearParent = activeWhenNearParent;
        }
    }
}
