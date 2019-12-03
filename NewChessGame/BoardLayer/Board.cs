using System;
using System.Collections.Generic;
using System.Text;

namespace NewChessGame.BoardLayer
{
    class Board
    {
        public int Rows { get; set; }
        public int Collumns { get; set; }
        private Piece[,] Pieces;

        public Board(int rows, int collumns)
        {
            Rows = rows;
            Collumns = collumns;
            Pieces = new Piece[rows, collumns];
        }


    }
}
