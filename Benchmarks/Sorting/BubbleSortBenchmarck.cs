using BenchmarkDotNet.Attributes;
using CodingChallengeCollection.Algorithms.Sorting;

namespace CodingChallengeCollection.Benchmarks.Sorting
{
    public class BubbleSortBenchmarck
    {
        private readonly int[] _array = {188, 497, 191, 677, 813, 277, 699, 687, 543, 496, 977, 442, 
            446, 78, 800, 903, 73, 405, 22, 663, 992, 935, 392, 876, 666, 865, 540, 769, 814, 
            163, 264, 932, 703, 561, 851, 806, 741, 213, 455, 236, 326, 158, 535, 348, 984, 
            274, 552, 807, 229, 622, 81, 581, 633, 944, 482, 559, 340, 927, 385, 323, 37, 288, 
            639, 151, 623, 375, 661, 195, 854, 91, 320, 747, 35, 85, 122, 504, 551, 954, 547, 308, 
            162, 738, 75, 246, 783, 433, 441, 68, 366, 214, 12, 83, 261, 51, 592, 268, 351, 812, 32, 856};

        private readonly BubbleSort _sort;

        public BubbleSortBenchmarck()
        {
            _sort = new BubbleSort();
        }
        
        [Benchmark]
        public void BruteForce() => _sort.BruteForce(_array);

        [Benchmark]
        public void Improved1() => _sort.Improved1(_array);

        [Benchmark]
        public void Improved2() => _sort.Improved2(_array);
    }
}
