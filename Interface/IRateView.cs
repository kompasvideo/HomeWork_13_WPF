using HomeWork_13_WPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Interface
{
    /// <summary>
    /// Позволяет вызвать методы класса RateWindow не напрямую, а через интерфейс
    /// по принципам СОЛИД 
    /// </summary>
    interface IRateView
    {
        /// <summary>
        /// Вызывает метод ShowDialog через интерфейс
        /// </summary>
        void Show(Client client);
    }
}
