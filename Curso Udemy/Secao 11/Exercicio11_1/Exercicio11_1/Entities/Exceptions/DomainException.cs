using System;


namespace Exercicio11_1.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base(message)
        {

        }
    }
}
