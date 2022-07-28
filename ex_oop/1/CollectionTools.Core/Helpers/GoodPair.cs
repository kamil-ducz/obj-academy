namespace CollectionTools.Core.Helpers
{
    public class GoodPair
    {


        public int X { get; set; }
        public int Y { get; set; }
        public int XIndex { get; set; }
        public int YIndex { get; set; }

        public GoodPair(int x, int y)
        {
            X = x;
            Y = y;
        }

        public GoodPair(int x, int y, int xIndex, int yIndex)
        {
            X = x;
            Y = y;
            XIndex = xIndex;
            YIndex = yIndex;
        }
    }
}
