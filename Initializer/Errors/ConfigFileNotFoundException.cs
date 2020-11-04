using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer.Errors
{
    [Serializable]
    public class ConfigFileNotFoundException : Exception
    {
        public ConfigFileNotFoundException() { }
        public ConfigFileNotFoundException(string message) : base(message) { }
        public ConfigFileNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected ConfigFileNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

