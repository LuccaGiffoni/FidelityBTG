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

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var viewModel = (ClientsViewModel)BindingContext;

        viewModel.GetAllClientsCommand.Execute(null);
    }

    private async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        var clients = await _clientService.GetClientNameAsync(((SearchBar)sender).Text);
        ClientsCollectionView.ItemsSource = clients;
    }
}