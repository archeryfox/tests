using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringis
{
    public class StringsCheck
    {
        public string ShortestWord(string input)
        {
            string[] words = input.Split(' ');
            string shortestWord = words[0];
            foreach (string word in words)
            {
                if (word.Length < shortestWord.Length)
                {
                    shortestWord = word;
                }
            }
            return shortestWord;
        }
        
        public int WordCount(string input)
        {
            string[] words = input.Split(' ');
            return words.Length;
        }

        public char NthCharacter(string input, int index)
        {
            if (index < 0 || index >= input.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return input[index];
        }

        public int DigitCount(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }

        public int SubstringCount(string input, string substring)
        {
            int count = 0;
            int index = 0;
            while ((index = input.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }
            return count;
        }

        public int MaxConsecutiveDigits(string input)
        {
            int maxCount = 0;
            int count = 0;
            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            return maxCount;
        }

        public int CharacterCount(string input)
        {
            return input.Length;
        }
    }   
}
