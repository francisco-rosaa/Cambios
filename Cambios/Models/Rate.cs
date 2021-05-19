namespace Cambios.Models
{
    public class Rate
    {
        public int RateId { get; set; }

        public string Code { get; set; }

        public double TaxRate { get; set; }

        public string Name { get; set; }

        public string NameAndCode
        {
            get
            {
                return $"{Name}  ({Code})";
            }
        }
    }
}
