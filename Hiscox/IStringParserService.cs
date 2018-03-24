using System.Collections.Generic;

namespace Hiscox
{
    public interface IStringParserService
    {
        IEnumerable<decimal> Execute(string input);
    }
}
