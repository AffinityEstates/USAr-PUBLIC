using AffinityPublicMauiApp.Models.ViewModels;

namespace AffinityPublicMauiApp.Pages;

public partial class DroneDetailPage : ContentPage
{
	public DroneDetailPage(DroneDetailVM vm)
	{
        InitializeComponent();

		BindingContext = vm;
	}
}