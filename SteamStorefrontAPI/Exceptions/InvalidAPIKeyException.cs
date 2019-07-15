using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamStorefrontAPI.Exceptions
{
    [Serializable]
    public class InvalidAPIKeyException : Exception
    {
        public InvalidAPIKeyException() { }
        public InvalidAPIKeyException(string message) : base(message) { }
        public InvalidAPIKeyException(string message, Exception inner) : base(message, inner) { }
        protected InvalidAPIKeyException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
