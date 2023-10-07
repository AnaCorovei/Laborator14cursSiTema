using System;
using System.Runtime.Serialization;

namespace Laborator14tema13withlambda.Exceptions
{
    [Serializable]
    internal class CannotConnectToBankExeption : Exception
    {
        public CannotConnectToBankExeption()
        {
        }

        public CannotConnectToBankExeption(string message) : base(message)
        {
        }

        public CannotConnectToBankExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CannotConnectToBankExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}