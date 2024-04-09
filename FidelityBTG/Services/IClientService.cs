using FidelityBTG.MVVM.Models;

namespace FidelityBTG.Services;

public interface IClientService
{
    Task InitializeAsync();
    Task<IEnumerable<Client>> GetClientsAsync();
    Task<IEnumerable<Client>> GetClientNameAsync(string name);
    Task<int> CreateClientAsync(Client client);
    Task<int> DeleteClientAsync(Client client);
    Task<int> UpdateClientAsync(Client client);
}
