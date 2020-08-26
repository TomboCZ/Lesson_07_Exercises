using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_07_Exercises.App
{
    public class NumberHandler : INumberHandler
    {
        public IEnumerable<int> GetEvenNumbers(IEnumerable<int> numbers)
        {
            return numbers.Where(number => number % 2 == 0);
        }

        public IEnumerable<int> GetNumbersDivisibleByAllDivisors(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            return numbers.Where(number => divisors.All(divisor => divisor != 0 && number % divisor == 0));
        }

        public IEnumerable<int> GetNumbersDivisibleByAtLeastOneDivisor(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            return numbers.Where(number => divisors.Where(divisor => divisor != 0).Any(divisor => number % divisor == 0));
        }

        public IEnumerable<int> GetNumbersNotDivisibleByAnyDivisor(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            return numbers.Where(number => divisors.All(divisor => divisor != 0 && number % divisor != 0));
        }

        public IEnumerable<int> GetOddNumbers(IEnumerable<int> numbers)
        {
            return numbers.Except(GetEvenNumbers(numbers));
        }

        public IEnumerable<int> GetPrimeNumbers(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }
    }
}
