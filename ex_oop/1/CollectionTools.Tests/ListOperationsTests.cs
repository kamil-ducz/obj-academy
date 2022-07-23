using NUnit.Framework;
using CollectionTools.Implementations;
using System;
using System.Collections.Generic;

namespace CollectionTools.Tests
{
    public class ListOperationsTests
    {
        [Test]
        public void ShuffleMethod_Empty()
        {
            List<int> source = new List<int>();

            List<int> target = new List<int>();
            target = ListOperations.ShuffleItems(source);

            Assert.AreEqual(target.Count, source.Count);
            Assert.AreEqual(source, target);
        }

        [Test]
        public void ShuffleMethod_OneElement()
        {
            List<int> source = new List<int>();
            source.Add(1);

            List<int> target = new List<int>();
            target = ListOperations.ShuffleItems(source);

            Assert.AreEqual(target.Count, source.Count);
            Assert.AreEqual(source, target);
        }

        [Test]
        public void ShuffleMethod_TwoElements()
        {
            List<int> source = new List<int>();
            source.Add(1);

            List<int> target = new List<int>();
            target = ListOperations.ShuffleItems(source);

            Assert.AreEqual(target.Count, source.Count);
            Assert.AreEqual(source, target);
        }

        [Test]
        public void ShuffleMethod_TenElements()
        {
            List<int> source = new List<int>();
            for(int i= 0; i < 10; i++)
            {
                source.Add(new Random().Next(100));
            }

            List<int> target = new List<int>();
            target = ListOperations.ShuffleItems(source);

            Assert.AreEqual(target.Count, source.Count);
            Assert.AreNotEqual(source, target);
        }

        [Test]
        public void ShuffleMethod_OverflowElements()
        {
            List<int> source = new List<int>();
            source.Add(2147483647);
            source[0] += 1000000000;
            source.Add(-2147483648);
            source[1] -= 1000000000;

            List<int> target = new List<int>();
            target = ListOperations.ShuffleItems(source);

            Assert.AreEqual(target.Count, source.Count);
            Assert.AreNotEqual(target, source);
        }
    }
}