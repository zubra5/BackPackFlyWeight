using System.Collections.Generic;

namespace BackPackFlyWeight
{
    public class BackPackFactory
    {
        private readonly Dictionary<string, BackPack> _backPacks;



        public BackPackFactory()
        {
            _backPacks = new Dictionary<string, BackPack>
            {
                { "city", new CityBackPack() },
                { "mountain", new MountainBackPack() }
            };

        }

        public BackPack GetBackPack(string key)
        {
            BackPack result = null;
            if (_backPacks.ContainsKey(key))
            {
                result= _backPacks[key];
            }
            return result;
        }
    }
}
 