using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Model
{
    class BusinessClient : Client
    {
        /// <summary>
        /// Хранит в тексовом виде к какому департаменту относится клиент
        /// </summary>
        public override string Status { get; set; } = Const.businessName;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        public BusinessClient() : base($"{Const.businessName} - {Guid.NewGuid().ToString().Substring(0, 5)}")
        {
        }
        public BusinessClient(string Name, uint Money) : base(Name, Money)
        {
        }

        /// <summary>
        /// Возвращяет enum к какому департаменту относится клиент
        /// </summary>
        /// <returns></returns>
        public override BankDepartment GetClassClient()
        {
            return BankDepartment.BusinessDepartment;
        }        
    }
}
