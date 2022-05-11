using NUnit.Framework;
using System.Linq;

namespace Summator.Tests
{
    [TestFixture]
    public class SummatorTests
    {

        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7 });

            int expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        [Category ("Critical")]
        public void Test_Sum_MultiplePossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7, 8, 9, 10 });

            int expected = 39;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            long actual = Summator.Sum(new int[] { 5 });

            Assert.That(actual == 5);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = Summator.Sum(new int[] { -7, -9 });

            Assert.That(actual == -16);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = Summator.Sum(new int[] { });

            Assert.That(actual == 0);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(6000000000, actual);
        }

        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
            long actual = Summator.Average(new int[] { 5, 7 });

            int expected = 6;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_TwoPossitiveNumbersAAA()
        {
            // Arrange
            var values = new int[] { 5, 7 };
            int expected = 12;

            // Act
            long actual = Summator.Sum(values);

            // Assert
            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Assertions()
        {
            var values = new int[] { 5, 7 };
            int expected = 12;
            long actual = Summator.Sum(values);

            Assert.That(expected == actual, "Summator value should be equal to 12");
            Assert.That(expected, Is.EqualTo(actual));
            Assert.AreEqual(expected, actual);

            double percentage = 99.95;
            Assert.That(percentage, Is.InRange(80, 100));

            Assert.That("QAs are awesome", Does.Contain("awesome"));

            Assert.That(Enumerable.Range(1, 100), Has.Member(5));
        }

    }
}