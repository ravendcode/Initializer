using Initializer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer.Data
{
    public interface IConfigReader
    {
        IEnumerable<Preset> GetPresets();
    }
}
