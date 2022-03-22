using static AmbientCommon.Child.ChildEnums;

namespace AmbientCommon.Models
{
    public class BehaviourReference : BaseModel
    {
        public long Id { get; set; }
        public States EmotionalState { get; set; }
        public States FussinessState { get; set; }
        public Actions Action { get; set; }
        public double EmotionalRefusal { get; set; }
        public double QuietRefusal { get; set; }
        public double EatsReluctantly { get; set; }
        public double EatsEasily { get; set; }

        public long GameConfigurationId { get; set; }
        public GameConfiguration GameConfiguration { get; set; }

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
