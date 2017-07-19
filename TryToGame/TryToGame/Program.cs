using System;
using Mono.Options;

namespace TryToGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ints:
            int correct = 0;
            int PlayerOneHanded = 0;
            int PlayerTwoHanded = 0;
            int PlayerRanged = 0;
            int PlayerMagic = 0;
            //Strings:
            string Gender;
            string Race;
            string Class;



            //Character creation:
            do
            {
                Console.Clear();
                Console.WriteLine("Please choose a gender from below:");
                Console.WriteLine("Male/Female");
                Gender = Console.ReadLine().ToUpper();
                if (Gender == "MALE")
                {
                    correct = 1;
                }
                if (Gender == "FEMALE")
                {
                    correct = 1;
                }
                else
                {

                }
            } while (correct == 0);
            correct = 0;

            //Race Creation:
            do
            {
                Console.Clear();
                Console.WriteLine("Please choose a race from below:");
                Console.WriteLine("Human");
                Console.WriteLine("Dwarf");
                Console.WriteLine("Elf");
                Console.WriteLine("Orc");
                Console.WriteLine("Psychopath");
                Race = Console.ReadLine().ToUpper();
                if (Race == "HUMAN" || Race == "DWARF" || Race == "ELF" || Race == "ORC" || Race == "PSYCHOPATH")
                {
                    correct = 1;
                }
                else
                {

                }
            } while (correct == 0);
            correct = 0;



            //Class creation:
            do
            {
                Console.Clear();
                Console.WriteLine("Please choose a class from below:");
                Console.WriteLine("Warrior");
                Console.WriteLine("Hunter");
                Console.WriteLine("Mage");
                Console.WriteLine("Thief");
                Console.WriteLine("Whore");
                Class = Console.ReadLine().ToUpper();
                if (Class == "WARRIOR" || Class == "HUNTER" || Class == "MAGE" || Class == "THIEF" || Class == "WHORE")
                {
                    correct = 1;
                }
                else
                {

                }
            } while (correct == 0);
            correct = 0;

            //Confirm that is what you chose:
            Console.Clear();
            Console.WriteLine("Your gender is: " + Gender);
            Console.WriteLine("Your race is: " + Race);
            Console.WriteLine("Your class is: " + Class);
            /*Console.Write("Press enter to continue...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {

            }*/

            //Bonuses:
            //Gender Bonuses:
            if (Gender == "MALE")
            {
                PlayerOneHanded += 1;
                PlayerTwoHanded += 1;
                PlayerRanged += 0;
                PlayerMagic += 0;
            }
            if (Gender == "FEMALE")
            {
                PlayerOneHanded += 0;
                PlayerTwoHanded += 0;
                PlayerRanged += 1;
                PlayerMagic += 1;
            }
            //Race Bonuses:
            if (Race == "HUMAN")
            {
                PlayerOneHanded += 1;
                PlayerTwoHanded += 1;
                PlayerRanged += 1;
                PlayerMagic += 1;
            }
            if (Race == "DWARF")
            {
                PlayerOneHanded += 1;
                PlayerTwoHanded += 2;
                PlayerRanged += 1;
                PlayerMagic += 0;
            }
            if (Race == "ELF")
            {
                PlayerOneHanded += 1;
                PlayerTwoHanded += 0;
                PlayerRanged += 2;
                PlayerMagic += 1;
            }
            if (Race == "ORC")
            {
                PlayerOneHanded += 2;
                PlayerTwoHanded += 2;
                PlayerRanged += 0;
                PlayerMagic += 0;
            }
            if (Race == "PSYCHOPATH")
            {
                PlayerOneHanded += 0;
                PlayerTwoHanded += 0;
                PlayerRanged += 2;
                PlayerMagic += 2;
            }
            //Class Bonuses:
            if (Class == "WARRIOR")
            {
                PlayerOneHanded += 2;
                PlayerTwoHanded += 2;
                PlayerRanged += 0;
                PlayerMagic += 0;
            }
            if (Class == "HUNTER")
            {
                PlayerOneHanded += 1;
                PlayerTwoHanded += 1;
                PlayerRanged += 2;
                PlayerMagic += 0;
            }
            if (Class == "MAGE")
            {
                PlayerOneHanded += 1;
                PlayerTwoHanded += 0;
                PlayerRanged += 1;
                PlayerMagic += 2;
            }
            if (Class == "THIEF")
            {
                PlayerOneHanded += 2;
                PlayerTwoHanded += 0;
                PlayerRanged += 1;
                PlayerMagic += 1;
            }
            if (Class == "WHORE")
            {
                PlayerOneHanded += 1;
                PlayerTwoHanded += 1;
                PlayerRanged += 0;
                PlayerMagic += 2;
            }


            //Showing Player Stats:
            Console.WriteLine("Your one handed weapon skills: " + PlayerOneHanded);
            Console.WriteLine("Your two handed weapon skills: " + PlayerTwoHanded);
            Console.WriteLine("Your ranged weapon skills:     " + PlayerRanged);
            Console.WriteLine("Your magic skills:             " + PlayerMagic);
            Console.Write("Press enter to continue...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {

            }


            
        }
    }
}