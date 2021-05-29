using System.Linq;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Threading;
using System;
using System.Text;
using System.Collections.Generic;

namespace BoardWatcherClient
{
    public class ChessGameStateService
    {
        public ChessGameState gameState = new ChessGameState();
        public List<PieceCV> generateNewBoard()
        {
            List<PieceCV> pieces = new List<PieceCV>();
            List<PieceCV> blackPieces = new List<PieceCV>
            {
                new PieceCV(2, false),
                new PieceCV(3, false),
                new PieceCV(4, false),
                new PieceCV(5, false),
                new PieceCV(6, false),
                new PieceCV(4, false),
                new PieceCV(3, false),
                new PieceCV(2, false),

                new PieceCV(1, false),
                new PieceCV(1, false),
                new PieceCV(1, false),
                new PieceCV(1, false),
                new PieceCV(1, false),
                new PieceCV(1, false),
                new PieceCV(1, false),
                new PieceCV(1, false)
            };
            List<PieceCV> whitePieces = new List<PieceCV>
            {
                new PieceCV(1, true),
                new PieceCV(1, true),
                new PieceCV(1, true),
                new PieceCV(1, true),
                new PieceCV(1, true),
                new PieceCV(1, true),
                new PieceCV(1, true),
                new PieceCV(1, true),

                new PieceCV(2, true),
                new PieceCV(3, true),
                new PieceCV(4, true),
                new PieceCV(5, true),
                new PieceCV(6, true),
                new PieceCV(4, true),
                new PieceCV(3, true),
                new PieceCV(2, true)
            };
            pieces.AddRange(blackPieces);
            for (int i = 16; i < 48; i++)
            {
                pieces.Add(new PieceCV(0, false));
            }
            pieces.AddRange(whitePieces);
            return pieces;
        }
        public Task<List<PieceCV>> GetPieceData()
        {
            List<PieceCV> pieces = new List<PieceCV>();;
            pieces = generateNewBoard();
            return Task.FromResult(pieces.ToList());
        }

        public PieceCV[] getPieceDataFromJson()
        {
            return System.Text.Json.JsonSerializer.Deserialize<PieceCV[]>("/piecesTest.json");
        }
    }
}
