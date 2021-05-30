    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class PieceAI
    {
        [JsonProperty("place ")]
        public string Place { get; set; }

        [JsonProperty("piece ")]
        public string Piece { get; set; }
    }

public class ChessBoardAI
{
    public List<PieceAI> pieces { get; set; }
}
