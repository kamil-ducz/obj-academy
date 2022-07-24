using CollectionTools.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionTools.Implementations
{
    public static class ListOperations
    {
        public static List<int> ShuffleItems(List<int> items)
        {
            if (items.Count == 0 || items.Count == 1)
            {
                return items;
            }

            var random = new Random();
            var newShuffledList = new List<int>();
            for (int i = 0; i < items.Count; i++)
            {
                var randomElementInList = random.Next(0, items.Count);
                newShuffledList.Add(items[randomElementInList]);
                items.Remove(items[randomElementInList]);
            }
            return newShuffledList;
        }

        public static string MaxWords(List<string> sentences)
        {
            if (sentences.Count == 0)
            {
                return "We can see that provided list doesn't contain any sentences";
            }

            var maxWords = CountWords(sentences[0]);
            var maxWordsIndex = 0;
            var maxWordsSentence = sentences[0];

            for (int i = 0; i < sentences.Count; i++)
            {
                if (CountWords(sentences[i]) > maxWords)
                {
                    maxWords = CountWords(sentences[i]);
                    maxWordsIndex = i;
                    maxWordsSentence = sentences[i];
                }
            }

            return $"We can see that most words are found in sentence { maxWordsIndex + 1 } and the value is { maxWords }: " +
                $"{ maxWordsSentence }";
        }

        private static int CountWords(string word)
        {
            return word.Split(' ').Count();
        }

        public static string FindGoodPairs(List<int> numberList)
        {
            if (numberList.Count == 0 || numberList.Count == 1 || numberList is null)
            {
                return "The list is empty or contains less than 2 elements";
            }

            List<GoodPair> goodPairs = new List<GoodPair>();

            for (int i = 0; i < numberList.Count; i++)
            {
                for (int j = 0; j < numberList.Count; j++)
                {
                    if (numberList[i] == numberList[j] && i < j)
                    {
                        goodPairs.Add(new GoodPair(numberList[i], numberList[j], i, j));
                    }
                }
            }

            if (goodPairs.Count == 0)
            {
                return "There are no good pairs on the list";
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("There are ");
            sb.Append(goodPairs.Count);
            sb.Append(" good pairs at indexes: ");
            for (int i = 0; i < goodPairs.Count; i++)
            {
                sb.Append("(");
                sb.Append(goodPairs[i].XIndex);
                sb.Append(",");
                sb.Append(goodPairs[i].YIndex);
                if (i == goodPairs.Count - 1)
                {
                    sb.Append("))");
                    break;
                }
                sb.Append("), ");
            }

            return sb.ToString();
        }

        public static int Fibonacci(int input)
        {
            // we are assuming initial elements of Fibonacci sequence are: 1, 1, 2 instead of 0, 1, 1

            if (input == 1 || input == 2)
            {
                return 1;
            }

            return Fibonacci(input-1) + Fibonacci(input-2);
        }

        public static bool PalindromeCheck(string input)
        {
            if (input.Length == 0)
            {
                return false;
            }

            if (input.Length == 1)
            {
                return true;
            }

            if (input == Reverse(input))
            {
                return true;
            }

            return false;
        }

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
