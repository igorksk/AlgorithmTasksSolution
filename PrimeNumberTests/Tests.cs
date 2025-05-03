using PrimeNumberSeries;

namespace PrimeNumberTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CreatePrimeNumbersSequence_ReturnsCorrectPrimesForN()
        {
            //TEST 1

            // Arrange
            uint n = 5;

            // Act
            var primes = PrimeNumbersHelpers.CreatePrimeNumbersSequence(n);

            // Assert
            CollectionAssert.AreEqual(new List<uint> { 2, 3, 5, 7, 11 }, primes);

            //TEST 2

            // Arrange
            n = 0;

            // Act
            primes = PrimeNumbersHelpers.CreatePrimeNumbersSequence(n);

            // Assert
            CollectionAssert.AreEqual(new List<uint> {}, primes);
        }

        [TestMethod]
        public void CreatePrimeNumbersSequence_IsPrimeNumberForN()
        {
            //TEST 1

            // Arrange
            uint n = 5;

            // Act
            var result = PrimeNumbersHelpers.IsPrimeNumber(n);

            // Assert
            Assert.IsTrue(result);

            //TEST 2

            // Arrange
            n = 6;

            // Act
            result = PrimeNumbersHelpers.IsPrimeNumber(n);

            // Assert
            Assert.IsFalse(result);
        }
    }
}