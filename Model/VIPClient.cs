using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Model
{
    class VIPClient : Client
    {
        /// <summary>
        /// Хранит в тексовом виде к какому департаменту относится клиент
        /// </summary>
        public override string Status { get; set; } = Const.VIPName;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        public VIPClient() : base($"{Const.VIPName} - {Guid.NewGuid().ToString().Substring(0, 5)}")
        {
        }
        public VIPClient(string Name, uint Money) : base(Name, Money)
        {
        }

        /// <summary>
        /// Возвращяет enum к какому департаменту относится клиент
        /// </summary>
        /// <returns></returns>
        public override BankDepartment GetClassClient()
        {
            return BankDepartment.VIPDepartment;
        }
    }
}
