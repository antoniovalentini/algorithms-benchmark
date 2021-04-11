using BenchmarkDotNet.Attributes;
using CodingChallengeCollection.Algorithms.Basic;

namespace CodingChallengeCollection.Benchmarks.Basic
{
    public class PalindromeBenchmarck
    {
        private readonly Palindrome _palindrome;

        public PalindromeBenchmarck()
        {
            _palindrome = new Palindrome();
        }

        [Benchmark]
        public void Palindrome() => _palindrome.IsPalindrome("1001");
    }
}
