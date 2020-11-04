using Initializer.Errors;
using Initializer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer.Data
{
    public class JsonConfigReader : IConfigReader
    {
        private string _fileName = "config.json";

        public IEnumerable<Preset> GetPresets()
        {
            try
            {
                using (StreamReader r = new StreamReader(_fileName))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<IEnumerable<Preset>>(json);
                }
            }
            catch (FileNotFoundException e)
            {
                throw new ConfigFileNotFoundException($"Нету файла {_fileName}");
            }
            catch (JsonException e)
            {
                throw new ConfigSerializationException($"Невалидный {_fileName}");
            }
        }
    }
}
