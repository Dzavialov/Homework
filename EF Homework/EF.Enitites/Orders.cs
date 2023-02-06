using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Enitites
{
    public class Orders
    {
        public int Id { get; set; }
        public int TotalAmount { get; set; }
        public int CustomerId { get; set; }
        public Customers Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employees Employee { get; set; }

    }
}
