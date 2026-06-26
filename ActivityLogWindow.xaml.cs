using System.Windows;
using CyberBotGUI.Services;

namespace CyberBotGUI
{
    public partial class ActivityLogWindow : Window
    {
        private ActivityLogger logger;

        public ActivityLogWindow(ActivityLogger log)
        {
            InitializeComponent();
            logger = log;

            LoadLogs();
        }

        private void LoadLogs()
        {
            lstLog.Items.Clear();

            foreach (var item in logger.GetActivities())
            {
                lstLog.Items.Add(item);
            }
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            LoadLogs();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}