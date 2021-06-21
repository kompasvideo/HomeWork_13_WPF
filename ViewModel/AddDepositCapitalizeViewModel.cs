﻿using DevExpress.Mvvm;
using HomeWork_13_WPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HomeWork_13_WPF.ViewModel
{
    class AddDepositCapitalizeViewModel : ViewModelBase
    {
        public static DepositPlusCapitalize DepositV { get; set; }
        BankDepartment bankDepartment;

        public AddDepositCapitalizeViewModel()
        {
            DepositV = new DepositPlusCapitalize();
        }
        public AddDepositCapitalizeViewModel(BankDepartment bankDepartment)
        {
            this.bankDepartment = bankDepartment;
            DepositV = new DepositPlusCapitalize();
            switch (bankDepartment)
            {
                case BankDepartment.BusinessDepartment:
                    DepositV.InterestRate = 12;
                    break;
                case BankDepartment.PersonalDepartment:
                    DepositV.InterestRate = 24;
                    break;
                case BankDepartment.VIPDepartment:
                    DepositV.InterestRate = 36;
                    break;
            }
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
                    Messenger.Default.Send(DepositV);

                    foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                    {
                        if (window.Title == "Открыть вклад с капитализацией %")
                        {
                            window.Close();
                        }
                    }

                });
            }
        }

        /// <summary>
        /// Нажата кнопка "Отмена"
        /// </summary>
        public ICommand bCancel_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                    {
                        if (window.Title == "Открыть вклад с капитализацией %")
                        {
                            window.Close();
                        }
                    }
                });
            }
        }
    }
}
