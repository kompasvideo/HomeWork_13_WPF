﻿using HomeWork_13_WPF.View;
using HomeWork_13_WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HomeWork_13_WPF
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public DisplayRootRegistry displayRootRegistry = new DisplayRootRegistry();
        MainViewModel mainWindowViewModel;

        public App()
        {
            displayRootRegistry.RegisterWindowType<MainViewModel, MainWindow>();
            displayRootRegistry.RegisterWindowType<AddAccountViewModel, AddAccountWindow>();
            displayRootRegistry.RegisterWindowType<AddDepositCapitalizeViewModel, AddDepositCapitalizeWindow>();
            displayRootRegistry.RegisterWindowType<AddDepositNoCapitalizeViewModel, AddDepositNoCapitalizeWindow>();
            displayRootRegistry.RegisterWindowType<MoveMoneyViewModel, MoveMoneyWindow>();
            displayRootRegistry.RegisterWindowType<RateViewModel, RateWindow>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            ViewModelLocator.Init();
            base.OnStartup(e);

            mainWindowViewModel = new MainViewModel();

            displayRootRegistry.ShowModalPresentation(mainWindowViewModel);

            Shutdown();
        }
    }
}
