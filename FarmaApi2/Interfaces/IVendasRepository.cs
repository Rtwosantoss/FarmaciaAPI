using FarmaApi2.DTOs;
using FarmaApi2.Entity;

namespace FarmaApi2.Interfaces
{
    public interface IVendasRepository
    {
        public List<Vendas> GetVendas();
        public Vendas CreateVendas(VendasDTO dto);
    }
}
