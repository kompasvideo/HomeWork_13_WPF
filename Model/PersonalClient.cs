using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Model
{
    class PersonalClient : Client
    {
        /// <summary>
        /// Хранит в тексовом виде к какому департаменту относится клиент
        /// </summary>
        public override string Status { get; set; } = Const.personalName;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        public PersonalClient(): base($"{Const.personalName} - {Guid.NewGuid().ToString().Substring(0, 5)}") 
        {
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        public PersonalClient(string Name, uint Money) : base(Name, Money)
        {
        }
        
        /// <summary>
        /// Возвращяет enum к какому департаменту относится клиент
        /// </summary>
        /// <returns></returns>
        public override BankDepartment GetClassClient()
        {
            return BankDepartment.PersonalDepartment;
        }
    }
}
