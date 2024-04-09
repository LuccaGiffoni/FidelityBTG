using FidelityBTG.MVVM.Models;
using SQLite;

namespace FidelityBTG.Services;

public class ClientService : IClientService
{
    private SQLiteAsyncConnection _databaseConnection;

    public async Task InitializeAsync()
    {
        await SetUpDatabaseConnection();
    }

    private async Task SetUpDatabaseConnection()
    {
        if (_databaseConnection == null)
        {
            string dbPath = Path.Combine(Environment.
            GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Clients.db3");

            _databaseConnection = new SQLiteAsyncConnection(dbPath);
            await _databaseConnection.CreateTableAsync<Client>();
        }
    }

    public async Task<int> CreateClientAsync(Client client)
    {
        return await _databaseConnection.InsertAsync(client);
    }

    public async Task<int> DeleteClientAsync(Client client)
    {
        return await _databaseConnection.DeleteAsync(client);
    }
    public async Task<int> UpdateClientAsync(Client client)
    {
        return await _databaseConnection.UpdateAsync(client);
    }

    public async Task<IEnumerable<Client>> GetClientNameAsync(string name)
    {
        var clients = await _databaseConnection.Table<Client>().Where(x => x.Name.Contains(name)).ToListAsync();
        return clients;
    }

    public async Task<IEnumerable<Client>> GetClientsAsync()
    {
        var clients = await _databaseConnection.Table<Client>().ToListAsync();
        return clients;
    }
}
