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
        /// Возвращяет в виде string к какому департаменту относится клиент
        /// </summary>
        public override string Status
        {
            get
            {
                return Const.businessName;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        public VIPClient() : base($"{Const.VIPName} - {Guid.NewGuid().ToString().Substring(0, 5)}")
        {
        }
        
        /// <summary>
        /// Возвращяет enum к какому департаменту относится клиент
        /// </summary>
        /// <returns></returns>
        public override BankDepartment BankDepartmentProp
        {
            get
            {
                return BankDepartment.BusinessDepartment;
            }
        }
    }
}
