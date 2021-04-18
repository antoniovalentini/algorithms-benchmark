using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallengeCollection.DataStructures;
using Xunit;

namespace CodingChallengeCollection.UnitTests.DataStructures
{
    public class HashTableTests
    {
        [Theory]
        [InlineData(1, "A")]
        public void ShouldGetElement(int key, string value)
        {
            var table = new HashTable();
            table.Put(key, value);
            var actual = table.Get(1);
            Assert.Equal(value, actual);
        }
    }
}
