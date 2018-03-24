using System.Collections.Generic;

namespace Hiscox
{
    public interface ICharProcessingService
    {
        List<Block> BuildBlocks(IEnumerable<decimal> chars);
    }
}
