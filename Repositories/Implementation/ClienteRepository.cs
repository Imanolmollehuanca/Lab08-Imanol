using Lab08_Imanol.Models;

namespace Lab08_Imanol.Repositories.Implementation;

public class ClientRepository : IClientRepository
{
    private readonly ApplicationDbContext _context;

    public ClientRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Client> GetClientsByName(string name)
    {
        return _context.Clients
            .Where(c => c.Name.StartsWith(name))
            .Select(c => new Client
            {
                Clientid = c.Clientid,
                Name = c.Name,
                Email = c.Email,
                Orders = new List<Order>()
            })
            .ToList();
    }
}