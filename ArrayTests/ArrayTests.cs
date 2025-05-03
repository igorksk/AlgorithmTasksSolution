using ArrayMinElement;

namespace ArrayTests
{
    [TestClass]
    public class ArrayTests
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