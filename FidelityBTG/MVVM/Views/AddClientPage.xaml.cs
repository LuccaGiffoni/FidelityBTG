using FidelityBTG.MVVM.ViewModels;

namespace FidelityBTG.MVVM.Views;

public partial class AddClientPage : ContentPage
{
	public AddClientPage(AddClientViewModel addClientViewModel)
	{
		InitializeComponent();
        BindingContext = addClientViewModel;
    }
}