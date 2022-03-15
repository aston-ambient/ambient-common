using static ambient_common.Child.ChildEnums;

namespace ambient_common.Models
{
    public class TalkReference
    {
        public int Id { get; set; }
        public string DisplayText { get; set; }
        public TalkTypes TalkType { get; set; }
        public bool ActiveWhenNearParent { get; set; }

        public TalkReference() {}

        public TalkReference(string displayText, TalkTypes talkType, bool activeWhenNearParent)
        {
            DisplayText = displayText;
            TalkType = talkType;
            ActiveWhenNearParent = activeWhenNearParent;
        }
    }
}
