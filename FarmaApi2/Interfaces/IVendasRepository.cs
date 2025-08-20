using FarmaApi2.DTOs;
using FarmaApi2.Entity;
using FarmaApi2.Services;

namespace FarmaApi2.Interfaces
{
    public interface IVendasRepository
    {
        public List<Venda> GetVendas();
        public Venda CreateVendas(VendasDTO dto);
    }
}
