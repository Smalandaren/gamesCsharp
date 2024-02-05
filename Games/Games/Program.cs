using System;
using System.Runtime.InteropServices;

namespace games
{
    public class Games
    {
        public static String[] games = { "Overwatch", "Fortnite", "Minecraft" };
        public static void Main(String[] args)
        {


            Console.WriteLine("Vad vill du göra?\n" +
                "1. Skriv ut listan\n" +
                "2. Räkna listan\n" +
                "3. Sortera listan\n" +
                "4. Söka/lägga till");

            String choice = Console.ReadLine();

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

                    break;
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
            return games.Length;
        }

        public static String[] Sort()
        {
            Array.Sort(games);
            return games;
        }

    }
}