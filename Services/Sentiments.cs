namespace CyberBotGUI.Services
{
    public class Sentiments
    {
        public string Emotion { get; set; }

        public string Response { get; set; }

        public Sentiments(string emotion, string response)
        {
            Emotion = emotion;
            Response = response;
        }
    }
}