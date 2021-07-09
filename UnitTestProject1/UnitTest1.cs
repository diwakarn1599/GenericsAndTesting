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
            double num1, num2, num3, actual, expected;
            //TC 1.1
            //Arrange
            num1 = 4.5; num2 = 3.5; num3 = 4.0;
            expected = num1;
            //Act
            actual = maxOfThree.MaxOfThreeNumbers(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);

            //TestCase 1.2
            //Arrange
            num1 = 3.5; num2 = 4.5; num3 = 4.0;
            expected = num2;
            //Act
            actual = maxOfThree.MaxOfThreeNumbers(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);

            //Tc 1.3
            //Arrange
            num1 = 3.5; num2 = 4.0; num3 = 4.5;
            expected = num3;
            //Act

            actual = maxOfThree.MaxOfThreeNumbers(num1, num2, num3);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
