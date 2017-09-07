using BackPackFlyWeight;
using NUnit.Framework;

namespace BackPackFlyWeightTest
{
    [TestFixture]
    public class BackPackFactoryTest
    {
        private BackPackFactory _backPackFactory;
       
        [SetUp]
        public void SetUp()
        {
            _backPackFactory = new BackPackFactory();
        }

        [Test]
        public void FactoryHasAtLeastOneCityBackPackObject()
        {
            //Arrange
            BackPack backPack = _backPackFactory.GetBackPack("city");
           
            //Assert
            Assert.AreEqual(backPack.GetType(), typeof(CityBackPack));
        }

        [Test]
        public void FactoryHasAtLeastOneMountainBackPackObject()
        {
            //Arrange
            BackPack backPack = _backPackFactory.GetBackPack("mountain");

            //Assert
            Assert.AreEqual(backPack.GetType(), typeof(MountainBackPack));
        }


        [Test]
        public void ReturnCityBackPackObjectFor2Times()
        {
            //Arrange
            BackPack cityBackPack1 = _backPackFactory.GetBackPack("city");
            BackPack cityBackPack2 = _backPackFactory.GetBackPack("city");

            //Assert
            Assert.AreEqual(cityBackPack1.GetHashCode(), cityBackPack2.GetHashCode());
        }

        [Test]
        public void ReturnMountainBackPackObjectFor2Times()
        {
            //Arrange
            BackPack mountainBackPack1 = _backPackFactory.GetBackPack("mountain");
            BackPack mountainBackPack2 = _backPackFactory.GetBackPack("mountain");

            //Assert
            Assert.AreEqual(mountainBackPack1.GetHashCode(), mountainBackPack2.GetHashCode());
        }
    }
}
