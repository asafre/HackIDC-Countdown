﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCountdown.Model
{
    interface IDataStorage
    {
        public virtual bool SaveTimer(STimerDetails timerToSave);
    }
}
