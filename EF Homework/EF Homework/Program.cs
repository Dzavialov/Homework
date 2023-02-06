using EF.Enitites;

namespace EF_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using(var context = new ShopDbContext())
            //{
            //    var customer1 = new Customers()
            //    {
            //        FirstName = "Fname1",
            //        LastName = "Lname1",
            //        PhoneNumber = 1234561233,
            //        Email = "email1@em.com"
            //    };

            //    context.Customers.Add(customer1);

            //    var customer2 = new Customers()
            //    {
            //        FirstName = "Fname2",
            //        LastName = "Lname2",
            //        PhoneNumber = 987654321,
            //        Email = "email2@em.com"
            //    };

            //    context.Customers.Add(customer2);

            //    var customer3 = new Customers()
            //    {
            //        FirstName = "Fname3",
            //        LastName = "Lname3",
            //        PhoneNumber = 564738291,
            //        Email = "email3@em.com"
            //    };

            //    context.Customers.Add(customer3);

            //    context.SaveChanges();
            //}

            using (var context = new ShopDbContext())
            {
                var customer = context.Customers
                    .Where(c => c.FirstName.Contains("1"))
                    .ToList();

                foreach(var x in customer)
                {
                    Console.WriteLine(x.FirstName);
                }
            }
        }
    }
}