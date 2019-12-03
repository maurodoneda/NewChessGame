using System;
using System.Collections.Generic;
using System.Text;

namespace NewChessGame.BoardLayer
{
    class Position
    {
        public int Row { get; set; }
        public int Collumn { get; set; }

        public Position(int row, int collumn)
        {
            Row = row;
            Collumn = collumn;
        }

        public void SetValues(int row, int collumn)
        {
            Row = row;
            Collumn = collumn;
        }

        public override string ToString()
        {
            return Row + "," + Collumn;
        }


    }
}
