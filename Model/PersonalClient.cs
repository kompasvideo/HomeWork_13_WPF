﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_WPF.Model
{
    class PersonalClient : Client
    {
        public override string Status { get; set; } = "Физ. лицо";
        public PersonalClient(): base($"Физ. лицо-{Guid.NewGuid().ToString().Substring(0, 5)}") 
        {
        }
    }
}
