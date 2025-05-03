using ArrayMinElement;

namespace Tests
{
    [TestClass]
    public class ArrayMinElementTests
    {
        [TestMethod]
        public void TestGetMinElement()
        {
            // Arrange
            int[] numbers = [45, 67, 8, 11, 34] ;

            // Act
            var min = Helpers.GetMinElement(numbers);

            // Assert
            Assert.AreEqual(8, min);
        }
    }
}