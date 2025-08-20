namespace FarmaApi2.Entity
{
    public class Venda
    {
        public int Id { get; set; }
        public Product Product { get; set; }

        public Client Client { get; set; }

        public DateTime DateTime { get; set; }
    }
}
