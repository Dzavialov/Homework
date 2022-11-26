using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNLibrary
{
    public class DbFileNotFoundException : Exception
    {
        public DbFileNotFoundException() : base("Db file doesn't exist")
        {

        }
    }
}
