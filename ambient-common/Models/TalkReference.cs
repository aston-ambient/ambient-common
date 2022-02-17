using static ambient_common.Child.ChildEnums;

namespace ambient_common.Models
{
    public class TalkReference
    {
        public int Id { get; set; }
        public TalkTypes TalkType { get; set; }
        public bool ActiveWhenNearParent { get; set; }
    }
}
