using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class Person
    {
        private string _accountNumber = "1234";
        public string AccountNumber
        {
            get => _accountNumber;
            set => _accountNumber = value;
        }
    }
}
