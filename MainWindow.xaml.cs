using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using CyberBotGUI.Models;
using CyberBotGUI.Services;

namespace CyberBotGUI
{
    public partial class MainWindow : Window
    {
        private ChatbotService chatbot =
            new ChatbotService();

        private DatabaseService database =
            new DatabaseService();

        private ActivityLogger logger =
            new ActivityLogger();

        private User currentUser =
            new User();

        private bool nameCaptured = false;

        private QuizService quizService = new QuizService();
        private List<QuizQuestion> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;

        public MainWindow()
        {
            InitializeComponent();

            VoiceGreeting.PlayGreeting();
            logger.Log("Application Started");

            txtChat.AppendText(
                "🤖 BOT: Welcome to CyberShield! Please enter your name.\n");
        }

        private void BtnSend_Click(
            object sender,
            RoutedEventArgs e)
        {
            string userInput =
                txtUserInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
                return;

            txtChat.AppendText(
               $"👤 YOU: {userInput}\n");

            // FIRST INPUT = USER NAME
            if (!nameCaptured)
            {
                currentUser.Name = userInput;
                logger.Log("User entered name: " + currentUser.Name);

                nameCaptured = true;

                txtChat.AppendText(
    $"🤖 BOT: {"Im here to hepl you, ask me anything about cybersecurity"}\n");

                txtUserInput.Clear();
                txtChat.ScrollToEnd();
                return;
            }

            // CHATBOT RESPONSE
            string intent = chatbot.DetectIntent(userInput);
            string response = chatbot.GetResponse(userInput, currentUser);

            logger.Log("User asked: " + userInput);

            // NLP ACTION TRIGGERS

            if (intent == "task" && userInput.Contains("add"))
            {
                BtnAddTask_Click(sender, e);
                return;
            }

            if (intent == "quiz")
            {
                BtnQuiz_Click(sender, e);
                return;
            }

            // QUIZ ANSWER HANDLING
            if (questions != null && currentQuestionIndex < questions.Count)
            {
                var q = questions[currentQuestionIndex];

                if (userInput.Equals("A", System.StringComparison.OrdinalIgnoreCase) ||
                    userInput.Equals("B", System.StringComparison.OrdinalIgnoreCase) ||
                    userInput.Equals("C", System.StringComparison.OrdinalIgnoreCase) ||
                    userInput.Equals("D", System.StringComparison.OrdinalIgnoreCase))
                {
                    if (userInput.ToUpper() == q.CorrectAnswer)
                    {
                        score++;
                        txtChat.AppendText("BOT: Correct! " + q.Explanation + "\n");
                    }
                    else
                    {
                        txtChat.AppendText("BOT: Incorrect. " + q.Explanation + "\n");
                    }

                    currentQuestionIndex++;
                    ShowQuestion();

                    txtUserInput.Clear();
                    txtChat.ScrollToEnd();
                    return;
                }
            }

            txtChat.AppendText(response + "\n");
            txtChat.ScrollToEnd();

            txtUserInput.Clear();
        }

        private void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnSend_Click(sender, e);
            }
        }

        // SHOW QUIZ QUESTION
        private void ShowQuestion()
        {
            if (currentQuestionIndex >= questions.Count)
            {
                txtChat.AppendText(
                    $"\n🤖 BOT: Quiz finished! Your score: {score}/{questions.Count}\n");

                if (score >= 4)
                    txtChat.AppendText("Great job! You're a cybersecurity pro!\n");
                else
                    txtChat.AppendText("Keep learning to stay safe online!\n");

                logger.Log($"Quiz finished. Score: {score}");
                return;
            }

            var q = questions[currentQuestionIndex];

            txtChat.AppendText($"\nQ{currentQuestionIndex + 1}: {q.Question}\n");
            txtChat.AppendText($"A) {q.OptionA}\n");
            txtChat.AppendText($"B) {q.OptionB}\n");
            txtChat.AppendText($"C) {q.OptionC}\n");
            txtChat.AppendText($"D) {q.OptionD}\n");

            txtChat.ScrollToEnd();
        }

        // ADD TASK
        private void BtnAddTask_Click(object sender, RoutedEventArgs e)
        {
            TaskWindow window = new TaskWindow();
            window.Owner = this;

            bool? result = window.ShowDialog();

            if (result == true)
            {
                var task = window.Task;

                database.AddTask(task);

                txtChat.AppendText(
                    "🤖 BOT: Task added successfully ✔\n");

                txtChat.ScrollToEnd();

                logger.Log("Task added: " + task.Title);
            }
        }

        // VIEW TASKS
        private void BtnViewTasks_Click(object sender, RoutedEventArgs e)
        {
            var tasks = database.GetTasks();

            txtChat.AppendText("\n🤖 BOT: Your Tasks:\n");

            foreach (var t in tasks)
            {
                txtChat.AppendText(
                    $"- {t.Title} | {(t.IsCompleted ? "Completed" : "Pending")}\n");
            }

            logger.Log("Viewed tasks");
            txtChat.ScrollToEnd();
        }

        // START QUIZ
        private void BtnQuiz_Click(object sender, RoutedEventArgs e)
        {
            questions = quizService.GetQuestions();
            currentQuestionIndex = 0;
            score = 0;

            ShowQuestion();

            logger.Log("Quiz started");
        }

        // ACTIVITY LOG
        private void BtnActivity_Click(object sender, RoutedEventArgs e)
        {
            ActivityLogWindow window =
                new ActivityLogWindow(logger);

            window.Owner = this;
            window.ShowDialog();
        }
        

        // CLEAR CHAT
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtChat.Document.Blocks.Clear();
        }
    }
}