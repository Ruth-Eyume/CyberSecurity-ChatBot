using CyberSecurityChatbot;
using System;

class Program
{
    static void Main()
    {
        Console.Title = "Cybersecurity Awareness Bot";

        ConsoleUI.DisplayLogo();
        VoiceGreeting.PlayGreeting();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nEnter your name: ");
        Console.ResetColor();

        string nameInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nameInput))
        {
            nameInput = "User";
        }

        User user = new User { Name = nameInput };

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nHello {user.Name}! Welcome to the Cybersecurity Awareness Bot.");
        Console.WriteLine("You can ask me questions about ANYTHING CYBER:");
        Console.WriteLine("1. Password safety");
        Console.WriteLine("2. Phishing");
        Console.WriteLine("3. Safe browsing");
        Console.WriteLine("4. Malware");
        Console.WriteLine("5. Public WiFi");

        Console.WriteLine("Type 'exit' to close the chatbot.");

        UserInteraction.StartChat(user);
    }
}
