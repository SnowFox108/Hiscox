using System.Collections.Generic;
using System.Linq;

namespace Hiscox
{
    public class CharProcessingService : ICharProcessingService
    {
        public List<Block> BuildBlocks(IEnumerable<decimal> chars)
        {
            var blocks = new List<Block>();
            foreach (var ascii in chars)
            {
                var count = blocks.Count(b => b.Ascii == ascii);
                blocks.Add(new Block(ascii, count + 1));

            }
            return blocks;
        }        
    }
}
