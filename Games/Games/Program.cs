using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace games
{
    public class Games
    {
        public static ArrayList games = new ArrayList()/*{ "Overwatch", "Fortnite", "Minecraft" }*/;
        
        public static void Main(String[] args)
        {
            games.Add("Overwatch");
            games.Add("Fortnite");
            games.Add("Minecraft");

            bool on = true;
            while (on)
            {
                

                Console.WriteLine("Vad vill du göra?\n" +
                    "1. Skriv ut listan\n" +
                    "2. Räkna listan\n" +
                    "3. Sortera listan\n" +
                    "4. Söka/lägga till\n" +
                    "5. Avsluta");


                String choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine(Print());
                        break;

                    case "2":
                        Console.WriteLine(Count());
                        break;

                    case "3":
                        Sort();
                        Console.WriteLine(Print());
                        break;

                    case "4":
                        Search();
                        break;

                    case "5":
                        on = false;
                        break;
                }
            }

        }

        public static String Print() 
        {
            String readableList = "";

            foreach (String s in games)
            {
                readableList += s + ", ";
                
            }
            return readableList;
        }

        public static int Count()
        {
            return games.Count;
        }

        public static ArrayList Sort()
        {
            games.Sort();
            return games;
        }

        public static void Search()
        {
            Console.WriteLine("Vilket spel vill du söka efter?");
            String searchWord = Console.ReadLine();
            if (games.Contains(searchWord))
            {
                Console.WriteLine("Spelet finns i listan");
            }   
            else
            {
                Console.WriteLine("Spelet finns inte i listan, vill du lägga till det?");
                String answer = Console.ReadLine();
                if (answer.ToLower().Equals("ja"))
                {
                    Console.WriteLine("Adding");
                    games.Add(searchWord);
                }
                Console.Clear();
            }
        }

    }
}