using System;

namespace BotDeliverable1
{
        class Program
        {

            static void Main(string[] args)
            {

                Console.WriteLine("Welcome to Chatter Bot!");


                bool askAgain = true;

                while (askAgain == true)
                {
                    string a = "hello";
                    string b = "bye";
                    string c = "sup";
                    string d = "hello there";

                    string e = "Hi, good to see you";
                    string f = "Good bye!";
                    string g = "I am good";
                    string h = "General Kenobi";

                    Console.WriteLine("What would you like to say? ");
                    string input = Console.ReadLine();
                    string input2 = input.ToLower();

                    if (input2 == a)
                    {
                        Console.WriteLine(e);
                    }
                    else if (input2 == b)
                    {
                        Console.WriteLine(f);
                        break;
                    }
                    else if (input2 == c)
                    {
                        Console.WriteLine(g);
                    }
                    else if (input2 == d)
                    {
                        Console.WriteLine(h);
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, but you have already said that");
                    }
                    try
                    {

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("I'm sorry, but you have already said that");

                    }
                }

            }
        }
    }

