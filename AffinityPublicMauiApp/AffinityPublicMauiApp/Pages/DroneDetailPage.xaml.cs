using AffinityPublicMauiApp.Models.ViewModels;

namespace AffinityPublicMauiApp.Pages;

public partial class DroneDetailPage : ContentPage
{
	public DroneDetailPage(DroneDetailVM vm)
	{
		InitializeComponent();

		vm.ImageURL = "https://lh4.googleusercontent.com/m7wwhCyQGfttD3Ccby_JEkZ1O53YpTVV_jH13v9PiHDh2_d3XRf5FkMaBnlPWGz-sq08oyM-1NftLMmaV9uPo777_tkTmSKRE9x-yPK-_yGd6kigd9AfelydstQJbR_-qA=w1280";
		vm.ImageURL = "indydrone.jpg";
		var droneList = new List<DroneDetailVM>();
		droneList.Add(vm);

		BindingContext = droneList;

	}
}