﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudrakPatel_Lab04_Ex1
{
    class CustomStackOverFlowException : Exception
    {
        public CustomStackOverFlowException():base("<<<<Custom stack overflow exception caught!>>>>")
        {
            Console.WriteLine();
        }
    }
}
