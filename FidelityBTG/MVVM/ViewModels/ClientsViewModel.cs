using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FidelityBTG.MVVM.Models;
using FidelityBTG.Services;
using System.Collections.ObjectModel;

namespace FidelityBTG.MVVM.ViewModels;

public partial class ClientsViewModel(IClientService livroService) : ObservableObject
{
    private readonly IClientService _clientService = livroService;

    public ObservableCollection<Client> Clients { get; set; } = [];

    [RelayCommand]
    public async Task GetAllClients()
    {
        Clients.Clear();

        try
        {
            await _clientService.InitializeAsync();
            var clients = await _clientService.GetClientsAsync();

            if (clients.Any())
            {
                foreach (var client in clients)
                {
                    Clients.Add(client);
                }
            }
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Erro!", ex.Message, "OK");
        }
    }

    [RelayCommand] private static async Task AddClient() => await Shell.Current.GoToAsync("AddClientPage");

    [RelayCommand] private static async Task UpdateClient(Client client) => await Shell.Current.GoToAsync("UpdateClientPage", new Dictionary<string, object> { { "ClientObject", client } });

    [RelayCommand]
    private async Task DeleteClient(Client client)
    {
        var result = await Shell.Current.DisplayAlert("Excluir Cliente!", $"Você tem certeza de que quer excluir para sempre o cliente : \n\n \"{client.Name + " " + client.LastName}\"?", "Sim", "Não");

        if (result is true)
        {
            try
            {
                await _clientService.InitializeAsync();
                await _clientService.DeleteClientAsync(client);
                await GetAllClients();
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Erro!", ex.Message, "OK");
            }
        }
    }
}