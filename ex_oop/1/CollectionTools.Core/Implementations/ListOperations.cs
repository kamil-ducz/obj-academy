using System;
using System.Collections.Generic;

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
    }
}
