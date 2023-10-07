using System;
using System.Runtime.Serialization;

namespace Laborator14tema13withlambda.Exceptions
{
    [Serializable]
    internal class TooManyConnectionsException : Exception
    {
        public TooManyConnectionsException()
        {
        }

        public TooManyConnectionsException(string message) : base(message)
        {
        }

        public TooManyConnectionsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TooManyConnectionsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}