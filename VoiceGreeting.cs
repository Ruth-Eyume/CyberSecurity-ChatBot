using System;
using System.IO;
using System.Media;

namespace CyberSecurityChatbot
{
    public class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            try
            {
                string path = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Audio",
                    "greeting.wav" //  FIXED
                );

                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync(); // waits for audio to finish
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error playing audio: " + ex.Message);
            }
        }
    }
}
