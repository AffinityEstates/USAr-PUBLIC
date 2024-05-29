using AffinityPublicMauiApp.Pages;

namespace AffinityPublicMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new RecordDetailPage();
            MainPage = new AppShell();
        }
    }
}
