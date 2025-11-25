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
            int[] numbers = new[] { 45, 67, 8, 11, 34 };

            // Act
            var min = Helpers.GetMinElement(numbers);

            // Assert
            Assert.AreEqual(8, min);
        }

        [TestMethod]
        public void TestGetMinElement_EmptyArray_Throws()
        {
            // Arrange
            int[] numbers = new int[0];

            // Act & Assert
            Assert.ThrowsException<System.ArgumentException>(() => Helpers.GetMinElement(numbers));
        }

        [TestMethod]
        public void TestGetMinElement_Null_Throws()
        {
            // Act & Assert
            Assert.ThrowsException<System.ArgumentNullException>(() => Helpers.GetMinElement(null!));
        }
    }
}