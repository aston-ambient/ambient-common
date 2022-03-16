namespace AmbientCommon.Models
{
    public class GameConfiguration : BaseModel
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public bool Protected { get; set; }
        public double ChildFusinessLowerBound { get; set; }
        public double ChildFusinessUpperBound { get; set; }
        public double ChildEmotionLowerBound { get; set; }
        public double ChildEmotionUpperBound { get; set;}
    }
}
