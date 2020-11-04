using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer.Errors
{
    [Serializable]
    public class ConfigFileSerializationException : Exception
    {
        public ConfigFileSerializationException() { }
        public ConfigFileSerializationException(string message) : base(message) { }
        public ConfigFileSerializationException(string message, Exception inner) : base(message, inner) { }
        protected ConfigFileSerializationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
