using System;

namespace numberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameAutor = "Mateusz Solarczyk";
            int version = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Autor:{nameAutor}, Version:0.0.{version}");
            Console.ForegroundColor = ConsoleColor.Gray;
            bool x = false;
            while (x == false)
            {
                Console.WriteLine("Welcom, can you play game with me? :-)(Y =Yes / N =No) ");
                string a = Console.ReadLine();
                if (a == "N" || a == "n")
                {
                    Console.WriteLine("Okey, good bye :-)");
                    Environment.Exit(0);
                }
                if (a == "y" || a == "Y")
                {
                    int max = 10, min = 1;

                    Console.WriteLine("Wanderfull, lets play");
                    Console.WriteLine($"Here is the rules: i choose one number between {min} and {max} ");
                    Console.WriteLine("You, however must try gues what a numebr is(I will help you, I will tell you 'more' if you tell not enough or 'less' if you tell too much)");
                    Random generator = new Random();
                    int number = generator.Next(max + 1);

                    Console.WriteLine("I thinking about someone number what is it?");
                    string gues = "";
                    while (true)
                    {  int q = 0;
                        gues = Console.ReadLine();
                        if (true == int.TryParse(gues, out q))
                        {
                          
                            if (q == number)
                            {
                                Console.WriteLine("wonderfull, You do it :-) ");
                                Environment.Exit(0);
                            }
                            if (q > number)
                                Console.WriteLine("less");
                            else
                                Console.WriteLine("more");
                        }
                        else
                            Console.WriteLine($"You must tell number between {min} and {max}");

                    }
                }
            }
        }
    }
}
