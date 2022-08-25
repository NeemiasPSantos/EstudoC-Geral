using System;

namespace ExerException.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) :base(message)
        {
        }
    }
}
