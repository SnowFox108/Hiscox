namespace Hiscox
{
    public class Startup
    {
        private readonly IStringParserService _stringParserService;
        private readonly ICharProcessingService _charProcessingService;
        private readonly IOutputResult _outputResult;

        public Startup(IStringParserService stringParserService, ICharProcessingService charProcessingService, IOutputResult outputResult)
        {
            _stringParserService = stringParserService;
            _charProcessingService = charProcessingService;
            _outputResult = outputResult;
        }

        public void Run(string text)
        {
            var input = _stringParserService.Execute(text);
            var blocks = _charProcessingService.BuildBlocks(input);
            _outputResult.Execute(blocks);
        }
    }
}
