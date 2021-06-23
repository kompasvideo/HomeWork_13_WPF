using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using System.Windows.Input;
using HomeWork_13_WPF.View;
using System.Windows;
using HomeWork_13_WPF.Interface;
using HomeWork_13_WPF.Model;

namespace HomeWork_13_WPF.ViewModel
{
    class RateViewModel : ViewModelBase
    {
        public string[] MoneyRate { get; set; }

        public RateViewModel(Client client)
        {
            MoneyRate = client.DepositClient.GetSumRate(client.Money);
        }

        /// <summary>
        /// Нажата кнопка "Ок"
        /// </summary>
        public ICommand bOK_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                    {
                        if (window.Title == "Расчёт %")
                        {
                            window.Close();
                        }
                    }
                });
            }
        }
    }
}
