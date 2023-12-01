namespace Proyectos_VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 6 Octubre:

            string[] alumnos = { "Sophia", "Andrew", "Emma", "Logan" };
            int[] notasSophia = { 90, 86, 87, 98, 100 };
            int[] notasAndrew = { 92, 89, 81, 96, 90 };
            int[] notasEmma = { 90, 85, 87, 98, 68 };
            int[] notasLogan = { 90, 85, 87, 98, 96 };
            double promSophia = (notasSophia[0] + notasSophia[1] + notasSophia[2] + notasSophia[3] + notasSophia[4]) / 5.0;
            double promAndrew = (notasAndrew[0] + notasAndrew[1] + notasAndrew[2] + notasAndrew[3] + notasAndrew[4]) / 5.0;
            double promEmma = (notasEmma[0] + notasEmma[1] + notasEmma[2] + notasEmma[3] + notasEmma[4]) / 5.0;
            double promLogan = (notasLogan[0] + notasLogan[1] + notasLogan[2] + notasLogan[3] + notasLogan[4]) / 5.0;
            double[] proms = { promSophia, promAndrew, promEmma, promLogan };
            int i = 0;
            string cualif = null;
            Console.WriteLine("Student\t\tGrade\n");

            foreach (var alumno in alumnos)
            {

                if (i >= 0)
                {
                    if (proms[i] > 89.99)
                    {
                        cualif = "A";
                    }
                    else if (proms[i] <= 89.99 && proms[i] >= 80)
                    {
                        cualif = "B";
                        
                    }
                    else if (proms[i] <= 79.99 && proms[i] >= 70)
                    {
                        cualif = "C";

                    }
                    else if (proms[i] <= 69.99 && proms[i] >= 60)
                    {
                        cualif = "D";

                    }
                    else
                    {
                        cualif = "F";
                    }
                    Console.WriteLine($"{alumno}:\t\t{proms[i]}\t {cualif}");

                    i++;
                    
                }

            }
            */
            /*
            // 7 Octubre
            string permission = "Admin|Manager";
            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level > 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");

            }

            bool flag = true;
            if (flag)
                Console.WriteLine(flag);

            
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;

            foreach (int number in numbers)
            {
                total += number;
                if (number == 42)   found = true;
                
            }
            if (found)  Console.WriteLine("Set contains 42");

            Console.WriteLine($"Total: {total}");
            

            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>
            string sku = "03 WH S";

            string[] product = sku.Split(' ');

            string type = "";
            string color = "";
            string size = "";
            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }
            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }
            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }
            Console.WriteLine($"Product: {size} {color} {type}");
            */
            // 8 de octubre
            /*
            string fizzBuzz = " ";
            for (int j = 0; j <= 100; j++)
            {
                if (j % 5 == 0 && j % 3 == 0)
                    fizzBuzz = " - FizzBuzz";
                else if (j % 3 == 0)
                    fizzBuzz = " - Fizz";
                else if (j % 5 == 0)
                    fizzBuzz = " - Buzz";
                Console.WriteLine(j + fizzBuzz);
                fizzBuzz = " ";
            }
           

            Random random = new Random();
            int current = random.Next(1, 11);

            do
            {
                current = random.Next(1, 11);

                if (current >= 8) continue;

            } while (current != 7);

             
            Random daño = new Random();
            int dañoHeroe = 0;
            int dañoMonstruo = 0;

            int saludHeroe = 10;
            int saludMonstruo = 10;

            int it = 1;
            do
            {
                dañoHeroe = daño.Next(1,11);
                dañoMonstruo = daño.Next(1,11);

                if (it % 2 == 0)
                {
                    saludHeroe -= dañoMonstruo;
                    Console.WriteLine($"El héroe fue dañado con -{dañoMonstruo}, ahora su salud es de {saludHeroe}\n");
                    
                }
                else 
                {
                    saludMonstruo -= dañoHeroe;
                    Console.WriteLine($"El monstruo fue dañado con -{dañoHeroe}, ahora su salud es de {saludMonstruo}\n");
                }
                it++;

            }
            while (saludHeroe > 0 && saludMonstruo > 0);
            if (saludHeroe > 0)
                Console.WriteLine("El heroe ha ganado!");
            else if (saludMonstruo > 0)
                Console.WriteLine("El monstruo ha ganado!");
          
            //10 de octubre
            decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            int myInt = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");

            string first = "5";
            string second = "7";
            int sum = int.Parse(first) + int.Parse(second);
            Console.WriteLine(sum);
            
            // 12 de octubre

            SimuladorTragamonedas();

            static void SimuladorTragamonedas()
            {
                int opc;
                do
                {
                    Console.WriteLine("Simulador de Tragamonedas.");
                    Console.WriteLine("1) Jugar");
                    Console.WriteLine("2) Salir");
                    Console.Write("Elija una opción: ");
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            JugarTragamonedas();
                            break;
                        case 2:
                            Console.WriteLine("Salió del Tragamonedas.");
                            break;
                        default:
                            Console.WriteLine("Opción Irreconocida.");
                            break;
                    }
                } while (opc != 2);
            }

            static void JugarTragamonedas()
            {
                Random ran = new Random();
                int rn1 = ran.Next(1, 4);
                int rn2 = ran.Next(1, 4);
                int rn3 = ran.Next(1, 4);
                int[] listaAle = { rn1, rn2, rn3 };
                int numeralSum = 0;
                int porcentSum = 0;
                int dolarSum = 0;
                string cadenaCharRandom = "";

                foreach (int valor in listaAle)
                {
                    char valorCharRandom;
                    if (valor == 1)
                    {
                        numeralSum++;
                        valorCharRandom = '#';
                    }
                    else if (valor == 2)
                    {
                        porcentSum++;
                        valorCharRandom = '%';
                    }
                    else
                    {
                        dolarSum++;
                        valorCharRandom = '$';
                    }
                    cadenaCharRandom += valorCharRandom;
                }

                string premio;
                if (numeralSum == 2)
                    premio = "Ha ganado $50, #";
                else if (porcentSum == 2)
                    premio = "Ha ganado $50, %";
                else if (dolarSum == 2)
                    premio = "Ha ganado $50, $";
                else if (numeralSum == 3)
                    premio = "Ha ganado $100, ###";
                else if (porcentSum == 3)
                    premio = "Ha ganado $100, %%%";
                else if (dolarSum == 3)
                    premio = "Ha ganado $100, $$$";
                else
                    premio = "Sin premio, juegue de nuevo.";

                Console.WriteLine($"Los símbolos generados son: {cadenaCharRandom}");
                Console.WriteLine(premio);
            }
            // 13 de octubre
            string[] pallets = { "B14", "A12", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            
           
            string[] pallets = {"B14", "A11", "B12", "A13" };
            
            Array.Sort(pallets);
            foreach (string pallet in pallets)
            {
                Console.WriteLine(pallet);
            }

            Array.Clear(pallets,2,2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            string str1 = "So, let's go";
            char[] chars = str1.ToCharArray();
            Console.Write(chars);

            Console.WriteLine("\n");

            Array.Reverse(chars);

            Console.Write(chars);

            Console.WriteLine("\n");

            string space = String.Join(" ", chars);
            Console.WriteLine(space);

            string[] spli = space.Split("e");
            foreach (string s in spli)
            {
                Console.Write(s);
            }
            
            
            string result = null;
            string str = "The quick brown fox jumps over the lazy dog";
            string[] arrayStr = str.Split(' ');

            foreach (string minArrayStr in arrayStr)
            {
                string[] arrayMins = { minArrayStr };
                foreach (string arrayMins2 in arrayMins)
                {
                    string[] palabras = { arrayMins2 };
                    
                    foreach (string arrayMins3 in palabras)
                    {
                        char[] chars = arrayMins3.ToCharArray();
                        Array.Reverse(chars);
                        foreach(char c in chars)

                            Console.Write(c + " ");
                    }
                }
            }
            */
            // 15 de octubre
            // Métodos void y tipos de valores y por referencia.
            // 21 de octubre
            /*
            Random random = new Random();

            Console.WriteLine("Would you like to play? (Y/N)");
            char opc = char.Parse(Console.ReadLine());
            bool firstPlay = opc == 'Y' ? true : false;

            static bool ShouldPlay(bool firstPlay, char opc)
            {
                opc = char.Parse(Console.ReadLine());
                firstPlay = opc == 'Y' ? true : false;
                if (firstPlay) return true;
                else return false; 
                
            }

            if (ShouldPlay(firstPlay, opc))
            {
                PlayGame();
            }

            void PlayGame()
            {
                var play = true;

                while (play)
                {
                    int target = random.Next(1,6);
                    int roll = random.Next(1,6);
                    static string WinOrLose(int target, int roll)
                    {
                        string result = null;
                        if (roll > target)
                             result = "Great, you is the winner.";
                        else
                             result = "Pitty, you is the looser.";
                        return result;

                    }
                    Console.WriteLine($"Roll a number greater than {target} to win!");
                    Console.WriteLine($"You rolled a {roll}");
                    Console.WriteLine(WinOrLose(target, roll));
                    Console.WriteLine("\nPlay again? (Y/N)");

                    play = ShouldPlay(firstPlay, opc);

                    */
            
                    // 4 de noviembre
                    var apple = new { Item = "apples", Price = 1.35 };
                    var onSale = apple with { Price = 1.30 } with { Item = "banana" };
                    Console.WriteLine(apple);


        }
    }

}
