using System.Collections.Generic;
using NUnit.Framework;

namespace KataPrimeFactors
{
    [TestFixture]
    public class PrimeFactorsTests
    {
        [Test]
        public void should_return_an_empty_list_if_it_has_no_primer_factors()
        {
            Assert.AreEqual(new List<int>(), PrimeFactors.generate(1));
        }

        [Test]
        public void should_return_the_input_number_if_it_has_only_one_prime_factor()
        {
            Assert.AreEqual(new List<int> { 2 }, PrimeFactors.generate(2));
            Assert.AreEqual(new List<int> { 3 }, PrimeFactors.generate(3));
        }

        [Test]
        public void should_return_the_same_prime_factors_of_an_input_number()
        {
            Assert.AreEqual(new List<int> { 2, 2 }, PrimeFactors.generate(4));
            Assert.AreEqual(new List<int> { 2, 2, 2 }, PrimeFactors.generate(8));
            Assert.AreEqual(new List<int> { 3, 3 }, PrimeFactors.generate(9));
            Assert.AreEqual(new List<int> { 3, 3, 3 }, PrimeFactors.generate(27));
        }
        
        [Test]
        public void should_find_different_prime_factors_of_an_input_number()
        {
            Assert.AreEqual(new List<int> { 2, 3 }, PrimeFactors.generate(6));
            Assert.AreEqual(new List<int> { 2, 2, 3 }, PrimeFactors.generate(12));
        }
        
    }
}