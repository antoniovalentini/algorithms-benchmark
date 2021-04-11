using System.Collections.Generic;
using System.Linq;

namespace CodingChallengeCollection.UnitTests.Utils
{
    public static class StringUtils
    {
        public static string PrintArray(IEnumerable<int> arr)
        {
            var converted = arr.Select(x => x.ToString());
            var result = converted.Aggregate((a, b) => $"{a}, {b}");
            return $"[{result}]";
        }

        private static string ListTosTring<T>(IReadOnlyCollection<T> list)
        {
            var result = "";
            var i = 0;
            foreach (var element in list)
            {
                if (i == 0)
                    result = "[" + element;
                else if (i == list.Count - 1)
                    result += ", " + element + "]";
                else
                    result += ", " + element;

                if(list.Count == 1)
                    result += "]";

                i++;
            }
            return result;
        }
    }
}
