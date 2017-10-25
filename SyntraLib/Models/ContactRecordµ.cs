using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Models
{
    public class ContactRecord : BaseEntity
    {
        public string PhoneNumber { get; set; }

        public string MobileNumber { get; set; }

        public string EmailAddress { get; set; }

        public string Website { get; set; }
    }
}
