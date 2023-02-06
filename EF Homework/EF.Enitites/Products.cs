using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Enitites
{
    public class Products
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
