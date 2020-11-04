using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer.Services
{
    public interface IAudioService
    {
        void PlaySuccess();
        void PlayError();
    }
}
