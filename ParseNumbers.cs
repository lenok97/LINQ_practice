using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.ParseNumbers
{
    class Program
    {
        
        public static void Main()
        {
            CheckParseNumbers();
            Console.ReadKey();
        }

        public static int[] ParseNumbers(IEnumerable<string> lines)
        {
            return lines
                .Where(l => l != "")
                .Select(l => int.Parse(l)).ToArray();
        }

        public static void CheckParseNumbers()
        {
            foreach (var num in ParseNumbers(new[] { "-0", "+0000" }))
                Console.WriteLine(num);
            foreach (var num in ParseNumbers(new List<string> { "1", "", "-03", "0" }))
                Console.WriteLine(num);
        }
    }
}
