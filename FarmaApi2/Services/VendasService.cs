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

        public Venda CreateVenda(VendasDTO dto)
        {
            try {
                if (dto.Quantidade == null)
                {
                    throw new Exception("Me manda quantida ai vacilao");
                }

                dto.Product.Id
                Venda venda = new Venda();
                _vendaRepositoru.CriarVenda();


            }
            catch { }


            Venda vendas = _vendasrepositoy.CreateVendas(dto);
            return vendas;
        }

        public List<Venda> GetVendas()
        {
            List<Venda> listVendas = _vendasrepositoy.GetVendas();

            return listVendas;
        }

    }
}

