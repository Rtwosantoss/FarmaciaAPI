using FarmaApi2.DTOs;
using FarmaApi2.Entity;
using FarmaApi2.Interfaces;

namespace FarmaApi2.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public Client CreateClient(CreateClientDTO dto)
        {
            Client client = _clientRepository.CreateClient(dto);

            return client;
        }

        public List<Client> GetClients()
        {
            List<Client> clients = _clientRepository.GetClients();
            return clients;
        }
    }
}
