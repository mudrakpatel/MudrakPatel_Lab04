using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudrakPatel_Lab04_Ex1
{
    class CustomStackUnderFlowException : Exception
    {
        public CustomStackUnderFlowException() : base("<<<< Custom stack under flow exception caught! >>>>") {
            Console.WriteLine();
        }
    }
}
