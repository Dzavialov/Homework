using Vote.DataAccess;

namespace Vote.Entities
{
    internal class TopicEntity : BaseEntity
    {
        public string TopicName { get; set; }
        public int OptionId { get; set; }
    }
}
