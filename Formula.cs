using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Summary
/// Add this file to the project's folder.
/// Write "using Formula;" at the top of the file to access the namespace.
namespace Formula
{
    /// <summary>
    /// Common methods that are used regularly.
    /// </summary>
    public static class Common
    {
        /// <summary>
        /// Forces input to be an int.
        /// </summary>
        public static int ParseInt(string errorMessage)
        {
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine().Trim(), out int result))
                    return result;

                Console.WriteLine(errorMessage);
            }
        }

        /// <summary>
        /// Forces input to be an int.
        /// Message before input.
        /// </summary>
        public static int ParseInt(string word, string errorMessage)
        {
            while (true)
            {
                Console.Write("{0}: ", word);

                if (Int32.TryParse(Console.ReadLine().Trim(), out int result))
                {
                    return result;
                }

                Console.WriteLine(errorMessage);
            }
        }

        /// <summary>
        /// Forces input to be equal to one of the alternatives.
        /// </summary>
        public static string GetSpecificString(string[] alternatives, string text, string errorMessage)
        {
            while (true)
            {
                Console.Write("{0}: ", text);

                string answer = Console.ReadLine().Trim().ToLower();

                for (int i = 0; i < alternatives.Length; i++)
                {
                    if (answer == alternatives[i].ToLower())
                        return answer;
                }

                Console.WriteLine(errorMessage);
            }
        }

        /// <summary>
        /// Forces input to be equal to one of the alternatives or number of placement in array + 1.
        /// </summary>
        public static string GetSpecificStringOrInt(string[] alternatives, string text, string errorMessage)
        {
            while (true)
            {
                Console.Write("{0}: ", text);

                string answer = Console.ReadLine().Trim().ToLower();

                // Returns if the input is equal to an alternative or number of placement in array + 1
                for (int i = 0; i < alternatives.Length; i++)
                {
                    if (answer == alternatives[i].ToLower())
                        return answer;

                    else if (answer == (i + 1).ToString())
                        return (i + 1).ToString();
                }

                Console.WriteLine(errorMessage);
            }
        }

        /// <summary>
        /// Forces input (string) with limited amount of letters.
        /// </summary>
        public static string LimitedRange(string toShortMessage, string toLongMessage, int minLength, int maxLength)
        {
            while (true)
            {
                string answer = Console.ReadLine().Trim();

                if (answer.Length < minLength)
                {
                    Console.WriteLine(toShortMessage);
                }

                else if (answer.Length > maxLength)
                {
                    Console.WriteLine(toLongMessage);
                }

                else
                {
                    return answer;
                }
            }
        }

        /// <summary>
        /// Forces input (string) with limited amount of letters.
        /// Message before input.
        /// </summary>
        public static string LimitedRange(string word, string toShortMessage, string toLongMessage, int minLength, int maxLength)
        {
            while (true)
            {
                Console.Write("{0}: ", word);

                string answer = Console.ReadLine().Trim();

                if (answer.Length < minLength)
                {
                    Console.WriteLine(toShortMessage);
                }

                else if (answer.Length > maxLength)
                {
                    Console.WriteLine(toLongMessage);
                }

                else
                {
                    return answer;
                }
            }
        }

        /// <summary>        
        /// Forces input (int) that's withing max and minimum value.
        /// </summary>
        public static int LimitedRange(string word, string parseIntMessage, string toLow, string toHigh, int minValue, int maxValue)
        {
            while (true)
            {
                int answer = ParseInt(word, parseIntMessage);

                if (answer < minValue)
                {
                    Console.WriteLine(toLow);
                }

                else if (answer > maxValue)
                {
                    Console.WriteLine(toHigh);
                }

                else
                {
                    return answer;
                }
            }
        }

        /// <summary>
        ///  Print a specific number of rows in the console.
        /// </summary>
        public static void Row(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine();
            }
        }

        /// <summary>
        ///  Makes the first letter in a string to uppercase
        /// </summary>
        public static string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }
    }
}
