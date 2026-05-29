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

# CyberShield – Cybersecurity Awareness Chatbot (Part 2)

## Description
Part 2 expands on the console-based chatbot from Part 1 by introducing a modern GUI, dynamic responses, memory and recall, sentiment detection, and improved conversation flow.

## Features Implemented:
### Graphical User Interface (WPF)
* Converted the chatbot from a console application to a WPF application.
* Added a custom CyberShield header and logo.
* Designed a user-friendly interface using shades of pink and grey.
* Implemented a chat display area and message input section.

### Random Responses
* Implemented Lists and Random objects to provide varied responses.
* Prevents repetitive conversations.
* Generates different explanations and tips for the same topic.

### Conversation Flow
* The chatbot remembers the last topic discussed.
* Supports follow-up questions such as:
  * Tell me more
  * Explain
  * Explain further
  * I don't understand
  * Another tip

### Memory and Recall

* Stores the user's name.
* Stores user interests.
* Uses stored information to personalise responses.

### Sentiment Detection
The chatbot detects user emotions such as:
* Worried
* Scared
* Frustrated
* Nervous
* Confused
The chatbot responds with supportive and empathetic messages before continuing the cybersecurity discussion.
### Delegates
* Implemented a delegate to standardise and format chatbot responses.
* Demonstrates advanced C# programming concepts.
### Error Handling
* Handles empty user input.
* Handles unknown keywords gracefully.
* Prevents application crashes from invalid input.
### Collections Used
* Dictionary
* List
* Random
These collections improve code organisation and efficiency.
## Project Structure:
### Models
Contains classes used for storing application data.
* User.cs
### Services
Contains the chatbot logic and functionality.
* ChatbotService.cs
* VoiceGreeting.cs
* Sentiment.cs
### Assets
Contains multimedia resources.
* greeting.wav
* logo.png
* 
## Commit History
1.Created WPF project structure and GUI layout.
2.Added chatbot interface and migrated Part 1 functionality.
3.Implemented keyword recognition and cybersecurity topic responses.
4.Added random responses, conversation flow, and topic memory.
5.Implemented sentiment detection and personalised responses.
6.Enhanced GUI design, logo integration, Enter key functionality, and final testing.

## Technologies Used
* C#
* .NET
* WPF (Windows Presentation Foundation)



















