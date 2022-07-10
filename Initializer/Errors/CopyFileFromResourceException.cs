using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer.Errors
{
    [Serializable]
    public class CopyFileFromResourceException : Exception
    {
        public CopyFileFromResourceException() { }
        public CopyFileFromResourceException(string message) : base(message) { }
        public CopyFileFromResourceException(string message, Exception inner) : base(message, inner) { }
        protected CopyFileFromResourceException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
