namespace Homework

{
    internal class Program
    {

        //public static bool IsPalindrome(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //    {
        //        return false;    //Return false or null or empty strings
        //    }

        //    //Remove whitespace and convert to lowercase
        //    string cleanedInput = input.Replace(" ", "").ToLower();

        //    //Compare the original cleaned input with its reverse
        //    char[] charArray = cleanedInput.ToCharArray();
        //    Array.Reverse(charArray);
        //    string reversedInput = new string(charArray);
        //    return cleanedInput == reversedInput;

        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a string to check if it's a pallindrome:");
        //    string userInput = Console.ReadLine();

        //    if (IsPalindrome(userInput))
        //    {
        //        Console.WriteLine("The string is a pallindrome.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The string is not a pallindrome.");

        //    }

        public static int CountWordsWithMoreThanFourLetters(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;    //Return 0 if the input is null, empty, or whitespace
            }
            //Split the string into words
            string[] words = input.Split(new[] { ' ', '\t', '\n', '\r', ',', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            //Count the words with more than 4 letters
            int count = 0;
            foreach (string word in words)
            {
                if (word.Length > 4)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            string testInput = "Hello, world! How are you?";
            int result = CountWordsWithMoreThanFourLetters(testInput);
            Console.WriteLine($"Number of words with more than 4 letters: {result}");



        }
    }

}