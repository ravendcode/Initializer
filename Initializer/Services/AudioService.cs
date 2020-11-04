using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Initializer.Services
{
    class AudioService : IAudioService
    {
        private string _successSoundPath = Path.GetFullPath("resources\\audio\\success.wav");
        private string _errorSoundPath = Path.GetFullPath("resources\\audio\\error.wav");

        public void PlaySuccess()
        {
            var succesSound = new SoundPlayer(_successSoundPath);
            succesSound.Play();
        }

        public void PlayError()
        {
            var errorSound = new SoundPlayer(_errorSoundPath);
            errorSound.Play();
        }
    }
}
