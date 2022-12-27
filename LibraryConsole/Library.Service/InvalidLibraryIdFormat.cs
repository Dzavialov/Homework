using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    internal class InvalidLibraryIdFormat : Exception
    {
        public InvalidLibraryIdFormat() : base("Entered library Id with wrong format")
        {

        }
    }
}
