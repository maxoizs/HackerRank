using NUnit.Framework;
using NUnit;
using System.Linq;
using System.Collections.Generic;

namespace HackerRank
{
    [TestFixture]
    public class SuperReducedString
    {
        private string Chanllange(string s)
        {
            var result = new List<char>();

            for(var x =0; x<s.Length; x++)
            {                
                if(x < s.Length - 1 && s[x]==s[x+1])                
                {
                    x += 1; 
                }
                else
                {                   
                    if(result.Any() && result.Last() == s[x])
                    {
                        result.RemoveAt(result.Count - 1);
                    }
                    else
                    {
                        result.Add(s[x]);
                    }
                }
            }
            var output = string.Join(string.Empty, result);

            return output==string.Empty? "Empty String": output; 
        }


        [TestCase("dcabaabacd", "Empty String")]
        [TestCase("baab", "Empty String")]
        [TestCase("aa","Empty String")]
        [TestCase("i", "i")]
        [TestCase("iiiiiii", "i")]
        [TestCase("aaabccddd", "abd")]
        [TestCase("inTheWorld", "inTheWorld")]
        [Test]
        public void Test(string word, string expected)
        {
            var result = Chanllange(word);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
