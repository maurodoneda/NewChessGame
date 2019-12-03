using System;
using System.Collections.Generic;
using System.Text;

namespace NewChessGame.BoardLayer
{
    class Piece
    {
        public Position Position { get; private set; }

        public Piece(Position position)
        {
            Position = position;
        }
    }
}
