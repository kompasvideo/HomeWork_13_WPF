using HomeWork_13_WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace HomeWork_13_WPF.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Department> bank { get; set; } = new ObservableCollection<Department>();
        Random rnd = new Random();
        public Client SelectedClient { get; set; }
        public MainViewModel()
        {
            bank.Add(new PersonalDepartment());
            bank.Add(new BusinessDepartment());
            bank.Add(new VIPDepartment());

            AddClientsToBank(rnd.Next(10, 30), rnd.Next(10, 30), rnd.Next(10, 30));
        }
        void AddClientsToBank(int personal, int business, int vip)
        {
            // 
            for (int i = 0; i < personal; i++)
            {
                CreateClientsCollection<PersonalClient>((int)BankDepartment.PersonalDepartment);
            }

            // 
            for (int i = 0; i < business; i++)
            {
                CreateClientsCollection<BusinessClient>((int)BankDepartment.BusinessDepartment);
            }

            // 
            for (int i = 0; i < vip; i++)
            {
                CreateClientsCollection<VIPClient>((int)BankDepartment.VIPDepartment);
            }
        }
        void CreateClientsCollection<T>(int bankDep) where T : Client, new()
        {
            bank[bankDep].Clients.Add(new T());
        }

    }
}
