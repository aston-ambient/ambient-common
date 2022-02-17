using static ambient_common.Child.ChildEnums;

namespace ambient_common.Models
{
    public class BehaviourReference
    {
        public int Id { get; set; }
        public int GameCOnfigurationId { get; set; }
        public States EmotionalSate { get; set; }
        public States FussinessState { get; set; }
        public Actions Action { get; set; }
        public double EmotionalRefusal { get; set; }
        public double QuietRefusal { get; set; }
        public double EatsReluctantly { get; set; }
        public double EatsEasily { get; set; }
    }
}
