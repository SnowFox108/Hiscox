using System.Collections.Generic;
using System.Text;

namespace Hiscox
{
    public class StringParserService : IStringParserService
    {
        public IEnumerable<decimal> Execute(string input)
        {
            var asciiBytes = Encoding.ASCII.GetBytes(input);
            var last = new byte();
            foreach (var asciiByte in asciiBytes)
            {
                if (asciiByte == last)              
                    continue;
                last = asciiByte;
                yield return asciiByte;                
            }
        }
    }
}
