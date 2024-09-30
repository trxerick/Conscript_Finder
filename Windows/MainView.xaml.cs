using ConscriptFinder.Logic;
using ConscriptFinder.Models;
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

namespace ConscriptFinder.Windows
{
    public partial class MainView : Window
    {
        public MainView(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (e.Key == Key.Enter)
            {
                tb.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
            }
        }

        private void DatePickerKeyDown(object sender, KeyEventArgs e)
        { 
            DatePicker dp = sender as DatePicker;

            if(e.Key == Key.Enter)
            {
                dp.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
            }
        }

        private void ComboBoxKeyDown(object sender, KeyEventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if(e.Key == Key.Enter)
            {
                cb.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
            }
        }
    }
}