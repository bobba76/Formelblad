using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formelblad
{
    public class Metoder
    {
        // Olika komponenter

        // Skapar en Random variabel 
        public void RandomMethod()
        {
            int min = 0;
            int max = 11;

            Random rnd = new Random();

            // Minimum 0 : Max 10
            int rndNumber = rnd.Next(min, max);

            // Ifall du vill göra det kort och dra mindre prestanda 
            int rndNumber1 = new Random().Next(min, max);

            int rndNuber2 = new Random().Next(max);
        }

        // Låt användaren skriva in tills användaren skriver en siffra
        public void ParseInt()
        {
            int result;

            while (true)
            {
                string answer = Console.ReadLine().Trim();

                if (Int32.TryParse(answer, out result))
                    break;

                Console.WriteLine("Du måste skriva in ett heltal!");
            }
        }

        // Kortare metod som tvingar användaren att skriva in ett heltal
        public int ParseIntMethod(string message)
        {
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine().Trim(), out int result))
                    return result;

                Console.WriteLine(message);
            }
        }

        // Tvingar användaren att svara likadant som ett av alternativen
        public string GetStringFromUser(string[] alternatives, string text, string warning)
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

        // Tvingar användaren att svara likadant som ett av alternativen eller siffran framför
        public string GetStringOrIntFromUser(string[] alternatives, string text, string warning)
        {
            while (true)
            {
                // Låt användaren 
                Console.Write("{0}: ", text);

                // Användaren får skriva in en string
                string answer = Console.ReadLine().Trim().ToLower();

                // Retunera svaret om den liknar en ett av alternativen eller siffran framför
                for (int i = 0; i < alternatives.Length; i++)
                {
                    if (answer == alternatives[i].ToLower() || answer == (i + 1).ToString())
                        return answer;
                }

                // Ifall ordet inte matchade, skriv ut varför
                Console.WriteLine(warning);
            }
        }

        // Tvingar användaren att skriva in en string som är mellan minLength och maxLength längd
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

        // Tvingar användaren att skriva in en string som är mellan minLength och maxLength längd (Extra message)
        public string LimitedRange(string message, string toShortMessage, string toLongMessage, int minLength, int maxLength)
        {
            while (true)
            {
                Console.Write("{0}: ", message);

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

        // Tvingar användaren att skriva en int mellan minValue och maxValue
        public int LimitedRangeInt(string message, string parseIntMessage, string toLow, string toHigh, int minValue, int maxValue)
        {
            while (true)
            {
                Console.Write("{0}: ", message);

                int answer = ParseIntMethod(parseIntMessage);

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
