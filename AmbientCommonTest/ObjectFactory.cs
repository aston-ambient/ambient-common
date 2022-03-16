using AmbientCommon.Child;
using AmbientCommon.Models;
using System;

namespace AmbientCommonTest
{
    internal class ObjectFactory
    {
        public static AmbientAction GetRandomAmbientAction(int id = 0)
        {
            var actionType = (ChildEnums.Actions)new Random().Next(Enum.GetNames(typeof(ChildEnums.Actions)).Length - 1);
            return new AmbientAction()
            {
                Id = id,
                ActionType = actionType,
                InteractionTriggered = $"Interaction {id}",
                ObjectName = $"Object: {id}",
                AmbientOutcomeId = 1,
                CreatedBy = "User",
                Created = DateTime.Now,
                ModifiedBy = "User1",
                Modified = DateTime.Now
            };
        }
    }
}
