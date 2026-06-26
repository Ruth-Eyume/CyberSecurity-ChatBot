using System;
using System.Collections.Generic;
using CyberBotGUI.Models;

namespace CyberBotGUI.Services
{
    public class ChatbotService
    {
        // DELEGATE

        public delegate string ResponseFormatter(string message);

        public string FormatResponse(string message)
        {
            return "BOT: " + message;
        }

        // MEMORY

        private string lastTopic = "";

        private string rememberedInterest = "";

        private Random rng = new Random();

        // MAIN RESPONSES

        private Dictionary<string, string> responses =
            new Dictionary<string, string>()
            {
                ["password"] =
            "Passwords protect your online accounts from hackers. Strong passwords should contain uppercase letters, lowercase letters, numbers, and symbols.",

                ["phishing"] =
            "Phishing is a cyberattack where scammers pretend to be trusted organisations to steal sensitive information.",

                ["malware"] =
            "Malware is harmful software designed to damage devices, spy on users, or steal important information.",

                ["safe browsing"] =
            "Safe browsing means using the internet carefully by avoiding suspicious websites, links, and downloads.",

                ["wifi"] =
            "Public WiFi can be dangerous because hackers may intercept your internet traffic and steal sensitive information."
            };

        //  RANDOM RESPONSES
       
        private Dictionary<string, List<string>> detailedResponses =
            new Dictionary<string, List<string>>()
            {
                ["password"] = new List<string>()
            {
                "Weak passwords are easy for hackers to guess. Passwords like '123456' are unsafe.",
                "A strong password should be long, unique, and difficult to guess.",
                "Password managers can help create and store secure passwords safely."
            },

                ["phishing"] = new List<string>()
            {
                "Phishing emails often pretend to come from banks or trusted companies.",
                "Scammers use urgent messages to pressure victims into clicking dangerous links.",
                "Always check email addresses carefully before clicking links."
            },

                ["malware"] = new List<string>()
            {
                "Malware includes viruses, ransomware, trojans, and spyware.",
                "Ransomware can lock files until money is paid to hackers.",
                "Spyware secretly monitors users and steals personal information."
            },

                ["safe browsing"] = new List<string>()
            {
                "Always check for HTTPS websites before entering passwords.",
                "Avoid downloading files from suspicious websites.",
                "Fake websites may secretly install malware on devices."
            },

                ["wifi"] = new List<string>()
            {
                "Hackers on public WiFi may spy on internet traffic.",
                "Avoid online banking when using public WiFi.",
                "Only connect to trusted wireless networks."
            }
            };

        // EXTRA RANDOM TIPS

        private Dictionary<string, List<string>> extraTips =
            new Dictionary<string, List<string>>()
            {
                ["password"] = new List<string>()
            {
                "Use different passwords for every account.",
                "Enable password recovery options.",
                "Never share passwords with others."
            },

                ["phishing"] = new List<string>()
            {
                "Never click suspicious links.",
                "Banks never ask for passwords by email.",
                "Delete suspicious emails immediately."
            },

                ["malware"] = new List<string>()
            {
                "Keep antivirus software updated.",
                "Update Windows regularly.",
                "Avoid downloading cracked software."
            },

                ["safe browsing"] = new List<string>()
            {
                "Avoid suspicious pop-up ads.",
                "Only download software from trusted websites.",
                "Keep browsers updated for security."
            },

                ["wifi"] = new List<string>()
            {
                "Disable auto-connect for public WiFi.",
                "Use strong WiFi passwords at home.",
                "Avoid entering sensitive data on public networks."
            }
            };

        // SENTIMENTS

        private List<Sentiments> sentiments =
    new List<Sentiments>()
{
    new Sentiments(
        "worried",
        "Do not worry, I am here to help you stay safe online. "
    ),

    new Sentiments(
        "scared",
        "Do not be scared. with my help, you'll have all the knowledge you need to stay safe online. "
    ),

    new Sentiments(
        "frustrated",
        "I understand your frustration.Cybersecurity can feel overwhelming, but learning safe habits helps protect you online. "
    ),

    new Sentiments(
        "nervous",
        "It is completely normal to feel nervous about online safety. "
    ),

    new Sentiments(
        "confused",
        "I understand the confusion. Let me explain it step-by-step. "
    ),

    new Sentiments(
        "curious",
        "That is a great question. "
    )
};
    
        // MAIN CHATBOT METHOD

        public string GetResponse(string input, User user)
        {
            ResponseFormatter formatter = FormatResponse;

            if (string.IsNullOrWhiteSpace(input))
            {
                return formatter(
                    "Please type a message.");
            }

            input = input.ToLower();

            // EXIT

            if (input.Contains("exit") ||
                input.Contains("bye") ||
                input.Contains("quit"))
            {
                return formatter(
                    $"Goodbye {user.Name}. Stay safe online!");
            }

            // USER INTEREST MEMORY
        
            if (input.Contains("i like"))
            {
                rememberedInterest =
                    input.Replace("i like", "").Trim();

                return formatter(
                    $"I will remember that you are interested in {rememberedInterest}.");
            }

            // SENTIMENT DETECTION

            foreach (var sentiment in sentiments)
            {
                if (input.Contains(sentiment.Emotion))
                {
                    // If user also asked cybersecurity topic
                    foreach (var item in responses)
                    {
                        if (input.Contains(item.Key))
                        {
                            lastTopic = item.Key;

                            return formatter(
                                sentiment.Response +
                                item.Value);
                        }
                    }
                    
                    // Only sentiment
                    return formatter(
                        sentiment.Response +
                        "");
                }
            }

            // FOLLOW-UP FLOW

            if (input.Contains("tell me more") ||
                input.Contains("explain") ||
                input.Contains("explain more") ||
                input.Contains("explain further") ||
                input.Contains("example") ||
                input.Contains("i dont understand") ||
                input.Contains("i don't understand") ||
                input.Contains("more details"))
            {
                if (!string.IsNullOrEmpty(lastTopic))
                {
                    if (detailedResponses.ContainsKey(lastTopic))
                    {
                        List<string> explanations =
                            detailedResponses[lastTopic];

                        string randomExplanation =
                            explanations[rng.Next(explanations.Count)];

                        // EXTRA DETAIL WHEN USER IS CONFUSED

                        if (input.Contains("i dont understand") ||
                            input.Contains("i don't understand"))
                        {
                            return formatter(
                                "Let me simplify it for you. " +
                                randomExplanation);
                        }

                        // EXTRA DETAIL WHEN USER SAYS EXPLAIN

                        if (input.Contains("explain"))
                        {
                            return formatter(
                                "Here is a more detailed explanation. " +
                                randomExplanation);
                        }

                        // NORMAL FOLLOW-UP

                        return formatter(randomExplanation);
                    }
                }

                return formatter(
                    "Please ask about a cybersecurity topic first.");
            }

            // RANDOM TIPS

            if (input.Contains("another tip") ||
                input.Contains("more tips") ||
                input.Contains("give me tips") ||
                input.Contains("tips"))
            {
                if (!string.IsNullOrEmpty(lastTopic))
                {
                    if (extraTips.ContainsKey(lastTopic))
                    {
                        List<string> tips =
                            extraTips[lastTopic];

                        return formatter(
                            tips[rng.Next(tips.Count)]);
                    }
                }

                return formatter(
                    "Please ask about a cybersecurity topic first.");
            }

 
            // MAIN TOPICS

            foreach (var item in responses)
            {
                if (input.Contains(item.Key))
                {
                    lastTopic = item.Key;

                    return formatter(item.Value);
                }
            }

            // UNKNOWN INPUT

            return formatter(
                "I did not understand that. Try asking about phishing, malware, passwords, safe browsing, or WiFi.");
        }
        public string DetectIntent(string input)
        {
            input = input.ToLower();

            // TASK INTENT
            if (input.Contains("task") ||
                input.Contains("add") && input.Contains("remind") ||
                input.Contains("create reminder") ||
                input.Contains("set reminder") ||
                input.Contains("remember to"))
            {
                return "task";
            }

            // QUIZ INTENT
            if (input.Contains("quiz") ||
                input.Contains("test me") ||
                input.Contains("question me") ||
                input.Contains("game"))
            {
                return "quiz";
            }

            // PHISHING / SECURITY HELP
            if (input.Contains("phishing") ||
                input.Contains("safe") ||
                input.Contains("password") ||
                input.Contains("hack") ||
                input.Contains("malware"))
            {
                return "security";
            }

            return "general";
        }
    }
}