using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Model
{
    abstract class Client
    {
        public string Name { get; set; }
        public uint Money { get; set; }
        public abstract string Status { get; set; }
        public Client(string name)
        {
            Name = name;
            Random rnd = new Random();
            Money = (uint)rnd.Next(0, 10000); 
        }
        public abstract BankDepartment GetClassClient();
    }
}
