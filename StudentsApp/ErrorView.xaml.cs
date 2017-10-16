using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using StudentsApp.ViewModels;

namespace StudentsApp
{
    /// <summary>
    /// Interaction logic for ErrorView.xaml
    /// </summary>
    public partial class ErrorView : Window
    {
        public ErrorView(ErrorViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        public ErrorView(RoutedUICommand command, string errorText)
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(command, CommandExecuted, CommandCanExecute));
            DataContext = new ErrorViewModel(command) {ErrorText = errorText };
        }

        private void CommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
