using System;

namespace CodingChallengeCollection.Algorithms.Sorting
{
    /// <summary>
    /// Methods return sorted array and # of iterations
    /// </summary>
    public class BubbleSort
    {
        public (int[],int) Improved2(int[] initial)
        {
            var iterations = 0;
            var array = new int[initial.Length];
            Array.Copy(initial, array, array.Length);

            var swap = true;
            var length = array.Length - 1;
            while (swap)
            {
                swap = false;
                for (var i = 0; i < length; i++)
                {
                    var j = i + 1;

                    if (array[i] > array[j])
                    {
                        var temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                        swap = true;
                    }

                    iterations++;
                }
                length--;
            }

            return (array, iterations);
        }

        public (int[],int) Improved1(int[] initial)
        {
            var iterations = 0;
            var array = new int[initial.Length];
            Array.Copy(initial, array, array.Length);
            for (var i = 0; i < array.Length-1; i++)
            {
                for (var j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        var temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                    iterations++;
                }
            }

            return (array, iterations);
        }

        public (int[],int) BruteForce(int[] initial)
        {
            var iterations = 0;
            var array = new int[initial.Length];
            Array.Copy(initial, array, array.Length);

            var swap = true;
            while (swap)
            {
                swap = false;
                for (var i = 0; i < array.Length - 1; i++)
                {
                    var j = i + 1;

                    if (array[i] > array[j])
                    {
                        var temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                        swap = true;
                    }

                    iterations++;
                }
            }

            return (array, iterations);
        }
    }
}
