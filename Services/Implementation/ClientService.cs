using Lab08_Imanol.Models;
using Lab08_Imanol.Repositories;

namespace Lab08_Imanol.Services.Implementation;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public List<Client> GetClientsByName(string name)
    {
        return _clientRepository.GetClientsByName(name);
    }
}