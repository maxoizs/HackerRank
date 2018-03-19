using NUnit.Framework;
using NUnit;

namespace HackerRank
{
    [TestFixture]
    public class CamelCase
    {
        private int Chanllange(string s)
        {
            var counter = s.Length > 0 ? 1 : 0; 
            foreach (var c in s)
            {
                if (char.IsUpper(c))
                {
                    counter++; 
                }
            }
            return counter;
        }

        [TestCase("a", 1)]
        [TestCase("as", 1)]
        [TestCase("inThe", 2)]
        [TestCase("inTheWorld", 3)]
        [Test]
        public void Test(string word, int count)
        {
            var result = Chanllange(word);
            Assert.That(result, Is.EqualTo(count));
        }
    }
}
