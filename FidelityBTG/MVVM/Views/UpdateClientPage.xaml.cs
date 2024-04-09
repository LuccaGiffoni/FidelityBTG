using FidelityBTG.MVVM.ViewModels;

namespace FidelityBTG.MVVM.Views;

public partial class UpdateClientPage : ContentPage
{
	public UpdateClientPage(UpdateClientViewModel updateClientViewModel)
	{
		InitializeComponent();

		BindingContext = updateClientViewModel;
	}
}