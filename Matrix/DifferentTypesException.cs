﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class DifferentTypesException : Exception
    {
        public DifferentTypesException(string message)
            : base(message)
        { }
    }
}
