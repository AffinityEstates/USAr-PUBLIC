using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AffinityPublicMauiApp.ViewModels
{
    public class CommandViewModel
    {
        public ICommand TextCellCommand => new Command(ClickEvent);

        private void ClickEvent(object o)
        {
            Console.WriteLine("in Click event");
        }


    }
}
