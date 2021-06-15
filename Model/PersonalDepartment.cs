using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Model
{
    class PersonalDepartment: Department
    {
        public override string DepartmentName { get; set; } = "Физ. лицо";

        public PersonalDepartment()
        {
            Clients = new ObservableCollection<Client>();
        }
    }
}
