using Vote.DataAccess;

namespace Vote.Entities
{
    public class OptionEntity : BaseEntity
    {
        public string OptionDescription { get; set; }
        public int TopicId { get; set; }
    }
}
