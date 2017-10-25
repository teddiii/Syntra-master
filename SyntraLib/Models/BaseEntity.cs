using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public DateTime DeletedAt { get; set; }

        public BaseEntity()
        {
            CreatedAt = ModifiedAt = DateTime.Now;

        }
    }
}
