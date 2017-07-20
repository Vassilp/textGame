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
            string[] Inventory = new string[20];
            string Input;



            //Character creation:
            do
            {
                //Console.Clear();
                Console.WriteLine("Please choose a gender from below:");
                Console.WriteLine("Male/Female");
                Gender = Console.ReadLine().ToUpper();
                if (Gender == "MALE")
                {
                    correct = 1;
                }
                else if (Gender == "FEMALE")
                {
                    correct = 1;
                }
                else
                {
                    Console.Clear();
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
                //Console.WriteLine("Psychopath");
                Race = Console.ReadLine().ToUpper();
                if (Race == "HUMAN")
                {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 1 Point");
                    Console.WriteLine("Ranged Weapons.     1 Point");
                    Console.WriteLine("Magical Attack.     1 Point");
                    Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }

                if (Race == "DWARF")
                {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 2 Point");
                    Console.WriteLine("Ranged Weapons.     1 Point");
                    Console.WriteLine("Magical Attack.     0 Point");
                    Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }

                if (Race == "ELF")
                {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 0 Point");
                    Console.WriteLine("Two Handed Weapons. 1 Point");
                    Console.WriteLine("Ranged Weapons.     2 Point");
                    Console.WriteLine("Magical Attack.     1 Point");
                    Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }

                if (Race == "ORC")
                {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 2 Point");
                    Console.WriteLine("Two Handed Weapons. 2 Point");
                    Console.WriteLine("Ranged Weapons.     0 Point");
                    Console.WriteLine("Magical Attack.     0 Point");
                    Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "PSYCHOPATH")
                {
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 0 Point");
                    Console.WriteLine("Two Handed Weapons. 0 Point");
                    Console.WriteLine("Ranged Weapons.     2 Point");
                    Console.WriteLine("Magical Attack.     2 Point");
                    Console.WriteLine("This is the hidden Race, so you surely want to keep it, but just in case...");
                    Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                else
                {
                    Console.Clear();
                }
            } while (correct == 0);
            correct = 0;



            //Class creation:
            do
            {
                //Console.Clear();
                Console.WriteLine("Please choose a class from below:");
                Console.WriteLine("Warrior");
                Console.WriteLine("Hunter");
                Console.WriteLine("Mage");
                Console.WriteLine("Thief");
                //Console.WriteLine("Bitch");
                Class = Console.ReadLine().ToUpper();
                if (Class == "WARRIOR")
                {
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 2 Point");
                    Console.WriteLine("Two Handed Weapons. 2 Point");
                    Console.WriteLine("Ranged Weapons.     0 Point");
                    Console.WriteLine("Magical Attack.     0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Class == "HUNTER")
                {
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 1 Point");
                    Console.WriteLine("Ranged Weapons.     2 Point");
                    Console.WriteLine("Magical Attack.     0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Class == "MAGE")
                {
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 0 Point");
                    Console.WriteLine("Ranged Weapons.     1 Point");
                    Console.WriteLine("Magical Attack.     2 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Class == "THIEF")
                {
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 2 Point");
                    Console.WriteLine("Two Handed Weapons. 0 Point");
                    Console.WriteLine("Ranged Weapons.     1 Point");
                    Console.WriteLine("Magical Attack.     1 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Class == "BITCH")
                {
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 1 Point");
                    Console.WriteLine("Ranged Weapons.     0 Point");
                    Console.WriteLine("Magical Attack.     2 Point");
                    Console.WriteLine("This is the hidden Class, so you surely want to keep it, but just in case...");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                else
                {
                    Console.Clear();
                }
            } while (correct == 0);
            correct = 0;

            //Confirm that is what you chose:
            //Console.Clear();
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
            if (Class == "BITCH")
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
            Console.WriteLine("Press enter to continue...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {

            }
            Console.Clear();


            Inventory[0] = "a";
            Inventory[1] = "severed penis";
            Inventory[2] = "turtle";

            //INVENTORY TEST
            Console.WriteLine("Inventory test: Type inventory below");
            Input = Console.ReadLine().ToUpper();
            while(correct == 0)
            {
                if(Input == "INVENTORY")
                {
                    //Console.Clear();
                    int free = 0;
                    Console.WriteLine("Your inventory contains:");
                    for (int Arraycount = 0; Arraycount < 20; Arraycount++)
                    {
                        if (Inventory[Arraycount] != null)
                        {
                            Console.WriteLine("----------");
                            Console.WriteLine("| " + Inventory[Arraycount]);

                        }
                        else
                        {
                            free++;
                        }
                    }
                    Console.WriteLine("----------\n\n");
                    Console.WriteLine("You have " + free + " free inventory spaces.\n\n");
                    correct = 1;
                }
                else
                {
                    Console.WriteLine("Incorrect input, please try again");
                    Input = Console.ReadLine().ToUpper();
                }

            }
            correct = 0;
            //INVENTPRY TEST END
            Console.WriteLine("Press enter to continue...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {

            }


        }
    }
}