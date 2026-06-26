using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CyberBotGUI.Models;

namespace CyberBotGUI.Services
{
    public class DatabaseService
    {
        private readonly string connectionString =
            @"Server=RUTHZBOOK\SQLEXPRESS;
              Database=CyberShieldDB;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        // Add Task
        public void AddTask(TaskModel task)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"INSERT INTO Tasks
                (Title, Description, ReminderDate, IsCompleted)
                VALUES
                (@Title,@Description,@ReminderDate,@IsCompleted)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Title", task.Title);
                cmd.Parameters.AddWithValue("@Description", task.Description);

                if (task.ReminderDate == null)
                    cmd.Parameters.AddWithValue("@ReminderDate", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@ReminderDate", task.ReminderDate);

                cmd.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);

                cmd.ExecuteNonQuery();
            }
        }

        // View Tasks
        public List<TaskModel> GetTasks()
        {
            List<TaskModel> tasks = new List<TaskModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Tasks";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tasks.Add(new TaskModel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Title = reader["Title"].ToString(),
                        Description = reader["Description"].ToString(),
                        ReminderDate = reader["ReminderDate"] == DBNull.Value
                            ? null
                            : Convert.ToDateTime(reader["ReminderDate"]),
                        IsCompleted = Convert.ToBoolean(reader["IsCompleted"])
                    });
                }
            }

            return tasks;
        }

        // Delete Task
        public void DeleteTask(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Tasks WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }

        // Mark Complete
        public void CompleteTask(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    "UPDATE Tasks SET IsCompleted=1 WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}