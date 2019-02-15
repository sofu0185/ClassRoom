using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoom;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestStuderende
    {
        [DataTestMethod]
        [DataRow(12)]
        [DataRow(1)]
        [DataRow(2)]
        public void Årstid_WinterMonth_ReturnsVinter(int testValue)
        {
            //Arrange
            studerende s = new studerende("", testValue, 5);
            string expected = "Vinter";
            string actual = "";

            //Act
            actual = s.Årstid();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        public void Årstid_SpringMonth_ReturnForår(int testValue)
        {
            //Arrange
            studerende s = new studerende("", testValue, 5);
            string expected = "Forår";
            string actual = "";

            //Act
            actual = s.Årstid();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        public void Årstid_SummerMonth_ReturnSommer(int testValue)
        {
            //Arrange
            studerende s = new studerende("", testValue, 5);
            string expected = "Sommer";
            string actual = "";

            //Act
            actual = s.Årstid();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(11)]
        public void Årstid_FallMonth_ReturnEfterår(int testValue)
        {
            //Arrange
            studerende s = new studerende("", testValue, 5);
            string expected = "Efterår";
            string actual = "";

            //Act
            actual = s.Årstid();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(13)]
        [DataRow(-1)]
        [ExpectedException(typeof(ArgumentException))]
        public void FødselsMånedSet_NonValidSeason_ThrowsArgumentException(int testValue)
        {
            //Arrange, Act & Assert
            studerende s = new studerende("", testValue, 5);
        }
    }
}
