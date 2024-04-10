using FidelityBTG.MVVM.ViewModels;
using FidelityBTG.Services;

namespace FidelityBTG.MVVM.Views;

public partial class ClientsPage : ContentPage
{
    private readonly IClientService _clientService;
    public ClientsPage(ClientsViewModel clientsViewModel,
                      IClientService clientService)
    {
        InitializeComponent();
        BindingContext = clientsViewModel;
        _clientService = clientService;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        var viewModel = BindingContext as ClientsViewModel;
        if (viewModel != null)
        {
            await viewModel.GetAllClients();
        }
    }

    private async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        var clients = await _clientService.GetClientNameAsync(((SearchBar)sender).Text);
        ClientsCollectionView.ItemsSource = clients;
    }
}