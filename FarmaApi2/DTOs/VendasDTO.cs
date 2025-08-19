using FarmaApi2.Entity;

namespace FarmaApi2.DTOs
{
    public class VendasDTO
    {
        public Product Product { get; set; }

        public Client Client { get; set; }

        public DateTime DateTime { get; set; }
    }
}
