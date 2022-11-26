using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNLibrary
{
    internal class InvalidNameFormat : Exception
    {
        public InvalidNameFormat() : base("Entered name with wrong format.")
        {

        }
    }
}
