using System;
using System.Windows;
using CyberBotGUI.Models;

namespace CyberBotGUI
{
    public partial class TaskWindow : Window
    {
        public TaskModel Task { get; private set; }

        public TaskWindow()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Task = new TaskModel
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                ReminderDate = dpReminder.SelectedDate,
                IsCompleted = false
            };

            DialogResult = true;
        }
    }
}