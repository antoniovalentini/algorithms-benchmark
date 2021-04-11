using CodingChallengeCollection.Algorithms.Basic;
using Xunit;

namespace CodingChallengeCollection.UnitTests.Basic
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("1001", true)]
        [InlineData("amanaplanacanalpanama", true)] // A man, a plan, a canal – Panama
        [InlineData("madam", true)]
        [InlineData("notPalindrome", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsPalindromeTests(string s, bool isPalindrome)
        {
            var resut = new Palindrome().IsPalindrome(s);
            Assert.Equal(isPalindrome, resut);
        }
    }
}
