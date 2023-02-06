using System.ComponentModel.DataAnnotations;

namespace EF.Enitites
{
    public class Customers
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(15)]
        public int PhoneNumber { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }
        public ICollection<Orders> Orders { get; set; }

    }
}