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

        [Test]
        public void FindGoodPairsMethod_EmptyList()
        {
            List<int> source = new List<int>();

            Assert.AreEqual("The list is empty or contains less than 2 elements", ListOperations.FindGoodPairs(source));
        }

        [Test]
        public void FindGoodPairsMethod_OneElement()
        {
            List<int> source = new List<int>() { 7 };

            Assert.AreEqual("The list is empty or contains less than 2 elements", ListOperations.FindGoodPairs(source));
        }

        [Test]
        public void FindGoodPairsMethod_SixElements()
        {
            var source = new List<int> { 1, 2, 3, 1, 1, 3 };

            Assert.AreEqual("There are 4 good pairs at indexes: (0,3), (0,4), (2,5), (3,4))", ListOperations.FindGoodPairs(source));
        }

        [Test]
        public void FindGoodPairsMethod_SixElementsNoMatchingPairs()
        {
            var source = new List<int> { 1, 2, 3, 4, 5, 6 };

            Assert.AreEqual("There are no good pairs on the list", ListOperations.FindGoodPairs(source));
        }

        [Test]
        public void FibonacciMethod_FirstElement()
        {
            int source = 1;

            Assert.AreEqual(1, ListOperations.Fibonacci(source));
        }

        [Test]
        public void FibonacciMethod_SecondElement()
        {
            int source = 2;

            Assert.AreEqual(1, ListOperations.Fibonacci(source));
        }

        [Test]
        public void FibonacciMethod_ThirdElement()
        {
            int source = 3;

            Assert.AreEqual(2, ListOperations.Fibonacci(source));
        }

        [Test]
        public void FibonacciMethod_SeventhElement()
        {
            int source = 7;

            Assert.AreEqual(13, ListOperations.Fibonacci(source));
        }

        [Test]
        public void PalindromeCheckMethod_EmptyInput()
        {
            string source = "";

            Assert.AreEqual(false, ListOperations.PalindromeCheck(source));
        }

        [Test]
        public void PalindromeCheckMethod_SingleSign()
        {
            string source = "a";

            Assert.AreEqual(true, ListOperations.PalindromeCheck(source));
        }

        [Test]
        public void PalindromeCheckMethod_TwoSigns()
        {
            string source = "xx";

            Assert.AreEqual(true, ListOperations.PalindromeCheck(source));
        }

        [Test]
        public void PalindromeCheckMethod_EightSignWord()
        {
            string source = "pendrive";

            Assert.AreEqual(false, ListOperations.PalindromeCheck(source));
        }

    }
}