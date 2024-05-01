using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffinityPublicMauiApp.Models
{
    
    public partial class AffinityItems : ObservableObject
    {
        [ObservableProperty]
        private string? name;

        private DBModel? Db;
        public AffinityItems(DBModel db) { 
            Db = db;
        }

        public List<String> getAffinityItems()
        {
            // TODO: return string list of affinity items to show from database
            return new List<String> { };
        }

        public void updateAffinityItems()
        {
            return;
        }

        partial void OnNameChanged(string? value)
        {
            // TODO: Do something on change
        }
    }
}
