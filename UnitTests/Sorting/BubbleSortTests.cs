using CodingChallengeCollection.Algorithms.Sorting;
using Xunit;

namespace CodingChallengeCollection.UnitTests.Sorting
{
    public class BubbleSortTests
    {
        private readonly int[] _initial = {188, 497, 191, 677, 813, 277, 699, 687, 543, 496, 977, 442, 
            446, 78, 800, 903, 73, 405, 22, 663, 992, 935, 392, 876, 666, 865, 540, 769, 814, 
            163, 264, 932, 703, 561, 851, 806, 741, 213, 455, 236, 326, 158, 535, 348, 984, 
            274, 552, 807, 229, 622, 81, 581, 633, 944, 482, 559, 340, 927, 385, 323, 37, 288, 
            639, 151, 623, 375, 661, 195, 854, 91, 320, 747, 35, 85, 122, 504, 551, 954, 547, 308, 
            162, 738, 75, 246, 783, 433, 441, 68, 366, 214, 12, 83, 261, 51, 592, 268, 351, 812, 32, 856};

        [Fact]
        public void BruteForceSort()
        {
            // ARRANGE
            var sort = new BubbleSort();

            // ACT
            var (result, iterations) = sort.BruteForce(_initial);

            // ASSERT
            Assert.Equal(9603, iterations);
            Assert.Equal(12, result[0]);
            Assert.Equal(992, result[^1]);
        }

        [Fact]
        public void Improved1Sort()
        {
            // ARRANGE
            var sort = new BubbleSort();

            // ACT
            var (result, iterations) = sort.Improved1(_initial);

            // ASSERT
            Assert.Equal(4950, iterations);
            Assert.Equal(12, result[0]);
            Assert.Equal(992, result[^1]);
        }

        [Fact]
        public void Improved2Sort()
        {
            // ARRANGE
            var sort = new BubbleSort();

            // ACT
            var (result, iterations) = sort.Improved1(_initial);

            // ASSERT
            Assert.Equal(4950, iterations);
            Assert.Equal(12, result[0]);
            Assert.Equal(992, result[^1]);
        }
    }
}
