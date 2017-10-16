using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StudentsApp.Commands;

namespace StudentsApp.ViewModels
{
    public class ErrorViewModel : BaseViewModel
    {
        private string _errorText;

        public string ErrorText
        {
            get { return _errorText; }
            set
            {
                _errorText = value;
                OnPropertyChanged();
            }
        }

        public ICommand ClickCommand { get; set; }

        public ErrorViewModel(Action<object> clickAction)
        {
            ClickCommand = new DelegateCommand(p => true, clickAction);
        }

        public ErrorViewModel(RoutedUICommand command)
        {
           
            ClickCommand = command;
        }

        
    }
}
