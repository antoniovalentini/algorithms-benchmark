using CodingChallengeCollection.DataStructures;
using Xunit;

namespace CodingChallengeCollection.UnitTests.DataStructures
{
    public class SingleLinkedListTests
    {
        /// <summary>
        /// [10 -> 20 -> 30 -> 40 -> 50]
        ///              *           *
        /// </summary>
        /// <param name="k"></param>
        /// <param name="value"></param>
        [Theory]
        [InlineData(1, 50)]
        [InlineData(2, 40)]
        [InlineData(3, 30)]
        public void KthNodeFromTheEnd(int k, int value)
        {
            // ARRANGE
            var list = new SingleLinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);

            // ACT
            var kth = list.KthNodeFromTheEnd_OnePass(k);

            // ASSERT
            Assert.Equal(value, kth.Value);
        }
    }
}
