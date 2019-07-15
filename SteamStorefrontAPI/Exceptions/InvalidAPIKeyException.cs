using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamStorefrontAPI.Exceptions
{
    [Serializable]
    public class InvalidApiKeyException : Exception
    {
        public InvalidApiKeyException() { }
        public InvalidApiKeyException(string message) : base(message) { }
        public InvalidApiKeyException(string message, Exception inner) : base(message, inner) { }
        protected InvalidApiKeyException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
