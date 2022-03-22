namespace AmbientCommon.Models
{
    public class Participant : BaseModel
    {
        public long Id { get; set; }
        public string ParticipantReference { get; set; }
        public string GroupReference { get; set; }
    }
}
