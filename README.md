# CyberSecurity-ChatBot
#ProgrammingPOE(Part1)
## Description:
The Cybersecurity ChatBot ia a C# console application, designed to give users awareness and educate them about Basic cybersecurity practices. 

## Features:
- Audio greeting played on launch
- ASCII art logo displayed on launch
- Personalised greeting using the user's name
- Responses to cybersecurity topics including:
  - Password safety, Phishing etc.
- Input validation for empty or unrecognised inputs
- Coloured console text for improved readability
- Clean code structure using multiple classes

## Technologies Used:
C#
.NET Console Application

## How to Use:

1. The chatbot launches and displays the ASCII logo
2. Enter your name when prompted
3. Type any of the following to get a response:
   - `password` - get password safety tips
   - `phishing` - learn about phishing attacks
   - `browsing` or `safe` - get safe browsing advice
   - `how are you` - general conversation
   - `what can I ask` - see available topics
4. Type `exit` to quit the chatbot



## Example Interaction:
Bot: Hello! Please enter your name
You: Ruth
Bot: Hello Ruth, Welcome to CyberShield! 
Bot: You can ask me about: passwords, phishing, safe browsing, etc.

You: Phishing
Bot: Phishing is a cyber attack where scammers trick you into giving away sensitive information like passwords, bank details, or personal data by pretending to be a trusted source.

You: exit
Bot: Goodbye,Thank you for using CyberShield! Stay safe online!

## Commit History:
This project was developed with a minimum of five meaningful commits:

1. Initial commit: Set up project structure with its different classes
2. Added ASCII logo and display class
3. Added comments for better understanding
4. Added an audio file with the neccessary extentions installed
5. Enhanced cybersecurity response system

##CI Workflow successful build
<img width="960" height="504" alt="image" src="https://github.com/user-attachments/assets/e6ef0c0c-fca3-4034-8d36-32e676e13d89" />

## PART 3:
## CyberShield Cybersecurity Awareness Chatbot
The system is built using C#, XAML (WPF), and SQL Server Management Studio.

## 🚀 Features
💬 Chatbot System
Responds to cybersecurity questions
Uses keyword detection (phishing, malware, passwords, etc.)
Includes sentiment detection (worried, confused, scared, etc.)
## 🧠 NLP Simulation
Recognises different user phrasings
Uses string matching for intent detection
Supports flexible user input interpretation
## 📋 Task Management System
Add cybersecurity tasks
Store tasks in SQL Server database
View all tasks
Mark tasks as completed
Delete tasks

Database used: SQL Server (SSMS)

## 🎮 Cybersecurity Quiz
Multiple-choice questions
Immediate feedback after each answer
Score tracking system
Final performance message
## 📜 Activity Log
Records all system actions
Tracks user interactions
Displays log history in a separate window
🛠️ Technologies Used
C# (.NET WPF)
XAML (UI Design)
SQL Server Management Studio (Database)
Microsoft.Data.SqlClient
Object-Oriented Programming (OOP)
## Project Structure
CyberBotGUI
│
├── Models
│   ├── User.cs
│   ├── TaskModel.cs
│   ├── QuizQuestion.cs
│   └── Sentiments.cs
│
├── Services
│   ├── ChatbotService.cs
│   ├── DatabaseService.cs
│   ├── QuizService.cs
│   ├── ActivityLogger.cs
│   └── VoiceGreeting.cs
│
├── Windows
│   ├── MainWindow.xaml
│   ├── TaskWindow.xaml
│   └── ActivityLogWindow.xaml
│
└── Database (SQL Server)
    └── CyberShieldDB
        └── Tasks Table
## 🗄️ Database Setup

Run the following SQL script in SSMS:

CREATE DATABASE CyberShieldDB;

USE CyberShieldDB;

CREATE TABLE Tasks
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100),
    Description NVARCHAR(255),
    ReminderDate DATE,
    IsCompleted BIT DEFAULT 0
);
▶️ How to Run
Open solution in Visual Studio
Ensure SQL Server is running
Update connection string if needed
Build solution
Run application (F5)

## Learning Outcomes
This project demonstrates:
GUI development using WPF
Database integration using SQL Server
Event-driven programming
Basic NLP simulation techniques
Object-oriented design principles


Ruth Eyume Ngamwanya
Cybersecurity Awareness Chatbot Project-Part 3



