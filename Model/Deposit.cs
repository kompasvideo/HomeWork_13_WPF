﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Model
{
    class Deposit
    {
        /// <summary>
        /// Процентная ставка
        /// </summary>
        public float InterestRate { get; set; }
        /// <summary>
        /// Срок открытия депозита
        /// </summary>
        public DateTime DateBegin { get; set; }
        /// <summary>
        /// Срок кредита в днях
        /// </summary>
        public uint Days { get; set; }
        protected byte[] daysOnMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        public Deposit()
        {
            InterestRate = 12f;
            DateBegin = DateTime.Now;
            Days = 365;
        }
        public Deposit(DateTime dateBegin, float interestRate = 12f, uint days = 365)
        {
            InterestRate = interestRate;
            DateBegin = dateBegin;
            Days = days;
        }

        public virtual string[] GetSumRate(uint Money)
        {
            double[] sum = new double[12];
            double[] sumPlusDeposit = new double[12];
            double money = Money;
            double sumRate = Money * InterestRate / 100 / 365;
            string[] sumStr = new string[12];
            for (int i = 0; i < 12; i++)
            {
                sum[i] = sumRate * daysOnMonth[i];
                money += sum[i];
                sumPlusDeposit[i] = money;
                sumStr[i] = string.Format($"{sum[i]:f2} руб   {sumPlusDeposit[i]:f2} руб");
            }
            return sumStr;
        }
    }
}
