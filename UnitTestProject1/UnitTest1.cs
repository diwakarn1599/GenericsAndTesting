using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsAndTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        MaxOfThree maxOfThree;
        [TestInitialize]
        public void SetUp()
        {
            maxOfThree = new MaxOfThree();
        }
        [TestMethod]
        public void TestMethod1()
        {
            //initializing variables
            int num1, num2, num3, actual, expected;
            //TC 1.1
            //Arrange
            num1 = 45; num2 = 35; num3 = 40;
            expected = num1;
            //Act
            actual = maxOfThree.MaxOfThreeNumbers(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);

            //TestCase 1.2
            //Arrange
            num1 = 35; num2 = 45; num3 = 40;
            expected = num2;
            //Act
            actual = maxOfThree.MaxOfThreeNumbers(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);

            //Tc 1.3
            //Arrange
            num1 = 35; num2 = 40; num3 = 45;
            expected = num3;
            //Act

            actual = maxOfThree.MaxOfThreeNumbers(num1, num2, num3);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
