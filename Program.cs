using System;
using AlBehdTranslator; 

namespace AlBehdTranslator
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                Console.Write("Enter things to be translated. Type 'ESC' to exit.: ");
                string input = Console.ReadLine();

                if(input.ToUpper() == "ESC")
                {
                    break;
                }

                string output = AlBehd.ToAlBehd(input);

                Console.WriteLine(output); 
            }
        }
    }
}
