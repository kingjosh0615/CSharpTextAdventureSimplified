using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpTextAdventureSimplified
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.ForegroundColor = (ConsoleColor.Red);
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.WriteLine("Type YES or NO: ");
            string noiseChoice = Console.ReadLine().ToLower();

            if (noiseChoice == "no")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room! THE END.");
            }

            else if (noiseChoice == "yes")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
                Console.WriteLine("Type OPEN or KNOCK:");
                string doorChoice = Console.ReadLine().ToLower();
                if (doorChoice == "knock")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \" \"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                    string riddleAnswer = Console.ReadLine().ToLower();
                    if (riddleAnswer == "nothing")
                    {
                        Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door. THE END.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open. THE END.");
                        Console.ReadLine();
                    }

                }
                else if (doorChoice == "open")
                {
                    Console.WriteLine("The door is locked! You choose a key at random.");
                    Console.WriteLine("You choose ...");
                    Thread.Sleep(5000);
                    string keyChoice = Convert.ToString(Math.Floor(Convert.ToDouble(rand.Next(1, 4))));
                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange... THE END.");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.");
                            BreakDownDoor();
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open.");
                            BreakDownDoor();
                            break;
                    }
                    Console.ReadLine();
                }
            }
        }
        public static void BreakDownDoor()
        {
            string userChoice1;
            bool doorStanding = true;
            string[] tools = { "hammer", "sledgehammer", "gun", "axe", "fireaxe", "foot", "kick", "punch", "headbutt", "chainsaw", "karate", "sword", "battleaxe", "ram", "battering ram", "fire extinguisher", "hydraulic jack", "stand", "jump kick", "ninja", "karate chop", "crowbar", "c4", "lever", "bomb"};
            Console.WriteLine("Would you like to try and break down the door?");
            userChoice1 = (Console.ReadLine()).ToLower();
            if (userChoice1 == "yes")
            {
                while (doorStanding)
                {
                    Console.WriteLine("What will you use to break down door?");
                    userChoice1 = Console.ReadLine();
                    if (Array.Exists(tools, element => element == userChoice1.ToLower()))
                    {
                        Console.WriteLine($"You make a huge ruckus trying to break down the door using {userChoice1}. Your parents wake up and yell at you. You are now grounded for 2 weeks. THE END.");
                        doorStanding = false;
                    }
                    else
                    {
                        Console.WriteLine("You don't happen to have that tool lying around.");
                    }
                }
            }
            else if (userChoice1 == "no")
            {
                Console.WriteLine("You walk back to your room and play on your Nintendo. THE END.");
            }
            else
            {
                BreakDownDoor();
            }
        }
    }
}
