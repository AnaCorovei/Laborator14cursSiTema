using System;
using System.Runtime.Serialization;

namespace Laborator14tema13withlambda.Exceptions
{
    [Serializable]
    internal class InsuficientFundsException : Exception
    {
        public InsuficientFundsException()
        {
        }

        public InsuficientFundsException(string message) : base(message)
        {
        }

        public InsuficientFundsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InsuficientFundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}