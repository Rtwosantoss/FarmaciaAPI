using FarmaApi2.DTOs;
using FarmaApi2.Entity;
using FarmaApi2.Interfaces;

namespace FarmaApi2.Repositories
{
    public class ClientRepositories : IClientRepository
    {

        private readonly IClientRepository _clientRepository;
        public Client CreateClient(CreateClientDTO dto)
        {
           Client client = _clientRepository.CreateClient(dto);
            return client;
        }

        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            return clients;
        }
    }
}

