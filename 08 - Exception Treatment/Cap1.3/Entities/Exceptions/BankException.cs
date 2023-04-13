using System;

namespace Cap1._3.Entities.Exceptions
{
    public class BankException : ApplicationException
    {
        public BankException(string message):base(message){}
    }
}