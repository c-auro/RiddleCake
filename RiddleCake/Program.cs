using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore;
using CSCore.SoundOut;
using CSCore.Codecs;
using System.Threading;

namespace RiddleCake
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.PlayASound(@"C: \Users\MechaKoopa\Desktop\piano_note_20160812.mp3");
            Program.PlayASound(@"C:\Users\MechaKoopa\Desktop\ding20160812.mp3"); 
            
        }

        public static void PlayASound(string file)
        {
            //Contains the sound to play
            using (IWaveSource soundSource = GetSoundSource(file))
            {
                //SoundOut implementation which plays the sound
                using (ISoundOut soundOut = GetSoundOut())
                {
                    //Tell the SoundOut which sound it has to play
                    soundOut.Initialize(soundSource);
                    //Play the sound
                    soundOut.Play();

                    Thread.Sleep(2000);

                    //Stop the playback
                    soundOut.Stop();

                }
            }
        }

        private static ISoundOut GetSoundOut()
        {
            if (WasapiOut.IsSupportedOnCurrentPlatform)
                return new WasapiOut();
            else
                return new DirectSoundOut();
        }

        private static IWaveSource GetSoundSource(string file)
        {
            //return any source ... in this example, we'll just play a mp3 file
            return CodecFactory.Instance.GetCodec(file);
        }
    }
}
