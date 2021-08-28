using System;

namespace ZTataDeliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string answerDoubleCheck;
            Console.WriteLine("Hello and welcome to chatting with bots. What would you like to say to the bot? Please enter text below to begin.");
            userInput = Console.ReadLine();
            userInput = userInput.ToLower();

 
            if (userInput == "hello")
            {
                Console.WriteLine("Hi good to see you");
            }
            else if (userInput == "sup")
            {
                Console.WriteLine("I am good.");
            }
            else if (userInput == "hello there")
            {
                Console.WriteLine("General Kenobi");
            }

            answerDoubleCheck = userInput;

            if (userInput != "bye") {
                do
                {
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();

                    if (answerDoubleCheck == userInput)
                    {
                        Console.WriteLine("You already said that");
                    }

                    else if (userInput == "hello")
                    {
                        Console.WriteLine("Hi good to see you");
                    }
                    else if (userInput == "sup")
                    {
                        Console.WriteLine("I am good.");
                    }
                    else if (userInput == "hello there")
                    {
                        Console.WriteLine("General Kenobi");
                    }

                    answerDoubleCheck = userInput;

                } while (userInput != "bye");
            }


            Console.WriteLine("Good bye!");
            Console.Write("Please press any key to exit.");
            Console.ReadKey();
        }
    }
}
