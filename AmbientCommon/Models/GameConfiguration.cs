using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AmbientCommon.Models
{
    public class GameConfiguration : BaseModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Label { get; set; }
        public bool Protected { get; set; }
        public bool Active { get; set; }
        public double ChildFusinessLowerBound { get; set; }
        public double ChildFusinessUpperBound { get; set; }
        public double ChildEmotionLowerBound { get; set; }
        public double ChildEmotionUpperBound { get; set;}

        public ICollection<BehaviourReference> BehaviourReferences { get; set; }
        public ICollection<ChildColourCustomisation> ChildCustomisations { get; set; }
        public ICollection<TalkReference> TalkReferences{ get; set; }
        public ICollection<Attempt> Attempts { get; set; }
    }
}
