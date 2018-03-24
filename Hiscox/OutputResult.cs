using System;
using System.Collections.Generic;
using System.Linq;

namespace Hiscox
{
    public class OutputResult : IOutputResult
    {
        public void Execute(List<Block> blocks)
        {
            Console.WriteLine($"Answer is {blocks.Sum(b => b.Total)}");
        }
    }
}
