namespace Proyectos_VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 4/12/2023 (Sum of the pairs and odd positions)

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
                Console.WriteLine($"\nSum of odds positions: {sumP}\nSum of pairs positions: {sumI}");

            // 7/12/2023 (Check if the number value of one phrase is prime)

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

            // 9/12/2023 (Encoding Nico Cipher)


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

            // 11/12/2023 (The smallest number divisible between 1 to the user number)

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



            // 11/12/2023 (Calculate zeros at end of the factorial number of a whole number)

            Console.Write("Number?: ");
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

            // LAMBDAS
            Func<int, double> sd = (si) => si * 0.5;
            Console.WriteLine(sd(7));

            dynamic nms = new List<int> { 1, 3, 5, 7, 9 };
            Action<int> print = Console.WriteLine;
            Action<List<int>> printtwo = (nms) =>
             {
                 foreach (int n in nms)
                     print(n);
             };
            printtwo(nms);

            string f = null;
            Func<int, Func<int, bool>, string> funcP = (n, funcH) =>
            {
                if (funcH(n) == true)
                {
                    f = "Maybe odd";
                    Console.Write(f);
                }
                else if (funcH(n) == false)
                {
                    f = "Maybe odd and even";
                    Console.Write(f);
                }
                return null;
            };
            Console.WriteLine(funcP(177, n => n % 3 == 0 ? true : false));

            Random random = new Random();
            Action<int> show = Console.Write;
            int a, b = 0;
            a = random.Next(1, 5); b = random.Next(1, 5);
            int[] ints = new int[10];

            for (int i = 0; i < 5; i++)
            {
                ints[i] = random.Next(0, 6);
                show(ints[i]);
            }
            Console.WriteLine("\n" + a + " " + b);
            Func<int, int, int> result = (i1, i2) => ints[a - 1] * ints[b - 1];
            Console.WriteLine("\n" + result(ints[a - 1], ints[b - 1]));


            // 13/12/2023 - LINQ
            var listStudents = new List<Student>
            {

             new Student { Id = 1, Name = "Eduardo", Average = 20},
             new Student { Id = 2, Name = "Gabriel", Average = 17},
             new Student { Id = 1, Name = "Jhon", Average = 14},
             new Student { Id = 2, Name = "Miguel", Average = 9 },
             new Student { Id = 1, Name = "Blas", Average = 12},

            };
            var listSubjects = new List<Subjects>
            {
            new Subjects {StudentId = 1, CourseName = "History", Grade = 1 },
            new Subjects {StudentId = 2, CourseName = "Geography", Grade = 2},

            };

            var students = from s in listStudents
                           join ss in listSubjects on s.Id equals ss.StudentId
                           where s.Average >= 12
                           orderby s.Average
                           select new
                           {
                               s.Name,
                               s.Average,
                               ss.CourseName

                           };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // 14/10/2023 - LINQ Intermediate

            var listStudents = new List<Estudiante>
            {
                new Estudiante { Id = 1, Nombre = "Eduardo", CursosInscritos = new List<int> { 1, 2, 4 } },
                new Estudiante { Id = 2, Nombre = "Gabriel", CursosInscritos = new List<int> { 1, 4, 6 } },
                new Estudiante { Id = 3, Nombre = "Jhon", CursosInscritos = new List<int> { 3, 5 } }
            };

            var list2Students = new List<Estudiante>
            {
                new Estudiante { Id = 4, Nombre = "Hugo", CursosInscritos = new List<int> { 1, 2 } },
                new Estudiante { Id = 5, Nombre = "Dina", CursosInscritos = new List<int> { 4, 6 } }
            };

            var listSubjects = new List<Curso>
            {
                new Curso { Id = 1, Nombre = "Moderno", Categoria = "Arte" },
                new Curso { Id = 2, Nombre = "Bioquímica", Categoria = "Ciencia" },
                new Curso { Id = 3, Nombre = "Híndu", Categoria = "Filosofía" },
                new Curso { Id = 2, Nombre = "Cuántica", Categoria = "Ciencia" },
                new Curso { Id = 1, Nombre = "Renacentista", Categoria = "Arte" }
            };

            var newList = (from e in listStudents.Union(list2Students)
                           where e.CursosInscritos.Contains(1) || e.CursosInscritos.Contains(2)
                           select e)
                           .Select(e => $"{e.Nombre} inscrito en {string.Join(", ", listSubjects
                           .Where(s => e.CursosInscritos.Contains(s.Id))
                           .Select(s => s.Nombre))}, pertenece a la categoría {string.Join(", ", listSubjects
                           .Where(s => e.CursosInscritos.Contains(s.Id))
                           .Select(s => s.Categoria))}");

            foreach (var e in newList)
                Console.WriteLine(e);

            Console.WriteLine($"Hay {newList.Count()} estudiantes inscritos en Arte y/o Ciencia.");



        }

        public class Estudiante
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public List<int> CursosInscritos { get; set; }
        }

        public class Curso
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Categoria { get; set; }
        }

        //05/01/2024
        // Tree Example - InOrderTraversal
            Tree tree = new Tree(5);
            tree.Add(3);
            tree.Add(8);
            tree.Add(1);
            tree.Add(4);
            tree.Add(4);
            tree.Add(7);
            tree.Add(9);

            tree.InOrderTraversal(tree.root);

            // 06/01/2024
            int mult = 0;
            string total = null;
            Console.Write("Text: ");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                try
                {
                    mult = int.Parse(text[i].ToString());
                    total += add(text[i - 1], mult);

                }
                catch
                {
                    continue;
                }
            }
            Console.WriteLine($"Text convert: {total}.");
        }
        static string add(char c, int n)
        {
            string parcial = null;
            for (int i = 0; i < n; i++)
            {
                parcial += c;
            }
            return parcial;

            // 08/01/2024
            bool verified1 = false;
            bool verified2 = false;
            bool verified3 = false;
            bool verified4 = false;
            bool verified5 = false;
            bool verified6 = false;
            string sucess = "Verification sucessful, permitted password.";
            int v5 = 0;
            Console.WriteLine("Password: ");
            string pass = Console.ReadLine();

            Console.WriteLine("Validating password...");
            await Task.Delay(5000);

            verified1 = pass.Length >= 6 && pass.Length <= 24 ? true : false;
            verified2 = verified1 && pass.Any(char.IsUpper) ? true : false;
            verified3 = verified2 && pass.Any(char.IsLower) ? true : false;
            verified4 = verified2 && pass.Any(char.IsDigit) ? true : false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (i == 0)
                    continue;
                else
                    v5 = pass[i - 1] == pass[i] ? v5++ : v5;
            }
            verified5 = verified4 && (v5 == 1 || v5 == 0) ? true : false;

            sucess = verified5 ? "Verification sucessful, permitted password." : "Verification not completed, wrong password, try again.";
            Console.WriteLine(sucess);
            // 11/01/2024
            // Thread Exercise:

            Task<int> task1 = Task.Run(() => Sleep(11000));
            Task Continuation1 = task1.ContinueWith((task) =>
            {
                Console.WriteLine($"Terminé de dormir. Dormí por {task1.Result} segundos.");
            });
            Task<int> task2 = Task.Run(() => Sleep(7000));
            Task Continuation2 = task2.ContinueWith((task) =>
            {
                Console.WriteLine($"Terminé de dormir. Dormí por {task2.Result} segundos.");
            });
            Task<int> task3 = Task.Run(() => Sleep(4000));
            Task Continuation3 = task3.ContinueWith((task) =>
            {
                Console.WriteLine($"Terminé de dormir. Dormí por {task3.Result} segundos.");
            });

            Task.WaitAll(task1, task2, task3);
            Console.ReadKey();
            Console.WriteLine("GoodBye.");
        }
        static int Sleep(int miliseconds)
        {
            Console.WriteLine($"Durmiendo {miliseconds / 1000} segundos...");
            Thread.Sleep(miliseconds);
            return miliseconds / 1000;
        }

            // 12/01/2024
            // What web response first?
            List<string> sites = new List<string> { "http://www.msi.com", "http://www.xiaomi.com", "http://www.gmail.com" };
            List<Task<string>> tasks = new List<Task<string>>();
            foreach (string site in sites)
            {
                tasks.Add(DownloadContent(site));
            }
            int index = Task.WaitAny(tasks.ToArray());
            Task<string> completedTask = tasks.ToArray()[index];
            Console.WriteLine($"El sitio que respondió primero fue: {completedTask.Result} ");
            Console.Read();
        }


        public static async Task<string> DownloadContent(string site)
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync(site);
                return site;
            }
        }
            // Delegates Example: 
            MathCalculation calculateAll = new MathCalculation(AddNumbers);
            calculateAll += SubtractNumbers;
            calculateAll += MultiplyNumbers;
            calculateAll += DivideNumbers;

            calculateAll(4, 2);
            Console.Read();
        }
        delegate void MathCalculation(float value1, float value2);


        public static void AddNumbers(float value1, float value2)
        {
            Console.WriteLine(value1 + value2);
        }
        public static void SubtractNumbers(float value1, float value2)
        {
            Console.WriteLine(value2 - value1);
        }
        public static void MultiplyNumbers(float value1, float value2)
        {
            Console.WriteLine(value1 * value2);
        }
        public static void DivideNumbers(float value1, float value2)
        {
            Console.WriteLine(value1 / value2);
        }

           
            //15/01/2024
            // Smoothie Fruit/ Exercise

            string NameOfDrink = string.Empty;
            List<string> ingredients = new List<string>();
            Console.WriteLine("Ingredients: ");
            do
            {
                ingredients.Add(Console.ReadLine());


            } while (ingredients[ingredients.Count - 1] != " ");
            ingredients.Remove(ingredients[ingredients.Count - 1]);
            Dictionary<string, float> NamesandPrices = new Dictionary<string, float>{
                {"Strawberries", 1.5f },
                {"Banana", 0.5f },
                {"Mango", 2.5f },
                {"Blueberries",1.0f },
                {"Raspberries", 1.0f },
                {"Apple", 1.75f },
                {"Pineapple", 3.5f }


            };
            var ingredientsUsed = from i in NamesandPrices
                                  where ingredients.Contains(i.Key)
                                  select i;
            float totalPrice = 0;
            Console.WriteLine("Order List: \n");
            foreach (KeyValuePair<string, float> item in ingredientsUsed.OrderBy(i => i.Key))
            {
                totalPrice += item.Value * 1.5f;
                Console.WriteLine(item.Key + " " + Math.Round(item.Value * 1.5f, 2) + "$");

                NameOfDrink += item.Key.Replace("berries", "berry") + " ";
            }
            if (ingredientsUsed.Count() == 1)
                Console.WriteLine("Name of Drink: " + NameOfDrink + "Smoothie");
            else
                Console.WriteLine("Name of Drink: " + NameOfDrink + "Fusion");


            Console.WriteLine($"Total Price: {Math.Round(totalPrice, 2)}$ ");
             */
            //18/01/2024
            // Permutations of a string
            /*
            foreach (var r in Permutations("RAM")) 
            {
                Console.Write (r + " ");
            }
         

            List<string> Permutations(string perm)
            {
                List<char> Lperm = [.. perm];
                List<string> results = new List<string>();
                do
                {
                    for (int i = 0; i < Lperm.Count; i++)
                    {
                        try
                        {
                            char c = Lperm[i];
                            Lperm[i] = Lperm[i + 1];
                            Lperm[i + 1] = c;
                            results.Add(string.Concat(Lperm));
                        }
                        catch 
                        {
                            break;
                        }
                    }
                  
                }
                while (perm != string.Concat(Lperm));
                return results;
            }
            
            //8/02/2024
                //GET
            using (var client = new HttpClient())
            {
                string url = "https://jsonplaceholder.typicode.com/posts/1";
                
                var response = client.GetAsync(url).Result;
                var rs = response.Content.ReadAsStringAsync().Result;
                dynamic r = JObject.Parse(rs);

                Console.WriteLine(r);
                // POST
                string url2 = "https://jsonplaceholder.typicode.com/posts ";
                client.DefaultRequestHeaders.Clear();
                string parametros = "{\"title\": \"Fernando's Shop\", \"body\": \"Local Cousine\", \"userId\": 1}";
                dynamic jsonString = JObject.Parse(parametros);
                var httpContent = new StringContent(jsonString.ToString(), Encoding.UTF8, "application/json");
                var response2 = client.PostAsync(url2, httpContent).Result;
                var res2 = response2.Content.ReadAsStringAsync().Result;
                dynamic r2 = JObject.Parse(res2);
                Console.WriteLine(r2);
                //PATCH
                string url3 = "https://jsonplaceholder.typicode.com/posts/1";
                client.DefaultRequestHeaders.Clear();
                string parametros3 = "{\"title\": \"Fernando's Shop\", \"body\": \"Foreign Cousine\", \"userId\": 1}";
                dynamic jsonString3 = JObject.Parse(parametros3);
                var httpContent3 = new StringContent(jsonString3.ToString(), Encoding.UTF8, "application/json");
                var response3 = client.PutAsync(url3, httpContent3).Result;
                var res3 = response3.Content.ReadAsStringAsync().Result;
                dynamic r3 = JObject.Parse(res3);
                Console.WriteLine(r3);
                //PUT
                string url4 = "https://jsonplaceholder.typicode.com/posts";
                client.DefaultRequestHeaders.Clear();
                string parametros4 = "{\"title\": \"Miguel's Shop\"}";
                dynamic jsonString4 = JObject.Parse(parametros4);
                var httpContent4 = new StringContent(jsonString4.ToString(), Encoding.UTF8, "application/json");
                var response4 = client.PostAsync(url4, httpContent4).Result;
                var res4 = response4.Content.ReadAsStringAsync().Result;
                dynamic r4 = JObject.Parse(res4);
                Console.WriteLine(r4);
            }
            
            // 09/02/2024
            // Generics:
            var numbers = new AddGeneric<int>(6);
            var names = new AddGeneric<string>(5);
            names.Add("a");
            names.Add("b");
            names.Add("c");
            names.Add("d");
            names.Add("e");
            names.Add("f");
            names.Add("g");
            Console.WriteLine(names.Get());
        }

        public class AddGeneric<T>
        {
            private List<T> _list;
            private int _limit;

            public AddGeneric(int limit)
            {
                _limit = limit;
                _list = new List<T>();
            }
            public void Add(T element)
            {
                if (_list.Count < _limit)
                {
                    _list.Add(element);
                }
            }
            public string Get()
            {
                string set = string.Empty;
                foreach (T element in _list)
                {
                    set += element;
                }
                return set;
            }
            // Json Serializer and Deserializer
            dynamic Me = new Person()
            {
                Name = "Cpaz",
                Age = 17,
            };

            dynamic ToJson = JsonSerializer.Serialize(Me);
            Console.WriteLine(ToJson);
            dynamic OtherJson = @"{
                ""Name"":""CLeon"",
                ""Age"":17
            }";
            Person? mySLN = JsonSerializer.Deserialize<Person>(OtherJson);
            Console.WriteLine(mySLN?.Name);
            Console.WriteLine(mySLN?.Age);
            }
            public class Person
            {
                public string Name { get; set; }
                public int Age { get; set; }
            }
            
            */
            //12/03/2024
            // Roman Numbers
            /*
            int count = 0;
            bool verify = true;
            Console.WriteLine("Put a Roman Number: ");
            string romanNumber = Console.ReadLine();
            romanNumber = romanNumber.Trim().ToUpper();
            Dictionary<char, int> romanDictionary = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            // For to validate correct letters
            foreach (char character in romanNumber)
            {
                if (!romanDictionary.ContainsKey(character))
                {
                    Console.WriteLine("Check your Roman Number, there's mistakes...");
                    verify = false;
                    break;
                }

            }
            // For to validate that a letter not repeat three times and VLD
            bool ValidateNotRepeat(string romanNumber)
            {
                char lastChar = ' ';
                int charCount = 0;

                foreach (char c in romanNumber)
                {
                    if (c == lastChar)
                    {
                        charCount++;
                        if ((charCount > 3) || (c == 'V') || (c == 'L') || (c == 'D'))
                        {
                            Console.WriteLine("Check your Roman Number, there's mistakes...");
                            return false;
                        }
                    }
                    else
                    {
                        lastChar = c;
                        charCount = 1;
                    }
                }
                return true;
            }
            // For to sum values from a word 
            bool SumOrSubtract(char romanSign, char romanSignWord)
            {
                if (romanSign == romanSignWord)
                {

                    return true;
                }
                return false;

            }
            bool SumOrSubtract2(char romanSign, char romanSignWord)
            {
                if (romanSign == 'I' && romanSignWord == 'V')
                    return false;
                if (romanSign == 'X' && romanSignWord == 'L')
                    return false;
                if (romanSign == 'C' && romanSignWord == 'D')
                    return false;
                return true;
            }
            if (verify && ValidateNotRepeat(romanNumber) == true)
            {
                for (int i = 0; i < romanNumber.Length; i++)
                {
                    try
                    {
                        foreach (KeyValuePair<char, int> romanSign in romanDictionary)
                        {
                            bool ultimateValidator = false;
                            if (SumOrSubtract(romanSign.Key, romanNumber[i]))
                            {
                                count += romanSign.Value;
                                if (!SumOrSubtract2(romanSign.Key, romanNumber[i + 1]))
                                {
                                    count -= romanSign.Value;

                                    foreach (KeyValuePair<char, int> romanSign2 in romanDictionary)
                                    {
                                        _ = romanSign2.Key == romanNumber[i + 1] ? (count = romanSign2.Value) : 0;

                                        count -= romanSign.Value;
                                        break;
                                    }
                                }
                            }

                        }
                    }
                    catch
                    {
                        break;
                    }
                }
                Console.WriteLine($"Your Roman Number in Arabic is: {count}");
            }
            */
        }
    }

}
