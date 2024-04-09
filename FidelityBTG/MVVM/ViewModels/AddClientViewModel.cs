using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FidelityBTG.MVVM.Models;
using FidelityBTG.Services;

namespace FidelityBTG.MVVM.ViewModels;

public partial class AddClientViewModel : ObservableObject
{
    private readonly IClientService _clientService;

    [ObservableProperty] private string _name;
    [ObservableProperty] private string _lastName;
    [ObservableProperty] private string _address;
    [ObservableProperty] private DateTime _birthday;
    [ObservableProperty] private bool _isActive;

    public AddClientViewModel(IClientService clientService) => _clientService = clientService;

    [RelayCommand]
    private async Task AddClient()
    {
        try
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Client newClient = new()
                {
                    Name = Name,
                    LastName = LastName,
                    Address = Address,
                    Birthday = Birthday,
                    IsActive = IsActive,
                };

                await _clientService.InitializeAsync();
                await _clientService.CreateClientAsync(newClient);

                await Shell.Current.GoToAsync("..");
            }
            else
            {
                await Shell.Current.DisplayAlert("Erro!", "Não é possível criar um cliente sem Nome", "OK");
            }
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
    }
}
