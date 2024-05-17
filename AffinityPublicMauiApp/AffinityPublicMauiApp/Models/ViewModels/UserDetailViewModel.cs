﻿using AffinityPublicMauiApp.ViewModels;
using System.Windows.Input;

namespace AffinityPublicMauiApp.Models.ViewModels
{
    internal class UserDetailViewModel
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public bool CanEmail { get; set; }

        public CommandViewModel? TextCellCommand { get; set; }
    }
}
