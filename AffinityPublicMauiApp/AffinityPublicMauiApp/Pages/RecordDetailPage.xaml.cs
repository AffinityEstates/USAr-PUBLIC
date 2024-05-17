using AffinityPublicMauiApp.Models.ViewModels;

namespace AffinityPublicMauiApp.Pages;

public partial class RecordDetailPage : ContentPage
{
	public RecordDetailPage()
	{
		InitializeComponent();

		var recordDetailRow = new UserDetailViewModel() { CanEmail = true,
			UserEmail = "TestEmail@email.com",
			UserName = "TestUser",
			TextCellCommand = new ViewModels.CommandViewModel()
		};

		BindingContext = recordDetailRow;
	}

    void btnDroneOnClick(object sender, EventArgs e)
    {

    }
}