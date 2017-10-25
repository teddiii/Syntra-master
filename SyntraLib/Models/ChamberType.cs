namespace Syntra.Models
{
    public class ChamberType : BaseEntity
    {
        public string Name { get; set; }

        public decimal DefaultPrice { get; set; }
    }
}