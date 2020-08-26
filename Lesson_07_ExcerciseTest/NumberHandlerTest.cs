using Lesson_07_Exercises.App;
using NUnit.Framework;
using System.Collections.Generic;

namespace Lesson_07_ExcerciseTest
{
    public class NumberHandlerTest
    {
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 3, 5 }, new int[] { })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2 })]
        [TestCase(new int[] { -2, -4, 0, 1, 2, 3 }, new int[] { -2, -4, 0, 2 })]
        public void GetEvenNumbers_Collection_Created(IEnumerable<int> testedNumbers, IEnumerable<int> expectedCollection)
        {
            // Arrange
            NumberHandler numberHandler = new NumberHandler();

            // Act
            IEnumerable<int> actualColection = numberHandler.GetEvenNumbers(testedNumbers);

            // Act & Assert
            Assert.AreEqual(expectedCollection, actualColection);
        }

        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 0 })]
        [TestCase(new int[] { 1 }, new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1 }, new int[] { 1, 2 }, new int[] { })]
        [TestCase(new int[] { 1, 2 }, new int[] { 1 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 1, 2 }, new int[] { 2 })]
        [TestCase(new int[] { 2, 4, 6, 8, 10, 11, 12, 13, 15, 16 }, new int[] { 2 }, new int[] { 2, 4, 6, 8, 10, 12, 16 })]
        [TestCase(new int[] { 2, 4, 6, 8, 10, 11, 12, 13, 15, 16 }, new int[] { 2, 3, 4 }, new int[] { 12 })]

        public void GetNumbersDivisibleByAllDivisors_Collection_Created(IEnumerable<int> testedNumbers, IEnumerable<int> testedDivisors, IEnumerable<int> expectedCollection)
        {
            // Arrange
            NumberHandler numberHandler = new NumberHandler();

            // Act
            IEnumerable<int> actualColection = numberHandler.GetNumbersDivisibleByAllDivisors(testedNumbers, testedDivisors);

            // Act & Assert
            Assert.AreEqual(expectedCollection, actualColection);
        }

        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 0 })]
        [TestCase(new int[] { 1 }, new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1 }, new int[] { 1, 2 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 1 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5 }, new int[] { 3, 4, 5 })]
        public void GetNumbersDivisibleByAtLeastOneDivisor_Collection_Created(IEnumerable<int> testedNumbers, IEnumerable<int> testedDivisors, IEnumerable<int> expectedCollection)
        {
            // Arrange
            NumberHandler numberHandler = new NumberHandler();

            // Act
            IEnumerable<int> actualColection = numberHandler.GetNumbersDivisibleByAtLeastOneDivisor(testedNumbers, testedDivisors);

            // Act & Assert
            Assert.AreEqual(expectedCollection, actualColection);
        }

        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 2 }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 }, new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 101 }, new int[] { 2, 3 }, new int[] { 1, 101 })]
        [TestCase(new int[] { int.MinValue, 0, int.MaxValue }, new int[] { 2 }, new int[] { int.MaxValue })]

        public void GetNumbersNotDivisibleByAnyDivisor_Collection_Created(IEnumerable<int> testedNumbers, IEnumerable<int> testedDivisors, IEnumerable<int> expectedCollection)
        {
            // Arrange
            NumberHandler numberHandler = new NumberHandler();

            // Act
            IEnumerable<int> actualColection = numberHandler.GetNumbersNotDivisibleByAnyDivisor(testedNumbers, testedDivisors);

            // Act & Assert
            Assert.AreEqual(expectedCollection, actualColection);
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 3 })]
        [TestCase(new int[] { int.MinValue, -3, -2, -1, 0, 1, 2, 3, int.MaxValue }, new int[] { -3, -1, 1, 3, int.MaxValue })]

        public void GetOddNumbers_Collection_Created(IEnumerable<int> testedNumbers, IEnumerable<int> expectedCollection)
        {
            // Arrange
            NumberHandler numberHandler = new NumberHandler();

            // Act
            IEnumerable<int> actualColection = numberHandler.GetOddNumbers(testedNumbers);

            // Act & Assert
            Assert.AreEqual(expectedCollection, actualColection);
        }
    }
}