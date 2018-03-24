using System.Collections.Generic;

namespace Hiscox
{
    public interface IOutputResult
    {
        void Execute(List<Block> blocks);
    }
}
