namespace AmbientCommon.Models
{
    public class Participant : BaseModel
    {
        public int Id { get; set; }
        public string ParticipantReference { get; set; }
        public string GroupReference { get; set; }
    }
}
