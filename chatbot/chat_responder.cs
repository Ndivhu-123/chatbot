using System;

namespace chatbot
{
    public class chat_responder
    {
        // Variable declarations (global scope)
        private string username = string.Empty; // Stores the user's name
        private string userasking = string.Empty; // Stores the user's input/questions

        // Constructor
        public chat_responder()
        {
            // Display the welcome message and prompt the user to enter their name
            // Change the text color to magenta for styling
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("   "); // Spacer for  formatting

            // Change the text color for the welcome message
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Hi! I'm CHATBOT, here to assist, chat, and explore with you. Let's get started");

            // Add a separator line with magenta for visual emphasis
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ............................................................................  ");

            // Chatbot asks for the user's name
            Console.ForegroundColor = ConsoleColor.Gray; // Chatbot response color: Gray
            Console.Write("Chatbot:");
            Console.ForegroundColor = ConsoleColor.Gray; // Gray for the question text
            Console.WriteLine("What is your name");

            // User enters their name
            Console.ForegroundColor = ConsoleColor.Magenta; // User response color: Magenta
            Console.Write("You:");
            username = Console.ReadLine(); // Read user name input

            // Begin a conversation loop
            do
            {
                // Recreate the chat interface for each interaction
                Console.ForegroundColor = ConsoleColor.Gray; // Chatbot response color: Gray
                Console.Write("Chatbot:");

                // Display chatbot's question with Gray text
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Hey " + username + ", how can I assist you today? Let's explore together!");

                // User responds (Magenta for their text)
                Console.ForegroundColor = ConsoleColor.Magenta; // User response color: Magenta
                Console.Write(username + ":");
                Console.ForegroundColor = ConsoleColor.Gray; // Reset color for input prompt
                userasking = Console.ReadLine(); // Read user input

                // Process the user's question
                responses(userasking);

            } while (userasking != "exit"); // Loop continues until the user types "exit"
        } // End of constructor

        // Method to process and respond to the user's input
        private void responses(string asked)
        {
            // Check the user's input
            if (asked != "exit")
            {
                // Chatbot's response
                Console.ForegroundColor = ConsoleColor.Gray; // Chatbot response color: Gray
                Console.Write("Chatbot:");

                // Display chatbot's follow-up answer in Gray
                Console.ForegroundColor = ConsoleColor.Gray; // Reset color for the response text
                Console.WriteLine("Does this answer your question? Let me know!");
                // Get the user's response
                Console.ForegroundColor = ConsoleColor.Magenta; // User response color: Magenta
                Console.Write("You:");
                string feedback = Console.ReadLine(); // Read feedback from the user

                // Conditional response based on the user's feedback
                if (feedback.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    // If user says "no," chatbot asks how to improve
                    Console.ForegroundColor = ConsoleColor.Gray; // Chatbot response color: Gray
                    Console.Write("Chatbot:");
                    Console.WriteLine("How can I answer your question better?");
                }
                else if (feedback.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    // If user says "yes," chatbot does not respond further
                }
                
                Console.ForegroundColor = ConsoleColor.Gray; // Reset to default color for chatbot text

            }
            else
            {
                // If user decides to exit
                Console.ForegroundColor = ConsoleColor.Gray; // Chatbot response color: Gray
                Console.WriteLine("Bye for now! Don't hesitate to reach out again!");
                System.Environment.Exit(0); // Exit the program
            } // End of else
        } // End of responses method
    } // End of chat_responder class
} // End of chatbot namespace
