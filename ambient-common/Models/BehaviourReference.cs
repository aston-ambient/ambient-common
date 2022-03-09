using static ambient_common.Child.ChildEnums;

namespace ambient_common.Models
{
    public class BehaviourReference
    {
        public int Id { get; set; }
        public int GameConfigurationId { get; set; }
        public States EmotionalState { get; set; }
        public States FussinessState { get; set; }
        public Actions Action { get; set; }
        public double EmotionalRefusal { get; set; }
        public double QuietRefusal { get; set; }
        public double EatsReluctantly { get; set; }
        public double EatsEasily { get; set; }

        public BehaviourReference() {}

        public BehaviourReference(States emotionalState, States fussinessState, Actions action, double emotionalRefusal, double quietRefusal, double eatsReluctantly, double eatsEasily)
        {
            EmotionalState = emotionalState;
            FussinessState = fussinessState;
            Action = action;
            EmotionalRefusal = emotionalRefusal;
            QuietRefusal = quietRefusal;
            EatsReluctantly = eatsReluctantly;
            EatsEasily = eatsEasily;
        }
    }
}
