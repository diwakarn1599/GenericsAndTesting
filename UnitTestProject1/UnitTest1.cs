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
            string num1, num2, num3, actual, expected;
            //TC 1.1
            //Arrange
            num1 = "xyz"; num2 = "def"; num3 = "abc";
            expected = num1;
            //Act
            actual = maxOfThree.MaxOfThreeNumbers(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);

            //TestCase 1.2
            //Arrange
            num1 = "abc"; num2 = "xyz"; num3 = "def";
            expected = num2;
            //Act
            actual = maxOfThree.MaxOfThreeNumbers(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);

            //Tc 1.3
            //Arrange
            num1 = "def"; num2 = "abc"; num3 = "xyz";
            expected = num3;
            //Act

            actual = maxOfThree.MaxOfThreeNumbers(num1, num2, num3);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
