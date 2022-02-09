using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestLandingArea
{
    [TestClass]
    public class LandUnitTest
    {
        [TestMethod]
        public void CanLand_1_1_TestMethod()
        {
            //Arrange
            var obj = LandingArea.Landing.GetInstance;



            //Act
            var actual = obj.canLand(1, 1);
            var expected = "Out Of Platform";

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CanLand_5_5_TestMethod()
        {
            //Arrange
            var obj = LandingArea.Landing.GetInstance;



            //Act
            var actual = obj.canLand(5, 5);
            var expected = "Ok Landing";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanLand_15_15_TestMethod()
        {
            //Arrange
            var obj = LandingArea.Landing.GetInstance;



            //Act
            var actual = obj.canLand(15, 15);
            var expected = "Ok Landing";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanLand_7_7_TestMethod()
        {
            //Arrange
            var obj = LandingArea.Landing.GetInstance;

            //Act
            obj.LandRocket(7, 7);
            var actual = obj.canLand(7, 7);
            var expected = "Clash";

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CanLand_7_8_TestMethod()
        {
            //Arrange
            var obj = LandingArea.Landing.GetInstance;

            //Act
            obj.LandRocket(7, 7);
            var actual = obj.canLand(7, 8);
            var expected = "Clash";

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
