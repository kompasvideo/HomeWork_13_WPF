﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Model
{
    class DepositPlusCapitalize :Deposit
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public DepositPlusCapitalize() : base()
        {
        }
        public DepositPlusCapitalize(DateTime dateBegin, float interestRate = 12f, uint days = 365) :
            base(dateBegin, interestRate, days)
        {
        }
        
        
        public override string[] GetSumRate(uint Money)
        {
            double[] sum = new double[12];
            double[] sumPlusDeposit = new double[12];
            double money = Money;
            double sumRate;
            string[] sumStr = new string[12];
            for (int i = 0; i < 12; i++)
            {
                sumRate = money * InterestRate / 100 / 365;
                sum[i] = sumRate * daysOnMonth[i];
                money += sum[i];
                sumPlusDeposit[i] = money;
                sumStr[i] = string.Format($"{sum[i]:f2} руб   {sumPlusDeposit[i]:f2} руб");
            }
            return sumStr;
        }
    }
}
