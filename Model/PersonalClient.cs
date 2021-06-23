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
        /// Возвращяет в виде string к какому департаменту относится клиент
        /// </summary>
        public override string Status
        {
            get
            {
                return Const.businessName;
            }
        }

        public PersonalClient(): base($"{Const.personalName} - {Guid.NewGuid().ToString().Substring(0, 5)}") 
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
