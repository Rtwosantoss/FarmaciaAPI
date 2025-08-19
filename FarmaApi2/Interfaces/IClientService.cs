using FarmaApi2.DTOs;
using FarmaApi2.Entity;

namespace FarmaApi2.Interfaces
{
    public interface IClientService
    {
        public List<Client> GetClients();
        public Client CreateClient(CreateClientDTO dto);
    }
}
