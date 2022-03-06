using ambient_common.Data.Export;
using System;
using System.Text.Json;
using static ambient_common.Child.ChildEnums;

namespace ambient_common.Models
{
    public class AmbientOutcome : BaseModel, IExportable<AmbientOutcome>
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

        public AmbientOutcome() {}

        public AmbientOutcome(
            States childEmotion,
            States childFusiness,
            Outcomes eatingOutcome,
            bool distracted,
            string location,
            bool offeredFoodReward,
            bool offeredNonFoodReward,
            bool pressureApplied,
            bool parentJoined,
            string dinnerPlateFoodItem1,
            string dinnerPlateFoodItem2,
            string dinnerPlateFoodItem3)
        {
            ChildEmotion = childEmotion;
            ChildFusiness = childFusiness;
            EatingOutcome = eatingOutcome;
            Distracted = distracted;
            Location = location;
            OfferedFoodReward = offeredFoodReward;
            OfferedNonFoodReward = offeredNonFoodReward;
            PressureApplied = pressureApplied;
            ParentJoined = parentJoined;
            DinnerPlateFoodItem1 = dinnerPlateFoodItem1;
            DinnerPlateFoodItem2 = dinnerPlateFoodItem2;
            DinnerPlateFoodItem3 = dinnerPlateFoodItem3;
        }

        public string GetAsCSVRow(bool enumAsName)
        {
            var childEmotion = enumAsName ? Enum.GetName(typeof(States), ChildEmotion) : $"{(int)ChildEmotion}";
            var childFusiness = enumAsName ? Enum.GetName(typeof(States), ChildFusiness) : $"{(int)ChildFusiness}";
            var eatingOutcome = enumAsName ? Enum.GetName(typeof(Outcomes), EatingOutcome) : $"{(int)EatingOutcome}";
            return $"{Id},{childEmotion},{childFusiness},{eatingOutcome},{Distracted},{Location},{OfferedFoodReward},{OfferedNonFoodReward},{PressureApplied},{ParentJoined},{Created}";
        }

        public string GetCSVHeaders()
        {
            return "id,child_emotion,child_fusiness,eating_outcome,distracted,location,offeredFoodReward,offeredNonFoodReward,pressureApplied,parentJoined,created";
        }
        public string GetAsJSONItem()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
