using Initializer.Errors;
using Initializer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Initializer.Services;
using Newtonsoft.Json.Serialization;

namespace Initializer.Data
{
    public class JsonConfigReaderWriter : IConfigReaderWriter
    {
        private string _fileName = "config.json";

        //public IEnumerable<Preset> GetPresets()
        //{
        //    try
        //    {
        //        using (StreamReader r = new StreamReader(_fileName))
        //        {
        //            string json = r.ReadToEnd();
        //            return JsonConvert.DeserializeObject<IEnumerable<Preset>>(json);
        //        }
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        throw new ConfigFileNotFoundException($"{LangService.Translate("no_file_error")} {_fileName}");
        //    }
        //    catch (JsonException)
        //    {
        //        throw new ConfigFileSerializationException($"{LangService.Translate("invalid_error")} {_fileName}");
        //    }
        //}

        public Config GetConfig()
        {
            try
            {
                using (StreamReader r = new StreamReader(_fileName))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<Config>(json);
                }
            }
            catch (FileNotFoundException)
            {
                throw new ConfigFileNotFoundException($"{LangService.Translate("no_file_error")} {_fileName}");
            }
            catch (JsonException)
            {
                throw new ConfigFileSerializationException($"{LangService.Translate("invalid_error")} {_fileName}");
            }
        }

        public void SaveConfig(Config config)
        {
            string json = JsonConvert.SerializeObject(config, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            });
            File.WriteAllText(_fileName, json + "\n");
        }
    }
}
