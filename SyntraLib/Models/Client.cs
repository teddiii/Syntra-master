using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Models
{
    /// <summary>
    /// This is the entity of a client
    /// </summary>
     public class Client : BaseEntity
    {
        /// <summary>
        /// This is the first name of the client.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// This is the last name of the client
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// This is the birth date of the client
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// This is the gender of the client
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// This is the Address of the client
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// These are the contact records of the client
        /// </summary>
        public ContactRecord ContactRecord { get; set; }
    }
}
