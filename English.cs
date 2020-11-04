using System;
using System.Text;
using System.Collections.Generic;

namespace AlBehdTranslator
{
    static class English
    {
        private static Dictionary<char, string> _textToEnglish = new Dictionary<char, string> //takes al behd chars and makes them eng chars
        {
            { 'Y', "A" },
            { 'P', "B" },
            { 'L', "C" },
            { 'T', "D" },
            { 'A', "E" },
            { 'V', "F" },
            { 'K', "G" },
            { 'R', "H" },
            { 'E', "I" },
            { 'Z', "J" },
            { 'G', "K" },
            { 'M', "L" },
            { 'S', "M" },
            { 'H', "N" },
            { 'U', "O" },
            { 'B', "P" },
            { 'X', "Q" },
            { 'N', "R" },
            { 'C', "S" },
            { 'D', "T" },
            { 'I', "U" },
            { 'J', "V" },
            { 'F', "W" },
            { 'Q', "X" },
            { 'O', "Y" },
            { 'W', "Z" },
            { ' ', " " }
        };
        public static string ToEnglish(string input)
        {
            List<string> output = new List<string>(input.Length);

            foreach(char character in input.ToUpper())
            {
                try
                {
                    string english = _textToEnglish[character];
                    output.Add(english);
                }
                catch(KeyNotFoundException)
                {
                    output.Add("!"); //if no translation for the char exists, adds '!' in its place.
                }
            }

            return string.Join("", output);
        }
    }
}
