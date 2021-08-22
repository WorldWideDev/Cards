namespace CardGame.Views.Utilities
{
    // used to index SizeMulitplier array :: [Small, Medium, Large]
    public enum CardSize
    {
        Small,
        Medium,
        Large
    };
    public class CardDimension
    {
        // GLOBALS
        private static int minX = 8;
        private static int minY = 6;
        private static int[] SizeMultipliers = new int[] { 1, 2, 3 };

        // PROPS
        public int Width {get; private set;}
        public int Length {get; private set;}
        public CardSize Size {get; private set;}
        public int SizeMultiplier => SizeMultipliers[(int)Size];

        // METHODS
        public CardDimension(CardSize size)
        {
            Size = size;
            initialize();
        }
        public CardDimension()
        {
            Size = CardSize.Small;
            initialize();
        }
        private void initialize()
        {
            Width = minX * SizeMultiplier;
            // Length is proportional to Width
            Length = (int)(minX * SizeMultiplier) * 
                (minY*SizeMultiplier)/(minX*SizeMultiplier);

        }
    }
}
