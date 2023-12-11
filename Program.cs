using System.Numerics;

namespace Proyectos_VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4/12/2023 (Sum of the pairs and odd positions)
            /*
                int sumP = 0; int sumI = 0;
                Random rdn = new Random();
                int[] arr = new int[5];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rdn.Next(0, 11);
                    Console.Write(arr[i] + "\t");
                    sumP += i % 2 == 0 ? arr[i] : 0;
                    sumI += (i + 1) % 2 == 0 ? arr[i] : 0;

                }
                Console.WriteLine($"\nSum of odds positions: {sumP}\nSum of pairs positions: {sumI}");*/
            // 7/12/2023 (Check if the number value of one phrase is prime)
            /*
            Dictionary<string, int> WordAndValue = new Dictionary<string, int>();
            Console.Write("Words in Phrase?: ");
            int winp = int.Parse(Console.ReadLine());
            string[] wordsinphrase = new string[winp];
            int sumTotalWords = 0;
            Console.Write("Phrase: ");
            string prh = Console.ReadLine();
            // Function for remove special characters of prh
            string cleanprh = Regex.Replace(prh, "[^a-zA-Z0-9 ]", "");
            char[] prhToChars = cleanprh.ToCharArray();
            //Loop for remove spaces and split "prh" in words
            int i = 0;
            for (int j = 0; j < prhToChars.Length; j++)
            {
                if (prhToChars[j] != ' ')
                    wordsinphrase[i] += prhToChars[j];
                else if (prhToChars[j] == ' ')
                    i++;
            }

            // For convert letters n numbers...
            foreach (string word in wordsinphrase)
            {
                int sumWords = 0;
                for (i = 0; i <= word.Length - 1; i++)
                {
                    if (!Char.IsDigit(word[i]))
                        sumWords += Char.ToUpperInvariant(word[i]) - 'A' + 1;
                    else
                        sumWords += Int32.Parse(word[i].ToString());
                }
                Console.WriteLine($"The word {word} is equal to: {sumWords} ");
                WordAndValue.Add(word, sumWords);
                sumTotalWords += sumWords;
            }

            bool isPrime = IsPrime(sumTotalWords);
            bool almostIsPrime = false;

            if (!isPrime)
            {
                foreach (KeyValuePair<string, int> word in WordAndValue)
                {
                    int newSum = sumTotalWords - word.Value;
                    if (IsPrime(newSum))
                    {
                        Console.WriteLine($"Removing {word.Key} makes the phrase Prime with a sum of {newSum}");
                        almostIsPrime = true;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine($"The phrase is Prime!!!, sum total of words: {sumTotalWords}.");
            else if (almostIsPrime)
                Console.WriteLine($"The phrase is almost Prime.");
            else
                Console.WriteLine($"The phrase is not Prime, sum total of words: {sumTotalWords}.");
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
        }

            return true;
            */
            // 9/12/2023 (Encoding Nico Cipher)

            /*
            string message = Console.ReadLine();
            string key = Console.ReadLine();
            string encodedMessage = NicoCipher(message, key);
            Console.WriteLine("Encoded Message: " + encodedMessage);



            static string NicoCipher(string message, string key)
            {
                var order = CreateOrder(key);
                var dict = new Dictionary<int, string>();
                var sortedDict = new Dictionary<int, string>();
                var counter = 0;
                var finalString = "";

                foreach (var number in order)
                    dict.Add(number, "");

                for (int i = 0; i < message.Length; i++)
                {
                    if (counter == order.Count)
                        counter = 0;

                    dict[order[counter]] += message[i];
                    counter++;
                }

                for (int i = 0; i < dict.Count; i++)
                {
                    while (dict[order[i]].Length < dict[order[0]].Length)
                        dict[order[i]] += " ";
                }

                foreach (var val in dict.OrderBy(x => x.Key))
                    sortedDict.Add(val.Key, val.Value);

                for (int i = 0; i < dict[order[0]].Length; i++)
                {
                    foreach (var element in sortedDict)
                        finalString += element.Value[i];
                }
                return finalString;
            }

            static List<int> CreateOrder(string key)
            {
                var order = new List<int>();
                int orderAsInt;

                if (int.TryParse(key, out orderAsInt))
                {
                    for (int i = 0; i < key.Length; i++)
                        order.Add((int)char.GetNumericValue(key[i]));
                }
                else
                {
                    var sorted = key.ToCharArray().OrderBy(c => c).ToArray();

                    foreach (var sign in key)
                    {
                        if (!order.Contains(Array.IndexOf(sorted, sign) + 1))
                            order.Add(Array.IndexOf(sorted, sign) + 1);
                        else
                            order.Add(Array.IndexOf(sorted, sign) + 2);
                    }
                }
                return order;
            
            }
            */
            // 11/12/2023
            /*
            // Solution 1:
            Console.Write("Number: ");
            int numdiv = int.Parse(Console.ReadLine());

            Console.WriteLine($"The smallest number divisible since 1 to {numdiv} is {SmallestNumberDivisible(numdiv)}");


            static string SmallestNumberDivisible(int n)
            {
                long number = 1;
                while (true)
                {
                    bool divisible = true;
                    for (int i = 1; i <= n; i++)
                    {
                        if (number % i != 0)
                        {
                            divisible = false;
                            break;
                        }
                    }
                    if (divisible)
                    {
                        return number.ToString();
                    }
                    number++;
                }
            }
            // Solution 2:
            Console.WriteLine(Smallest(5));
            static string Smallest(int n)
            {
                BigInteger lcm = 1, prev;
                for (int i = 1; i <= n; i++)
                {
                    prev = lcm;
                    while (lcm % i != 0) lcm += prev;
                }
                return lcm.ToString();
            }

            */

            // 11/12/2023

            Console.WriteLine("Number?: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger CopyN = n;
            //int fact = n;
            for (BigInteger i = n; i <= n; i--)
            {
                if (i == 2) { break; }
                n *= i - 1;
            }
            string nStr = n.ToString();
            int CountZeros = 0;
            for (int i = nStr.Length - 1; i >= 0; i--)
            {
                if (nStr[i] == '0')
                    CountZeros++;
                else
                    break;
            }
            Console.WriteLine($"The number {CopyN} have {CountZeros} at its end.");
        }

    }
}