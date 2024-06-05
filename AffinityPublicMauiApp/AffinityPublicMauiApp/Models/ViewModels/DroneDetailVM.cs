using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffinityPublicMauiApp.Models.ViewModels
{
    public class DroneDetailVM : ObservableObject
    {
        public DroneDetailVM() 
        {
            
        }
        public String? Name { get; set; }
        public String? ImageURL { get; set; }

    }

    public class DroneDetailVMWrapper : ObservableObject
    {
        public DroneDetailVMWrapper() { }

        public List<DroneDetailVM> Items { get; set; }

        public DroneDetailVM droneItem { get; set; }
    }
}
