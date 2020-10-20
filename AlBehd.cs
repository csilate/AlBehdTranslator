using System;
using System.Text;
using System.Collections.Generic;

namespace AlBehdTranslator
{
    static class AlBehd
    {
        private static Dictionary<char, string> _textToAlBehd = new Dictionary<char, string>
        {
            { 'A', "Y" },
            { 'B', "P" },
            { 'C', "L" },
            { 'D', "T" },
            { 'E', "A" },
            { 'F', "V" },
            { 'G', "K" },
            { 'H', "R" },
            { 'I', "E" },
            { 'J', "Z" },
            { 'K', "G" },
            { 'L', "M" },
            { 'M', "S" },
            { 'N', "H" },
            { 'O', "U" },
            { 'P', "B" },
            { 'Q', "X" },
            { 'R', "N" },
            { 'S', "C" },
            { 'T', "D" },
            { 'U', "I" },
            { 'V', "J" },
            { 'W', "F" },
            { 'X', "Q" },
            { 'Y', "O" },
            { 'Z', "W" },
        };
        public static string ToAlBehd(string input)
        {
            List<string> output = new List<string>(input.Length);

            foreach(char character in input.ToUpper())
            {
                try
                {
                    string alBehd = _textToAlBehd[character];
                    output.Add(alBehd);
                }
                catch(KeyNotFoundException)
                {
                    output.Add("!");
                }
            }

            return string.Join("", output);
        }
    }
}
