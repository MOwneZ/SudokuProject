using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public partial class Sudoku
    {
        // Private attributes and member functions
        public int boardSize;      // Board size -- row size
        public int sectionWidth;   // Width of a rectangle - also number of sections down
        public int sectionHeight;  // Height of a rectangle - also number of sections across
        public int[] board;        // The board stored as a 1-d array
        public int maxValue;       // The highest number in the sudoku board
        public int cellIndexFromSquare(int squareIndex, int positionIndex)
        {
            int cellIndex = -1;
            cellIndex = (squareIndex / sectionHeight) * sectionHeight * boardSize; // Row start
            cellIndex += squareIndex % sectionHeight * sectionWidth;   //TL of square
            cellIndex += positionIndex / sectionWidth * boardSize + positionIndex % sectionWidth;  // Actual square
            return cellIndex;
        }
    }
}
