using HomeWork_13_WPF.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

//  Example_1314 - создание коллекций

namespace HomeWork_13_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            MainViewModel.Source = (ListCollectionView)CollectionViewSource.GetDefaultView(LVClients.ItemsSource);
            MainViewModel.Source.Filter = new Predicate<object>(MainViewModel.myFilter);
        }
    }
}
