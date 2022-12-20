using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGeneric
{
    internal class StackIsEmptyException : Exception
    {
        public StackIsEmptyException() : base("This stack is empty.")
        {

        }
    }
}
