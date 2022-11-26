using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNLibrary
{
    public class InvalidPhoneNumberFormat: Exception
    {
        public InvalidPhoneNumberFormat() : base("Entered phone number with wrong format.")
        {

        }
    }
}
