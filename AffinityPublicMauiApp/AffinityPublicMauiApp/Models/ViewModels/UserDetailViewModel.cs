using AffinityPublicMauiApp.Pages;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AffinityPublicMauiApp.Models.ViewModels
{
    internal class UserDetailViewModel : ObservableObject
    {
        public UserDetailViewModel() {
            TextCellCommand = new Command(TextCommand);
        
        }
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public bool CanEmail { get; set; }

        public ICommand TextCellCommand { get; set; }

        private async void TextCommand()
        {
            Console.WriteLine("In Command");
            await Shell.Current.GoToAsync(nameof(DroneDetailPage));
        
        }
    }
}
