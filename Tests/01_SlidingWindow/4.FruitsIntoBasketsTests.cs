using ADS.SlidingWindow;
using NUnit.Framework;

namespace Tests.SlidingWindow
{
    public static class FruitsIntoBasketsSetTests
    {
        [TestFixture]
        public class FruitsIntoBasketsTests
        {
            [Test]
            [TestCase(new[] { 1, 2, 1 }, 3)]
            [TestCase(new[] { 0, 1, 2, 2 }, 3)]
            [TestCase(new[] { 1, 2, 3, 2, 2 }, 4)]
            public void FruitsIntoBasket_WhenCalled_ReturnTheMaxNumberOfFruits(int[] fruits, int expectedResult)
            {
                var result = FruitsIntoBaskets.FruitsIntoBasketsSolution(fruits);

                Assert.That(result, Is.EqualTo(expectedResult));
            }
        }
    }
}