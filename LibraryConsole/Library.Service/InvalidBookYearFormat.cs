using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    internal class InvalidBookYearFormat : Exception
    {
        public InvalidBookYearFormat() : base("Entered book year with wrong format")
        {

        }
    }
}
