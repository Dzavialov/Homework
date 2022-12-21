using Vote.DataAccess;

namespace Vote.Entities
{
    public class TopicEntity : BaseEntity
    {
        public string TopicName { get; set; }
        public int UserId { get; set; }
    }
}
