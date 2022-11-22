using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer.Models
{
    public class Config
    {
        private string _lang;
        public string Lang
        {
            get => _lang;
            set => _lang = value.ToLower();
        }
        public bool AddProjectNameFolder { get; set; }
        public List<Preset> Presets { get; set; }
    }
}
