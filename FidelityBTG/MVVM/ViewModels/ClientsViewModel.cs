using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FidelityBTG.MVVM.Models;
using FidelityBTG.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace FidelityBTG.MVVM.ViewModels;

public partial class ClientsViewModel : ObservableObject
{
    private readonly IClientService _clientService;

    public ObservableCollection<Client> Clients { get; set; } = new();

    public ClientsViewModel(IClientService livroService)
    {
        _clientService = livroService;
    }

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
                foreach (var livro in clients)
                {
                    Clients.Add(livro);
                }
            }
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Erro!", ex.Message, "OK");
        }
    }

    [RelayCommand] private static async Task AddClient() => await Shell.Current.GoToAsync("AddClientPage");

    [RelayCommand]
    private static async Task UpdateClient(Client client)
    {
        try
        {
            await Shell.Current.GoToAsync("UpdateClientPage", new Dictionary<string, object> { { "ClientObject", client } });
        }
        catch(Exception e)
        {
            Debug.WriteLine(e);
        }
    }

    [RelayCommand]
    private async Task DeleteClient(Client client)
    {
        var result = await Shell.Current.DisplayAlert("Deletar", $"Confirma exclusão do cliente : \n\n \"{client.Name + " " + client.LastName}\"?", "Sim", "Não");

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
