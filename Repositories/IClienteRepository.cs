using Lab08_Imanol.Models;

namespace Lab08_Imanol.Repositories;

public interface IClientRepository
{
    List<Client> GetClientsByName(string name);
}