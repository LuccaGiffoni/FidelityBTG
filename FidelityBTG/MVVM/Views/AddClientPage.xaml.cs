using FidelityBTG.MVVM.ViewModels;

namespace FidelityBTG.MVVM.Views;

public partial class AddClientPage : ContentPage
{
	public AddClientPage(AddClientViewModel addClientViewModel)
	{
		InitializeComponent();
        BindingContext = addClientViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
		ClearEntries();	
    }

    private void ClearEntries()
	{
		AddressEntry.Text = string.Empty;
		NameEntry.Text = string.Empty;
		LastNameEntry.Text = string.Empty;
	}
}