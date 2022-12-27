using Vote.DataAccess;

namespace Vote.Entities
{
    public class UserEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Dictionary<int, int> VotedFor;
    }
}
