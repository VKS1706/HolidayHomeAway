﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayHomeAway.Models
{
   public interface ITypeRepo
    {
        IEnumerable<Type> Types { get; }
    }
}
