using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentsApp.Controls
{
    public class EditProperty : Control, IDataErrorInfo
    {
        static EditProperty()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EditProperty), new FrameworkPropertyMetadata(typeof(EditProperty)));
        }

        #region Dependency Properties



        public string HeaderText
        {
            get { return (string)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }

        
        public static readonly DependencyProperty HeaderTextProperty =
            DependencyProperty.Register("HeaderText", typeof(string), typeof(EditProperty), new PropertyMetadata(String.Empty));



        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(string), typeof(EditProperty), new PropertyMetadata(String.Empty));



        public string ErrorText
        {
            get { return (string)GetValue(ErrorTextProperty); }
            set { SetValue(ErrorTextProperty, value); }
        }

        
        public static readonly DependencyProperty ErrorTextProperty =
            DependencyProperty.Register("ErrorText", typeof(string), typeof(EditProperty), new PropertyMetadata(String.Empty));



        #endregion

        public string this[string columnName]
        {
            get
            {
                string error = null;
                var errorContext = DataContext as IDataErrorInfo;

                if (errorContext != null)
                {
                    var expression = GetBindingExpression(ValueProperty);
                    if (expression?.ParentBinding != null)
                    {
                        var propertyName = expression.ParentBinding.Path.Path;
                        error = errorContext[propertyName];
                    }
                }

                ErrorText = error;

                return error;
            }
        }

        public string Error
        {
            get
            {
                string error = null;
                var errorContext = DataContext as IDataErrorInfo;

                if (errorContext != null)
                {
                    error = errorContext.Error;
                }

                return error;
            }
        }
    }
}
