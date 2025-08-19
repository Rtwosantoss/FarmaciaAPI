using FarmaApi2.DTOs;
using FarmaApi2.Entity;
using FarmaApi2.Interfaces;

namespace FarmaApi2.Services
{
    public class VendasService : IVendasServices
    {       
        private readonly IVendasRepository _vendasrepositoy; 

        public VendasService(IVendasRepository vendasRepository)
        {
            _vendasrepositoy = vendasRepository;
        }

        public Vendas CreateVenda(VendasDTO dto)
        {
            Vendas vendas = _vendasrepositoy.CreateVendas(dto);
            return vendas;
        }

        public List<Vendas> GetVendas()
        {
            List<Vendas> listVendas = _vendasrepositoy.GetVendas();

            return listVendas;
        }

    }
}
