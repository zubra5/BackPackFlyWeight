using System;

namespace BackPackFlyWeight
{
    public class CityBackPack:BackPack
    {
        public CityBackPack()
        {
            Weight = 0.7;
            Size = 30;
        }

        public override void PutOn(ConsoleColor color, string name)
        {
            Console.WriteLine($"The {color} mountain backpack was put on {name}. Weight is {Weight}. Size is {Size}");
        }
    }
}