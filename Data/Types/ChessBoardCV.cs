using System;
using System.Collections.Generic;

namespace BoardWatcherClient
{

    public class PieceCV
    {
        public PieceCV(int id, Boolean colour)
        {
            this.Id = id;
            this.Color = colour;
        }

        public int Id { get; set; }
        public Boolean Color { get; set; }
    }

    public class ChessGameState
    {
        public List<PieceCV> Board { get; set; }
    }
}
