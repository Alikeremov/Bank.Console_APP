using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ConsoleApp.Utilites.Exceptions
{
    internal class MyNullAbleException:Exception
    {
        public MyNullAbleException(string message) : base (message) 
        { 

        }
    }
}
