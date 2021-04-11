namespace CodingChallengeCollection.Algorithms.Basic
{
    public class Palindrome
    {
        public bool IsPalindrome(string s)
        {
            if (s is null || s.Length == 0)
                return false;

            var sLength = s.Length;
            for (var i = 0; i < sLength; i++)
                if (s[i] != s[sLength - i - 1])
                    return false;

            return true;
        }
    }
}
