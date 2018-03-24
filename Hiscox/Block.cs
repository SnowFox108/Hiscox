namespace Hiscox
{
    public class Block
    {
        public decimal Ascii { get; }
        public int AppearanceCount { get; }
        public decimal Total { get; }
        public Block(decimal ascii, int appearanceCount)
        {
            Ascii = ascii;
            AppearanceCount = appearanceCount;
            Total = ascii * appearanceCount;
        }

    }
}
