﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class ParseException : Exception
    {
        public ParseException(string message) : base(message)
        {
        }
    }
}
