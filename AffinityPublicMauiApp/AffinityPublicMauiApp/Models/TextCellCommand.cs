﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AffinityPublicMauiApp.ViewModels
{
    public class TextCellCommand : ICommand
    {
        event EventHandler? ICommand.CanExecuteChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        bool ICommand.CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        void ICommand.Execute(object? parameter)
        {
            // Go to form
        }
    }
}