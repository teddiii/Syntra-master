using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Models
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }

        public string ISO { get; set; }

        public bool IsActive { get; set; }

        public bool IsDefault { get; set; }

        public Country() : base()
        {
            IsActive = true;
            IsDefault = false;
        }

        public Country(string name, string ISO, bool isActive = true, bool isDefault = false)
        {
            this.Name = name;
            this.ISO = ISO;
            this.IsActive = isActive;
            this.IsDefault = isDefault;

        }
    }
}
