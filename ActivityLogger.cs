using System;
using System.Collections.Generic;

namespace CyberBotGUI.Services
{
    public class ActivityLogger
    {
        private List<string> activities = new List<string>();

        public void Log(string activity)
        {
            activities.Add(
                $"{DateTime.Now:HH:mm:ss} - {activity}");
        }

        public List<string> GetActivities()
        {
            return activities;
        }

        public void Clear()
        {
            activities.Clear();
        }
    }
}