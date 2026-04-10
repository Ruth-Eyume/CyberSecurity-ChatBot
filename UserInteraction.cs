using System;

class UserInteraction
{
    public static void StartChat(User user)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nYou: ");
            Console.ResetColor();

            string input = Console.ReadLine() ?? ""; //  prevents crash

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Bot: Please type a question.");
                continue;
            }

            input = input.ToLower();

            if (input.Contains("exit") || input.Contains("quit") || input.Contains("bye"))
            {
                Console.WriteLine($"Bot: Goodbye {user.Name}! Stay safe online.");
                break;
            }
            else if (input.Contains("how are you"))
            {
                Console.WriteLine($"Bot: I'm doing great {user.Name}! Ready to help with cybersecurity questions.");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("Bot: My purpose is to educate users about cybersecurity awareness.");
            }
            else if (input.Contains("password") || input.Contains("pass"))
            {
                Console.WriteLine("Bot: Use strong passwords with uppercase, lowercase, numbers, and symbols.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing is a scam where attackers trick you into revealing personal information through fake emails or websites.");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Bot: Always check the website URL and avoid clicking suspicious links.");
            }
            else if (input.Contains("malware"))
            {
                Console.WriteLine("Bot: Malware is short for 'malicious software'. It refers to any program designed to harm, exploit, or take control of a device without the user's permission.");
            }
            else if (input.Contains("wifi") || input.Contains("wi-fi"))
            {
                Console.WriteLine("Bot: Public WiFi can be unsafe. Avoid accessing sensitive accounts on public networks.");
            }

            // ✅ SMALL DISTINCTION ADDITIONS
            else if (input.Contains("vpn"))
            {
                Console.WriteLine("Bot: A VPN encrypts your internet connection and protects your privacy online.");
            }
            else if (input.Contains("2fa") || input.Contains("two factor"))
            {
                Console.WriteLine("Bot: Two-Factor Authentication adds an extra layer of security.");
            }
            else if (input.Contains("help"))
            {
                Console.WriteLine("Bot: You can ask me about passwords, phishing, malware, safe browsing, VPNs, and more!");
            }
            else
            {
                Console.WriteLine($"Bot: I'm not sure I understand, {user.Name}. Try asking about cybersecurity topics.");
            }
        }
    }
}
