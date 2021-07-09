using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsAndTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        MaxOfThree<int> findMaxInt;
        MaxOfThree<string> findMaxString;
        MaxOfThree<double> findMaxDouble;
        MaxOfThree<int> findMaxArray;
        int[] array = {5,4,3,2,1};
        [TestInitialize]
        public void SetUp()
        {
            //arrange
            findMaxInt = new MaxOfThree<int>(10, 20, 30);
            findMaxString = new MaxOfThree<string>("xyz","abc", "def");
            findMaxDouble = new MaxOfThree<double>(1.0, 2.0, 3.0);
            findMaxArray = new MaxOfThree<int>(array);

        }
        [TestMethod]
        public void TestMethod1()
        {

            //TC int
            //Arrange
            int expectedInt = 30,actualInt;
            //Act
            actualInt = findMaxInt.MaxOfThreeNumbers();
            //Assert
            Assert.AreEqual(actualInt, expectedInt);

            //TestCase string
            //Arrange
            string expectedString = "xyz", actualString;
            //Act
            actualString = findMaxString.MaxOfThreeNumbers();
            //Assert
            Assert.AreEqual(actualString, expectedString);

            //Tc 1.3
            //Arrange
            double expectedDouble = 3.0, actualDouble;
            //Act
            actualDouble = findMaxDouble.MaxOfThreeNumbers();
            //Assert
            Assert.AreEqual(actualDouble, expectedDouble);


            //Array
            var actual = findMaxArray.FindMaxOfArray();
            var expected = 5;
            Assert.AreEqual(actual, expected);

        }
    }
}
