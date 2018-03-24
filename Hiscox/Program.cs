using System;

namespace Hiscox
{
    class Program
    {
        static void Main(string[] args)
        {
            // ready for use IOC, here is just demo
            var startup = new Startup(new StringParserService(), new CharProcessingService(),new OutputResult());
            startup.Run("AaaaaaaBbbccaaaaaaaaaaaAAAAAAAa");
            Console.Read();
        }
    }
}
