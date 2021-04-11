using BenchmarkDotNet.Running;
using CodingChallengeCollection.Benchmarks.Basic;
using CodingChallengeCollection.Benchmarks.Sorting;

namespace CodingChallengeCollection.Benchmarks
{
    public class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<PalindromeBenchmarck>();
            BenchmarkRunner.Run<BubbleSortBenchmarck>();
        }
    }
}
