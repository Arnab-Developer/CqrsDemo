using System;

namespace CqrsDemo.Domain.Exceptions
{
    public class CentreDomainException : Exception
    {
        public CentreDomainException()
        {
        }

        public CentreDomainException(string message)
            : base(message)
        {
        }
    }
}