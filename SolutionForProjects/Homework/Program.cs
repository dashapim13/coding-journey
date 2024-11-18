namespace Homework

{
    internal class Program
    {

        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;    //Return false or null or empty strings
            }

            //Remove whitespace and convert to lowercase
            string cleanedInput = input.Replace(" ", "").ToLower();

            //Compare the original cleaned input with its reverse
            char[] charArray = cleanedInput.ToCharArray();
            Array.Reverse(charArray);
            string reversedInput = new string(charArray);
            return cleanedInput == reversedInput;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check if it's a pallindrome:");
            string userInput = Console.ReadLine();

            if (IsPalindrome(userInput))
            {
                Console.WriteLine("The string is a pallindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a pallindrome.");

            }
        }
    }
}