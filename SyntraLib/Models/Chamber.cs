using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Models
{
    /// <summary>
    /// this is the entity of a chamber
    /// </summary>
    public class Chamber : BaseEntity
    {
        /// <summary>
        /// this sets the chamber type
        /// </summary>
        public ChamberType Type { get; set; }

        private decimal? _price;

        /// <summary>
        /// This is the price of the chamber
        /// When the price has no value or is equal or lower to 0
        /// then it takes the default price, defined in the ChamberType
        /// </summary>
        public decimal Price
        {
            get
            {
                if (!_price.HasValue || _price <= 0)
                {
                    _price = Type.DefaultPrice;
                }

                return _price.Value;
            }
            set { _price = value; }
        }

        public uint Capacity { get; set; }

        public Chamber() : base()
        {
            Capacity = 1;
        }
    }
}
