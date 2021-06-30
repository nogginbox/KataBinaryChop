using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryChop
{
    public static class BinaryChopExtensions
    {
        public static int Chop(this IList<int> items, int term)
        {
            return Chop(items.ToArray(), term, 0);
        }

        public static int Chop(int[] items, int term, int place)
        {
            // Empty list
            if (items?.Any() != true)
            {
                return -1;
            }

            // Not in list
            if (items[0] > term || items[^1] < term)
            {
                return -1;
            }

            if (items[0] == term)
            {
                return place;
            }

            var halfLength = items.Length / 2;

            if(halfLength > 1)
            {
                var firstHalfPlace = Chop(items[1..halfLength], term, place+1);
                if(firstHalfPlace != -1)
                {
                    return firstHalfPlace;
                }
            }

            return Chop(items[halfLength..], term, place + halfLength);
        }
    }
}
