using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Model
{
    abstract class Department
    {
        public ObservableCollection<Client> Clients { get; set; }
        public abstract string DepartmentName { get; set; }
    }
}
