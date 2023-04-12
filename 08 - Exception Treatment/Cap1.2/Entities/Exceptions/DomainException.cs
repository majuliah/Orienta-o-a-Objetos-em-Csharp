using System;
namespace Cap1._2.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message): base(message){}
    }
}