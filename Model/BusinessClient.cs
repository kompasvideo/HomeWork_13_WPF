using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Model
{
    class BusinessClient : Client
    {
        public override string Status { get; set; } = "Юр. лицо";
        public BusinessClient() : base($"Юр. лицо-{Guid.NewGuid().ToString().Substring(0, 5)}")
        {
        }
    }
}
