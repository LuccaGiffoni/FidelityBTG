using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FidelityBTG.MVVM.Models;
using FidelityBTG.Services;

namespace FidelityBTG.MVVM.ViewModels;

[QueryProperty(nameof(Client), "ClientObject")]
public partial class UpdateClientViewModel : ObservableObject
{
    private readonly IClientService _clientService;

    [ObservableProperty] private Client _client;

    public UpdateClientViewModel(IClientService clientService) => _clientService = clientService;

    [RelayCommand]
    private async Task UpdateClient()
    {
        if (!string.IsNullOrEmpty(Client.Name))
        {
            await _clientService.InitializeAsync();
            await _clientService.UpdateClientAsync(Client);

            await Shell.Current.GoToAsync("..");
        }
        else
        {
            await Shell.Current.DisplayAlert("Erro!", "Cliente sem nome.", "OK");
        }
    }
}