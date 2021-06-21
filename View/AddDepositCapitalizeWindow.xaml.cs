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
    /// Логика взаимодействия для AddDepositCapitalizeWindow.xaml
    /// </summary>
    public partial class AddDepositCapitalizeWindow : Window, IAddDepositCapitalize
    {
        public AddDepositCapitalizeWindow()
        {
            InitializeComponent();
        }
        void IAddDepositCapitalize.Show(BankDepartment bankDepartment)
        {
            DataContext = new AddDepositCapitalizeViewModel(bankDepartment);
            this.ShowDialog();
        }
    }
}
