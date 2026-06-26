using System.Collections.Generic;
using CyberBotGUI.Models;

namespace CyberBotGUI.Services
{
    public class QuizService
    {
        public List<QuizQuestion> GetQuestions()
        {
            return new List<QuizQuestion>
            {
                new QuizQuestion
                {
                    Question = "What is phishing?",
                    OptionA = "A fishing sport",
                    OptionB = "A cyber attack using fake emails",
                    OptionC = "A virus scanner",
                    OptionD = "A firewall",
                    CorrectAnswer = "B",
                    Explanation = "Phishing tricks users into giving personal information."
                },

                new QuizQuestion
                {
                    Question = "What makes a strong password?",
                    OptionA = "Your name",
                    OptionB = "123456",
                    OptionC = "Mix of letters, numbers, symbols",
                    OptionD = "Your birthday",
                    CorrectAnswer = "C",
                    Explanation = "Strong passwords use complexity and uniqueness."
                },

                new QuizQuestion
                {
                    Question = "What should you do with suspicious emails?",
                    OptionA = "Open them",
                    OptionB = "Reply immediately",
                    OptionC = "Report and delete",
                    OptionD = "Forward to friends",
                    CorrectAnswer = "C",
                    Explanation = "Always report phishing attempts."
                },

                new QuizQuestion
                {
                    Question = "Public WiFi is:",
                    OptionA = "Always safe",
                    OptionB = "Sometimes dangerous",
                    OptionC = "Encrypted always",
                    OptionD = "Faster",
                    CorrectAnswer = "B",
                    Explanation = "Hackers can intercept data on public WiFi."
                },

                new QuizQuestion
                {
                    Question = "What is malware?",
                    OptionA = "Helpful software",
                    OptionB = "Security tool",
                    OptionC = "Malicious software",
                    OptionD = "Browser extension",
                    CorrectAnswer = "C",
                    Explanation = "Malware harms or steals data."
                }
            };
        }
    }
}