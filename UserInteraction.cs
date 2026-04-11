using System;

//This class controls the chatbot conversation
class UserInteraction
{
    public static void StartChat(User user)
    {
        //Infinite loop to keep the chat running
        while (true)
        {
            //Display "You:" in red
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\nYOU: ");
            Console.ResetColor();


            //Reads user input safely
            string input = Console.ReadLine() ?? ""; //  prevents crash

            //Checks if input is empty
            if (string.IsNullOrWhiteSpace(input))
            {
              
                Console.WriteLine("Bot: Please enter you query");
                continue;
            }

            //Convert input to lowercase for easier matching
            input = input.ToLower();

            //Exit conditions
            if (input.Contains("exit") || input.Contains("quit") || input.Contains("bye"))
            {
                Console.WriteLine($"Bot: Goodbye {user.Name}. Thank you for using CyberShiel! Stay safe online.");//Exit message
                break;
            }
            else if (input.Contains("How are you?"))//Response to greeting
            {
                Console.WriteLine($"Bot: I'm doing great {user.Name}! Ready to help with cybersecurity questions.");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("Bot: I am you AI partner in learning and staying protected online" +
                    "\nMy purpose is to educate users about cybersecurity awareness.");
            }
            //Password advice
            else if (input.Contains("password") || input.Contains("pass"))
            {
                Console.WriteLine("Bot: 1. Use strong passwords with uppercase, lowercase, numbers, and symbols.\n" +
                    "2. Use long passwords (12+ characters) or easy-to-remember passphrases\r\n•" +
                    "3. Don’t reuse passwords across accounts\r\n" +
                    "4. Avoid personal info (names, birthdays, simple patterns)\r\n" +
                    "5. Change passwords only if there’s a security risk");
            }
            //Phishing explained
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing is a cyber attack where scammers trick you into giving away sensitive information like " +
                    "passwords, bank details, or personal data by pretending to be a trusted source or through fake emails or websites.");
            }
            //Safe browsing tips
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Bot: Browse safely by using secure sites, avoiding suspicious links, and keeping your device updated and protected." +
                    "\n Always check the website URL ");
            }
            //Malware expalined
            else if (input.Contains("malware"))
            {
                Console.WriteLine("Bot: Malware is short for 'malicious software'. It refers to any program designed to harm, exploit, or take control of a device without the user's permission.");
            }

            //Wifi safety
            else if (input.Contains("wifi") || input.Contains("wi-fi"))
            {
                Console.WriteLine("Bot: 1. Use strong passwords for your WiFi network\r\n" +
                    "2. Avoid using public WiFi for banking or sensitive data\r\n" +
                    "3. Connect only to trusted networks\r\n" +
                    "4. Turn off auto-connect on your device\r\n" +
                    "5. Use a VPN on public WiFi\r\n" +
                    "6. Keep your router software updated");
            }
          
            else if (input.Contains("vpn"))
            {
                Console.WriteLine("Bot: A VPN encrypts your internet connection and protects your privacy online.");
            }
            else if (input.Contains("2fa") || input.Contains("two factor"))
            {
                Console.WriteLine("Bot: Two-Factor Authentication adds an extra layer of security.");
            }
            //Help command
            else if (input.Contains("help"))
            {
                Console.WriteLine("Bot: You can ask me about passwords, phishing, malware, safe browsing, VPNs, and more!");
            }
            //Defult response if input is not understood
            else
            {
                Console.WriteLine($"Bot: I'm not sure I understand, {user.Name}. Try asking about cybersecurity topics.");
            }
        }
    }
}
