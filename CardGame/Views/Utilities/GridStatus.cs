namespace CardGame.Views.Utilities
{
    public struct GridPosition
    {
        public int xPos {get;set;}
        public int xEnd {get;set;}
        public int yPos {get;set;}
        public int yEnd {get;set;}
        public GridPosition(int xPos, int xEnd, int yPos, int yEnd)
        {
            this.xPos = xPos;
            this.xEnd = xEnd;
            this.yPos = yPos;
            this.yEnd = yEnd;
        }
    }
}