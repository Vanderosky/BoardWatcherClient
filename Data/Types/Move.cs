namespace BoardWatcherClient
{
    public class Move
    {
        public Move(int pieceId, int from, int to, bool color)
        {
            this.piece = pieceId;
            this.from = from;
            this.to = to;
            this.color = color;
        }

        public int piece { get; set; }
        public int from { get; set; }
        public int to { get; set; }
        public bool color { get; set; }
    }
}
