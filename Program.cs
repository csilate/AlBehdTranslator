using System;
using AlBehdTranslator; 

namespace AlBehdTranslator
{
    class Program
    {
        static void Main()
        {
            Start:
            Console.Write("Enter 'ALB' to translate from Al Behd, or 'ENG' to translate from English: ");
            string choice = Console.ReadLine();

            if(choice.ToUpper() == "ALB")
            {
                while(true)
                {
                    Console.Write("Enter things to be translated to Al Behd. Type 'MAIN' to go back to the main menu. Type 'ESC' to exit.: ");
                    string input = Console.ReadLine();

                    if(input.ToUpper() == "ESC")
                    {
                        break;
                    }
                    else if(input.ToUpper() == "MAIN")
                    {
                        goto Start;
                    }
                    else
                    {
                        string output = AlBehd.ToAlBehd(input);

                        Console.WriteLine(output); 
                    }
                }
            }
            else if(choice.ToUpper() == "ENG")
            {
                while(true)
                {
                    Console.Write("Enter things to be translated to English. Type 'MAIN' to go back to the main menu. Type 'ESC' to exit.: ");
                    string input = Console.ReadLine();

                    if(input.ToUpper() == "ESC")
                    {
                        break;
                    }
                    else if(input.ToUpper() == "MAIN")
                    {
                        goto Start;
                    }
                    else
                    {
                        string output = English.ToEnglish(input);

                        Console.WriteLine(output); 
                    }
                }
            }
            else 
            {
                Console.WriteLine("Please enter a valid command.");
                goto Start;
            }
        }
    }
}
