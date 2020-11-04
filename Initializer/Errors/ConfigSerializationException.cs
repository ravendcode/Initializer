using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer.Errors
{
    [Serializable]
    public class ConfigSerializationException : Exception
    {
        public ConfigSerializationException() { }
        public ConfigSerializationException(string message) : base(message) { }
        public ConfigSerializationException(string message, Exception inner) : base(message, inner) { }
        protected ConfigSerializationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
