using System;
using System.Collections.Generic;
using BackPackFlyWeight;

namespace BackPackFlyWeight
{
    class Program
    {
        static void Main()
        {
            BackPackFactory factory=new BackPackFactory();
            List<string> people = new List<string>
            {
                "Peter",
                "Hans",
                "Aleh",
                "Jhon",
                "Nick"
            };
            string typeBackPack = "city";
            List<ConsoleColor> colors=new List<ConsoleColor>{ ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.DarkGreen};
            foreach (string person in people)
            {
                foreach (ConsoleColor color in colors)
                {
                    BackPack backPack =factory.GetBackPack(typeBackPack);
                    typeBackPack=typeBackPack == "city"?"mountain": "city";
                    backPack.PutOn(color, person);
                }
            }
            Console.ReadKey();
        }
    }
}
