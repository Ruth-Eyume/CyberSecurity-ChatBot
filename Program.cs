using CyberSecurityChatbot;
using System;

//Main class
class Program
{
    static void Main()
    {
        //Set console title
        Console.Title = "Cybersecurity Awareness Bot";

        
        ConsoleUI.DisplayLogo();//Displays the logo
        VoiceGreeting.PlayGreeting();//Plays greeting audio

        //Prompts user to enter their name
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nEnter your name: ");
        Console.ResetColor();

        string nameInput = Console.ReadLine();

        //if user enters nothing, defult to "User"
        if (string.IsNullOrWhiteSpace(nameInput))
        {
            nameInput = "User";
        }

        //create a User object
        User user = new User { Name = nameInput };


        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nHello {user.Name}! Welcome to CyberShield.");
        Console.WriteLine("You can ask me questions about anything CYBERSECURITY:");
        Console.WriteLine("1. Password safety");
        Console.WriteLine("2. Phishing");
        Console.WriteLine("3. Safe browsing");
        Console.WriteLine("4. Malware");
        Console.WriteLine("5. Public WiFi");

        Console.WriteLine("Type 'exit' to close the chatbot.");

        //Start the chatbot
        UserInteraction.StartChat(user);
    }
}
