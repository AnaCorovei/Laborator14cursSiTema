using System;
using System.Runtime.Serialization;

namespace Laborator14tema13withlambda.Exceptions
{
    [Serializable]
    internal class ContInvalidException : Exception
    {
        public ContInvalidException()
        {
        }

        public ContInvalidException(string message) : base(message)
        {
        }

        public ContInvalidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ContInvalidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}