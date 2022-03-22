namespace AmbientCommon.Models
{
    public class Attempt : BaseModel
    {
        public long Id { get; set; }
        public long ParticipantId { get; set; }
        public Participant Participant { get; set; }
        public long GameConfigurationId { get; set; }
        public GameConfiguration GameConfiguration { get; set; }
    }
}
