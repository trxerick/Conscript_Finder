using ConscriptFinder.Models;
using ConscriptFinder.States;
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
    /// <summary>
    /// Логика взаимодействия для ConscriptCommandView.xaml
    /// </summary>
    public partial class ConscriptCommandView : Window
    {
        public ConscriptCommandView(ConscriptCommandViewModel ViewModel, ConscriptCommand ConscriptCommand)
        {
            InitializeComponent();
            DataContext = ViewModel;
            ((ConscriptCommandViewModel)DataContext).View = this;
            ((ConscriptCommandViewModel)DataContext).ConscriptCommand = ConscriptCommand;
        }
    }
}
