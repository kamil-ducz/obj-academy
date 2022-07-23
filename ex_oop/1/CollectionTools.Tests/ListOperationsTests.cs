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

        [Test]
        public void MaxWordsMethod_EmptyList()
        {
            var source = new List<string>();

            Assert.AreEqual("We can see that provided list doesn't contain any sentences", ListOperations.MaxWords(source));
        }

        [Test]
        public void MaxWordsMethod_OneSentence()
        {
            var source = new List<string>() { "this is first sentence" };

            Assert.AreEqual("We can see that most words are found in sentence 1 and the value is 4: this is first sentence", 
                ListOperations.MaxWords(source));
        }

        [Test]
        public void MaxWordsMethod_TwoSentences()
        {
            var source = new List<string>() { "this is first sentence", "this is second one", "hey there" };
            Assert.AreEqual("We can see that most words are found in sentence 1 and the value is 4: this is first sentence",
    ListOperations.MaxWords(source));
        }

        [Test]
        public void MaxWordsMethod_FiveSentence()
        {
            var source = new List<string>() { "this is first sentence", "this is second one", "hey there", "go for it baby", "I don't mind programming at all mate" };
            Assert.AreEqual("We can see that most words are found in sentence 5 and the value is 7: I don't mind programming at all mate",
    ListOperations.MaxWords(source));
        }
    }
}