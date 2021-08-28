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
                Console.WriteLine("If you would like to continue talking, please enther another input.");
            }
            else if (userInput == "sup")
            {
                Console.WriteLine("I am good.");
                Console.WriteLine("If you would like to continue talking, please enther another input.");
            }
            else if (userInput == "hello there")
            {
                Console.WriteLine("General Kenobi");
                Console.WriteLine("If you would like to continue talking, please enther another input.");
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
                        Console.WriteLine("If you would like to continue talking, please enther another input.");
                    }

                    else if (userInput == "hello")
                    {
                        Console.WriteLine("Hi good to see you");
                        Console.WriteLine("If you would like to continue talking, please enther another input.");
                    }
                    else if (userInput == "sup")
                    {
                        Console.WriteLine("I am good.");
                        Console.WriteLine("If you would like to continue talking, please enther another input.");
                    }
                    else if (userInput == "hello there")
                    {
                        Console.WriteLine("General Kenobi");
                        Console.WriteLine("If you would like to continue talking, please enther another input.");
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
