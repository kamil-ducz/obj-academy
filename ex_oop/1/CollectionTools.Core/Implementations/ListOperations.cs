using System;
using System.Collections.Generic;
using System.Linq;

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
    }
}
