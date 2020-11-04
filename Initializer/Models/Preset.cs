using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer.Models
{
    public class Preset
    {
        public string Name { get; set; }
        public List<Option> Files { get; set; } = new List<Option>();
    }
}
