using System;
using FluentAssertions;
using NUnit.Framework;

namespace BubbleSort
{
    [TestFixture]
    public class TestBubbleSort
    {
        private Sorter _sorter;

        [SetUp]
        public void SetUp()
        {
            _sorter = new Sorter();
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullArrayThrows()
        {
            _sorter.Sort(null);
        }

        [Test]
        public void EmptyArrayReturnsEmptyArray()
        {
            var result = _sorter.Sort(new int[] {});

            result.Should().BeEmpty();
        }

        [TestCase(new []{1}, new []{1})]
        [TestCase(new []{1,2}, new []{1,2})]
        [TestCase(new []{2,1}, new []{1,2})]
        [TestCase(new []{1,2,3}, new []{1,2,3})]
        [TestCase(new []{1,3,2}, new []{1,2,3})]
        [TestCase(new []{2,3,1}, new []{1,2,3})]
        [TestCase(new []{2,3,1,2,4,3,5,2,1}, new []{1,1,2,2,2,3,3,4,5})]
        public void StateTests(int[] unsorted, int[] sorted)
        {
            AssertSorted(unsorted, sorted);
        }

        private void AssertSorted(int[] unsorted, int[] sorted)
        {
            var result = _sorter.Sort(unsorted);
            result.Should().Equal(sorted);
        }
    }
}