using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentsApp.Commands
{
    class DelegateCommand : ICommand
    {
        private readonly Func<object, bool> _canExecuteAction;
        private readonly Action<object> _executeAction;

        public DelegateCommand(Func<object, bool> canExecuteAction, Action<object> executeAction)
        {
            _canExecuteAction = canExecuteAction;
            _executeAction = executeAction;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecuteAction?.Invoke(parameter) ?? false;
        }

        public void Execute(object parameter)
        {
            _executeAction?.Invoke(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
