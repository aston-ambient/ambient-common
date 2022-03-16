using AmbientCommon.Data.Export;
using Newtonsoft.Json;
using System;
using static AmbientCommon.Child.ChildEnums;

namespace AmbientCommon.Models
{
    public class AmbientOutcome : BaseModel, IExportable
    {
        public long Id { get; set; }
        public States ChildEmotion { get; set; }
        public States ChildFusiness { get; set; }
        public Outcomes EatingOutcome { get; set; }
        public bool Distracted { get; set; }
        public string Location { get; set; }
        public bool OfferedFoodReward { get; set; }
        public bool OfferedNonFoodReward { get; set; }
        public bool PressureApplied { get; set; }
        public bool ParentJoined { get; set; }
        public string DinnerPlateFoodItem1 { get; set; }
        public string DinnerPlateFoodItem2 { get; set; }
        public string DinnerPlateFoodItem3 { get; set; }

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
            return JsonConvert.SerializeObject(this);
        }

    }
}
