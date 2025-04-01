

using System;
using System.Collections;

namespace Chatbot
{
    // Main class for chatbot functionality
    public class chat_responder
    {
        // Variables to store user's name and query globally
        private string username = string.Empty; // Stores the user's name
        private string userQuery = string.Empty; // Stores the user's input/questions

        private ArrayList replies = new ArrayList(); // List to store chatbot replies

        // Constructor
        public chat_responder()
        {
            // Call methods to initialize replies
            StoreReplies();

            // Display welcome message
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("   "); // Spacer for formatting

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Hi! I'm CHATBOT, here to assist, chat, and explore with you. Let's get started.");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ............................................................................................ ");
            Console.ResetColor();

            // Ask for the user's name
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Chatbot:");
            Console.ForegroundColor = ConsoleColor.Gray;//the text question will be in grey 
            Console.WriteLine("heyy,what is your first name?");

            // Capture the user's name
            Console.ForegroundColor = ConsoleColor.Magenta; // User's input color
            Console.Write("You:");
            username = Console.ReadLine(); // Store the user's name



            // Begin conversation loop
            // Initial chatbot prompt outside the loop
            Console.ForegroundColor = ConsoleColor.Gray; // Set chatbot prompt color
            Console.WriteLine("Chatbot: Hey " + username + ", how can I assist you today? Let's explore together! Ask me anything about cybersecurity!");

            // Begin conversation loop
            do
            {
                // Capture user's query on a separate line
                Console.ForegroundColor = ConsoleColor.Magenta; // Set user input color
                Console.Write(username + ": ");
                userQuery = Console.ReadLine(); // Read and store user's input

                // Process the user's question or query
                if (userQuery.ToLower() != "exit") // Only process if the input is not "exit"
                {
                    ProcessQuery(userQuery);
                }

            } while (userQuery.ToLower() != "exit"); // Exit loop when user types "exit"

            // Final message after exit
            Console.ForegroundColor = ConsoleColor.Yellow; // Set color for the final message
            Console.WriteLine("Bye for now! Don't hesitate to reach out again, " + username + "! Have a great day ahead!");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ............................................................................................ ");
            Console.ResetColor(); // Reset colors to default
        }
           /* do
            {
                // Chatbot prompt
                Console.ForegroundColor = ConsoleColor.Gray; // Set chatbot prompt color
                Console.WriteLine("Chatbot: Hey " + username + ", how can I assist you today? Let's explore together! Ask me anything about cybersecurity!");

                // Capture user's query on a separate line
               Console.ForegroundColor = ConsoleColor.Magenta; // Set user input color
               Console.Write(username + ": ");
                userQuery = Console.ReadLine(); // Read and store user's input

                // Process the user's question or query
            if (userQuery.ToLower() != "exit") // Only process if the input is not "exit"
                {
                    ProcessQuery(userQuery);
                }

            } while (userQuery.ToLower() != "exit"); // Exit loop when user types "exit"

            // Final message after exit
            Console.ForegroundColor = ConsoleColor.Yellow; // Set color for the final message
            Console.WriteLine("Bye for now! Don't hesitate to reach out again, " + username + "! Have a great day ahead!");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ............................................................................................ ");
            Console.ResetColor(); // Reset colors to default
        }*/
            // Method to store predefined replies
        private void StoreReplies()
        {
            replies.Add("A password is a secure string of characters that serves as authentication to verify a user's identity.");
            replies.Add("A strong password includes a combination of uppercase letters, lowercase letters, numbers, and special characters.");
            replies.Add("It is important to use unique passwords for each account to reduce the risk of security breaches.");
            replies.Add("Using passphrases (long phrases with multiple words) can make your passwords both secure and easy to remember.");
            replies.Add("Avoid using personal information like your name or birthdate in passwords, as they are easy to guess.");
            replies.Add("Phishing is a fraudulent attempt to obtain sensitive information by pretending to be a trustworthy entity.");
            replies.Add("Phishing emails often use urgent language, generic greetings, or fake links to trick victims.");
            replies.Add("To avoid phishing scams, always verify the sender's email address and avoid clicking on suspicious links.");
            replies.Add("Attackers may use smishing (phishing via text messages) to trick victims into sharing personal information.");
            replies.Add("Anti-phishing tools and browser extensions can help identify and block phishing attempts online.");
            replies.Add("Safe browsing refers to practices that protect users from online threats like malware and phishing.");
            replies.Add("Always check for HTTPS in a website's URL to ensure your connection is secure.");
            replies.Add("Using strong antivirus software can help detect and block malicious websites and downloads.");
            replies.Add("Avoid accessing sensitive accounts or entering credentials on public Wi-Fi networks.");
            replies.Add("Enable browser security features, such as pop-up blockers and privacy settings, for safer browsing.");
            replies.Add("Cybersecurity is the practice of protecting systems, networks, and data from digital attacks.");
            replies.Add("Data breaches can occur if personal or sensitive information is not adequately protected.");
            replies.Add("Keeping your software and operating systems updated helps defend against newly discovered vulnerabilities.");
            replies.Add("Implementing multi-factor authentication adds an extra layer of security to your accounts.");
            replies.Add("Social engineering attacks trick people into revealing sensitive information by exploiting human trust.");


        }

        // Method to process and respond to the user's query
        private void ProcessQuery(string query)
        {
            bool answered = false;

            // Search for matching responses
            foreach (string reply in replies)
            {
                if (query.ToLower().Contains("password") && reply.ToLower().Contains("password"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray; // Chatbot response color
                    Console.WriteLine($"Chatbot: {reply}");
                    answered = true;
                    break; // Exit loop once a match is found
                }
                else if (query.ToLower().Contains("phishing") && reply.ToLower().Contains("phishing"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"Chatbot: {reply}");
                    answered = true;
                    break; // Exit loop once a match is found
                }
                else if (query.ToLower().Contains("safe browsing") && reply.ToLower().Contains("safe browsing"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"Chatbot: {reply}");
                    answered = true;
                    break; // Exit loop once a match is found
                }
                else if (query.ToLower().Contains("cybersecurity") && reply.ToLower().Contains("cybersecurity"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"Chatbot: {reply}");
                    answered = true;
                    break; // Exit loop once a match is found

                }
            }

            // Handling cases where a match is found or not
            if (answered)
            {
                // Ask follow-up question if the answer is satisfactory
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Chatbot: Does that answer your question? let me know ,indicate by yes or no= ");
                string feedback = Console.ReadLine()?.ToLower(); // Capture user's feedback

                if (feedback == "yes")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Chatbot: Anything else you want to ask......?");
                }
                else if (feedback == "no")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Chatbot: How can I answer your question better?");
                }
                Console.ResetColor();
            }
            else
            {
                // If no suitable response is found
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Chatbot: I'm sorry, I don't have an answer for that. Could you ask about cybersecurity, password, phishing, or safe browsing?");
                Console.ResetColor();
            }
        }
    }

}