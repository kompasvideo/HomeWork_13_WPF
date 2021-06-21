using HomeWork_13_WPF.Interface;
using HomeWork_13_WPF.Model;
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
using System.Windows.Shapes;

namespace HomeWork_13_WPF.View
{
    /// <summary>
    /// Логика взаимодействия для AddDepositNoCapitalizeWindow.xaml
    /// </summary>
    public partial class AddDepositNoCapitalizeWindow : Window, IAddDepositNoCapitalize
    {
        public AddDepositNoCapitalizeWindow()
        {
            InitializeComponent();
        }
        void IAddDepositNoCapitalize.Show(BankDepartment bankDepartment)
        {
            DataContext = new AddDepositNoCapitalizeViewModel(bankDepartment);
            this.ShowDialog();
        }
    }
}
