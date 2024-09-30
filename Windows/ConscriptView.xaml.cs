using System;
using ConscriptFinder.Models;
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
using ConscriptFinder.States;

namespace ConscriptFinder.Windows
{
    /// <summary>
    /// Логика взаимодействия для ConscriptView.xaml
    /// </summary>
    public partial class ConscriptView : Window
    {
        public ConscriptView(ConscriptViewModel ViewModel, Conscript Conscript)
        {
            InitializeComponent();
            DataContext = ViewModel;
            ((ConscriptViewModel)DataContext).ConView = this;
            ((ConscriptViewModel)DataContext).Conscript = Conscript;
        }
    }
}
