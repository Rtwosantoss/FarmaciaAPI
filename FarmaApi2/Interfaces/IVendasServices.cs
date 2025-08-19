using FarmaApi2.DTOs;
using FarmaApi2.Entity;

namespace FarmaApi2.Interfaces
{
    public interface IVendasServices
    {
        public List<Vendas> GetVendas();
        public Vendas CreateVenda(VendasDTO dto);
    }
}
