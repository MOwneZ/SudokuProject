using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public partial class Sudoku : IGame
    {
        public void SetMaxValue(int maximum)
        {
            boardSize = maximum;
            board = new int[boardSize * boardSize];
        }

        public int GetMaxValue()
        {
            return boardSize;
        }
        public int[] ToArray()
        {
            return board;
        }
        public void Set(int[] cellValues)
        {
            board = cellValues;
        }
        public void SetSquareWidth(int squareWidth)
        {
            sectionWidth = squareWidth;
        }
        public void SetSquareHeight(int squareHeight)
        {
            sectionHeight = squareHeight;
        }

        public void Restart()
        {
            SetMaxValue(0);
            SetSquareHeight(0);
            SetSquareWidth(0);
            Set(new int[0]);
        }
            
    }
}
