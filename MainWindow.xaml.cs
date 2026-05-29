using System.Windows;
using System.Windows.Input;
using CyberBotGUI.Models;
using CyberBotGUI.Services;


namespace CyberBotGUI
{
    public partial class MainWindow : Window
    {
        private ChatbotService chatbot =
            new ChatbotService();

        private User currentUser =
            new User();

        private bool nameCaptured = false;

        public MainWindow()
        {
            InitializeComponent();

            VoiceGreeting.PlayGreeting();

            txtChat.AppendText(
                "BOT: Welcome to CyberShield! Please enter your name.\n");

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
                "YOU: " + userInput + "\n");

            // FIRST INPUT = USER NAME

            if (!nameCaptured)
            {
                currentUser.Name = userInput;

                nameCaptured = true;

                txtChat.AppendText(
                    $"BOT: Hello {currentUser.Name}! Im here to help you, ask me anything about CyberSecurity\n");

                txtUserInput.Clear();

                txtChat.ScrollToEnd();

                return;
            }

            // CHATBOT RESPONSE

            string response =
                chatbot.GetResponse(
                    userInput,
                    currentUser);

            txtChat.AppendText(
                response + "\n");

            txtChat.ScrollToEnd();

            txtUserInput.Clear();
        }

        // PRESS ENTER TO SEND MESSAGE

        private void txtUserInput_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnSend_Click(sender, e);
            }
        }
    }
}