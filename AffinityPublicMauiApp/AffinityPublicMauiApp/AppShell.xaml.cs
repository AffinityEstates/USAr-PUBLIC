using AffinityPublicMauiApp.Pages;

namespace AffinityPublicMauiApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(DroneDetailPage), typeof(DroneDetailPage));
        }
    }
}
