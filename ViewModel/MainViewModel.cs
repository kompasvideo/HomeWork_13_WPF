using HomeWork_13_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using System.Windows.Input;

namespace HomeWork_13_WPF.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public ObservableCollection<string> departments { get; set; } = new ObservableCollection<string>() 
            {Const.personalName, Const.businessName, Const.VIPName};
        public ObservableCollection<Client> clients { get; set; } = new ObservableCollection<Client>();
        Random rnd = new Random();
        public Client SelectedClient { get; set; }
        public static string SelectedDep { get; set; }
        /// <summary>
        /// CollectionViewSource для департаментов
        /// </summary>
        public static System.ComponentModel.ICollectionView Source;
        public MainViewModel()
        {
            AddClientsToBank(rnd.Next(10, 30), rnd.Next(10, 30), rnd.Next(10, 30));
        }
        void AddClientsToBank(int personal, int business, int vip)
        {
            // 
            for (int i = 0; i < personal; i++)
            {
                CreateClientsCollection<PersonalClient>();
            }

            // 
            for (int i = 0; i < business; i++)
            {
                CreateClientsCollection<BusinessClient>();
            }

            // 
            for (int i = 0; i < vip; i++)
            {
                CreateClientsCollection<VIPClient>();
            }
        }
        void CreateClientsCollection<T>() where T : Client, new()
        {
            clients.Add(new T());
        }
        /// <summary>
        /// Команда "Выбор элемента в ListBox"
        /// </summary>
        public ICommand SelectedItemChangedCommand
        {
            get
            {
                var a = new DelegateCommand((obj) =>
                {
                    if (Source != null)
                        Source.Filter = new Predicate<object>(myFilter);
                });
                return a;
            }
        }
        public static bool myFilter(object obj)
        {
            var c = obj as Client;
            if (SelectedDep != null)
            {
                switch (SelectedDep)
                {
                    case Const.personalName:
                        if (c.GetClassClient() == BankDepartment.PersonalDepartment)
                            return true;
                        else
                            return false;
                    case Const.businessName:
                        if (c.GetClassClient() == BankDepartment.BusinessDepartment)
                            return true;
                        else
                            return false;
                    case Const.VIPName:
                        if (c.GetClassClient() == BankDepartment.VIPDepartment)
                            return true;
                        else
                            return false;
                }
            }
            return true;            
        }
    }
}
