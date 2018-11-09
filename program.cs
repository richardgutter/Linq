using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using System;

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Prefix
    {
        public static IEnumerable<string> Prefixes(IEnumerable<string> words, int length)
        {
            IEnumerable<string> outputarray = (from s in words
                              where s.Length >= length
                              select s.Substring(0, length) ).Distinct();

            return outputarray;
        }

        public static void Main(string[] args)
        {
            foreach (var p in Prefixes(new string[] { "many", "manly", "men", "maybe", "my" }, 3))
                Console.WriteLine(p);
        }
    }
}
