using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Model
{
    class VIPClient : Client
    {
        public override string Status { get; set; } = Const.VIPName;
        public VIPClient() : base($"{Const.VIPName} - {Guid.NewGuid().ToString().Substring(0, 5)}")
        {
        }
        public override BankDepartment GetClassClient()
        {
            return BankDepartment.VIPDepartment;
        }

    }
}
