using static ambient_common.Child.ChildEnums;

namespace ambient_common.Models
{
    public class AmbientOutcome : BaseModel
    {
        public int Id;
        public States ChildEmotion;
        public States ChildFusiness;
        public Outcomes EatingOutcome;
        public bool Distracted;
        public string Location;
        public bool OfferedFoodReward;
        public bool OfferedNonFoodReward;
        public bool PressureApplied;
        public bool ParentJoined;
        public string DinnerPlateFoodItem1;
        public string DinnerPlateFoodItem2;
        public string DinnerPlateFoodItem3;
    }
}
