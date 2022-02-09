using CandyStore.Core.Enum;
using CandyStore.Core.Properties;
using System;
using System.Collections.Generic;

namespace CandyStore.Core.Domain
{
    public class DomainException : Exception
    {
        public static readonly Dictionary<Error, string> ErrorMessages = new()
        {
            { Error.NotAuthorized, Resources.SErrorNotAuthorized },
            { Error.Forbidden, Resources.SErrorForbidden },
            { Error.NotFound, Resources.SErrorNotFound }
        };

        public Error ErrorType { get; set; }

        public DomainException(string message) : this(Error.BadRequest, message) { }
        public DomainException(Error error) : this(error, ErrorMessages[error]) { }
        public DomainException(Error error, string message) : base(message)
        {
            ErrorType = error;
        }
    }
}
