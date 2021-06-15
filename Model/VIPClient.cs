using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Model
{
    class VIPClient : Client
    {
        public override string Status { get; set; } = "VIP";
        public VIPClient() : base($"VIP-{Guid.NewGuid().ToString().Substring(0, 5)}")
        {
        }
    }
}
