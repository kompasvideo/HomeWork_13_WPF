using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Model
{
    class VIPDepartment : Department
    {
        public override string DepartmentName { get; set; } = "VIP";

        public VIPDepartment()
        {
            Clients = new ObservableCollection<Client>();
        }
    }
}
