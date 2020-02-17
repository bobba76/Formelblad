using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula
{
    /// <summary>
    /// Common Methods that are used reguarly.
    /// </summary>
    public class CommonMethods
    {
        /// <summary>
        /// Forces input to be an int.
        /// </summary>
        public int ParseInt(string errorMessage)
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
        public int ParseInt(string word, string errorMessage)
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
        public string GetSpecificString(string[] alternatives, string text, string warning)
        {
            while (true)
            {
                // Låt användaren 
                Console.Write("{0}: ", text);

                // Användaren får skriva in en string
                string answer = Console.ReadLine().Trim().ToLower();

                // Retunera svaret om den liknar en ett av alternativen
                for (int i = 0; i < alternatives.Length; i++)
                {
                    if (answer == alternatives[i].ToLower())
                        return answer;
                }

                // Ifall ordet inte matchade, skriv ut varför
                Console.WriteLine(warning);
            }
        }

        /// <summary>
        /// Forces input to be equal to one of the alternatives or number of placement in array + 1.
        /// </summary>
        public string GetSpecificStringOrInt(string[] alternatives, string text, string errorMessage)
        {
            while (true)
            {
                Console.Write("{0}: ", text);

                string answer = Console.ReadLine().Trim().ToLower();

                // Returns if the input is equal to an alternative/number of placement
                for (int i = 0; i < alternatives.Length; i++)
                {
                    if (answer == alternatives[i].ToLower())
                        return answer;

                    else if (answer == (i + 1).ToString())
                        return i.ToString();
                }

                Console.WriteLine(errorMessage);
            }
        }

        /// <summary>
        /// Forces input with limited amount of letters.
        /// </summary>
        public string LimitedRange(string toShortMessage, string toLongMessage, int minLength, int maxLength)
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
        /// Forces input with limited amount of letters.
        /// Message before input.
        /// </summary>
        public string LimitedRange(string word, string toShortMessage, string toLongMessage, int minLength, int maxLength)
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
        /// Forces input that's withing max and minimum value.
        /// </summary>
        public int LimitedRange(string word, string parseIntMessage, string toLow, string toHigh, int minValue, int maxValue)
        {
            while (true)
            {
                Console.Write("{0}: ", word);

                int answer = ParseInt(parseIntMessage);

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
    }
}
