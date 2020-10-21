using System;
using AlBehdTranslator; 

namespace AlBehdTranslator
{
    class Program
    {
        static void Main()
        {
            Start:
            Console.Write("Enter 'ALB' to translate from Al Behd, 'ENG' to translate from English, or 'GRAM' to convert grams to ounces: ");
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
            else if(choice.ToUpper() == "GRAM")
            {
                while(true)
                {
                    try
                    {
                        Console.Write("Enter the number of grams: ");
                        double input = Convert.ToDouble(Console.ReadLine());

                        double output = ConvertGramsToOunces(input);

                        Console.WriteLine(output); 
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
            }
            else 
            {
                Console.WriteLine("Please enter a valid command.");
                goto Start;
            }
        }
        static double ConvertGramsToOunces(double grams) 
        {
            double ounces = grams * 0.0352739619;
            return ounces;
        }
    }
}
