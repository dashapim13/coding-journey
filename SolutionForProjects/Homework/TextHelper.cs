using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class TextHelper
    {
        //Private string property Text
        private string Text { get; set; }

        //Constructor to set the Text property
        public TextHelper(string text)
        {
            Text = text;
        }
        //Method to count words with more than four letters in Text
        public int CountWordsMoreThanFourLetters()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                return 0;    //Return 0 if the input is null, empty, or whitespace
            }
            //Split the string into words and count those with more than 4 letters
            string[] words = Text.Split(new[] { ' ', '\t', '\n', '\r', ',', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int count = words.Count(word => word.Length > 4);   
      
            return count;
        }
        public bool IsPalindrome()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                return false;    //Return false or null or empty strings
            }

            //Remove non-alphanumeric characters and convert to lowercase
            string cleanedText = new string(Text.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();
            string reversedText = new string(cleanedText.Reverse().ToArray());

            return cleanedText == reversedText;

        
        }
        public int CountVowels()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                return 0;
            }
            //define vowels
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            //Count the vowels (case insensitive)
            int count = Text.Count(c => vowels.Contains(char.ToLower(c)));
            return count;
        }
    }
}
