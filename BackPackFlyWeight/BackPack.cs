using System;

namespace BackPackFlyWeight
{
    public abstract class BackPack
    {
     

        public double Weight { get; set; }
        public double Size { get; set; }

        public abstract void PutOn(ConsoleColor color, string name);
    }
}