using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace games
{
    public class Games
    {
        public static Dictionary<String, String> games = new Dictionary<String, String>()/*{ "Overwatch", "Fortnite", "Minecraft" }*/;
        
        public static void Main(String[] args)
        {
            games.Add("Overwatch", "Blizzard");
            games.Add("Fortnite", "Epic Games");
            games.Add("Minecraft", "Mojang");
            
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

            foreach (KeyValuePair<String, String> s in games)
            {
                readableList += s.Key + ": " + s.Value + "\n";
                
            }
            return readableList;
        }

        public static int Count()
        {
            return games.Count;
        }

        public static Dictionary<String, String> Sort()
        {
            /*
            games.Sort();*/
            Console.WriteLine("Du kan inte sorta en dictionary");
            return games;
        }

        public static void Search()
        {
            Console.WriteLine("Vad vill du söka efter?");
            String searchWord = Console.ReadLine();
            if (games.Keys.Contains(searchWord))
            {
                Console.WriteLine("Spelet finns i listan");
            }   
            else if(games.Values.Contains(searchWord))
            {
                Console.WriteLine("Företaget finns i listan");
            }
            else
            {
                Console.WriteLine("Det finns inte i listan, vill du lägga till det?");
                String answer = Console.ReadLine();
                if (answer.ToLower().Equals("ja"))
                {
                    Console.WriteLine("Är det ett spel eller företag?");
                    
                    Console.WriteLine("Vilket företag har utvecklat spelet?");
                    String searchedCompany = Console.ReadLine();
                    Console.WriteLine("Adding");
                    games.Add(searchWord, searchedCompany);
                }
                Console.Clear();
            }
        }

    }
}