using System;
using System.IO;
using System.Media;

namespace CyberSecurityChatbot
{
    public class VoiceGreeting
    {
        //This class handels the playing of the audio
        public static void PlayGreeting()
        {
            try
            {
                //Builds the full path to the audio file 
                string path = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Audio",
                    "greeting.wav" //Makes sure file exists in Audio folder
                );

                //Sound player object
                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync(); // waits for audio to finish
            }


            catch (Exception ex)
            {
                //Displays error message if audio fails
                Console.WriteLine("Error playing audio: " + ex.Message);
            }
        }
    }
}
