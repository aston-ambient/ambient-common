namespace AmbientCommon.Models
{
    public class Attempt : BaseModel
    {
        public int Id { get; set; }
        public int ParticipantId { get; set; }
        public int GameConfigurationId { get; set; }
        public GameConfiguration GameConfiguration { get; set; }
    }
}
