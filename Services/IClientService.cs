using Lab08_Imanol.Models;

namespace Lab08_Imanol.Services;

public interface IClientService
{
    List<Client> GetClientsByName(string name);
}