using System;
using System.IO;
using NUnit.Framework;
using BackPackFlyWeight;
using Moq;


namespace BackPackFlyWeightTest
{
    [TestFixture]
    public class MounatainBackPackTest
    {
        private MountainBackPack _mountainBackPack;

        [SetUp]
        public void SetUp()
        {
            _mountainBackPack = new MountainBackPack();
        }

        [Test]
        public void CreateWithWeight7AndSize70()
        {
            //Arrange
            float weightKg = 7;
            float sizeLitr = 70;
            //Assert
            Assert.AreEqual(_mountainBackPack.Weight, weightKg);
            Assert.AreEqual(_mountainBackPack.Size, sizeLitr);
        }

        [Test]
        public void PutOnWriteText()
        {
            //Arrange
            ConsoleColor color = ConsoleColor.Blue;
            string name = "test";
            string outString= "The Blue mountain backpack was put on test. Weight is 7. Size is 70";
            var mockWriter = new Mock<TextWriter>();
            mockWriter.Setup(writer => writer.WriteLine(outString));
            Console.SetOut(mockWriter.Object);

            //Act
           _mountainBackPack.PutOn(color, name);

            //Assert
            mockWriter.Verify();
        }
    }
}
