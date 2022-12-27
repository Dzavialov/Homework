using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    internal class InvalidBookAuthorFormat : Exception
    {
        public InvalidBookAuthorFormat() : base("Entered book author with wrong format")
        {

        }
    }
}
