using System;
using System.Runtime.Serialization;

namespace Laborator14tema13withlambda.Exceptions
{
    [Serializable]
    internal class TooManyCardsException : Exception
    {
        public TooManyCardsException()
        {
        }

        public TooManyCardsException(string message) : base(message)
        {
        }

        public TooManyCardsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TooManyCardsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}