using System;


namespace BackPackFlyWeight
{
    public class MountainBackPack: BackPack
    {
        public MountainBackPack()
        {
            Weight = 7;
            Size = 70;
        }

        public override void PutOn(ConsoleColor color, string name)
        {

            Console.WriteLine($"The {color} mountain backpack was put on {name}. Weight is {Weight}. Size is {Size}");
        }
    }
}