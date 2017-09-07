using System;
using System.IO;
using BackPackFlyWeight;
using NUnit.Framework;
using Moq;

namespace BackPackFlyWeightTest
{
    [TestFixture]
    public class CityBackPackTest
    {
        private CityBackPack _cityBackPack;
        //Arrange
        private double _weightKg;
        private double _sizeLitr;

        [SetUp]
        public void SetUp()
        {
            _weightKg = 0.7;
            _sizeLitr = 30;
            _cityBackPack = new CityBackPack();
        }

        [Test]
        public void CreateWithWeight0_7AndSize30()
        {
            //Assert
            Assert.AreEqual(_cityBackPack.Weight, _weightKg);
            Assert.AreEqual(_cityBackPack.Size, _sizeLitr);
        }

        [Test]
        public void PutOnWriteText()
        {
            //Arrange
            ConsoleColor color = ConsoleColor.Blue;
            string name = "test";
            string outString = "The Blue mountain backpack was put on test. Weight is 0.7. Size is 30";
            var mockWriter = new Mock<TextWriter>();
            mockWriter.Setup(writer => writer.WriteLine(outString));
            Console.SetOut(mockWriter.Object);

            //Act
            _cityBackPack.PutOn(color, name);

            //Assert
            mockWriter.Verify();
        }
    }
}
