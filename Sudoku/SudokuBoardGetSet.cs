using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public partial class Sudoku : IGet, ISet
    {
        // Get functions
        public int GetByColumn(int columnIndex, int rowIndex)
        {
            int cellIndex = -1;
            cellIndex = rowIndex * boardSize + columnIndex;
            return board[cellIndex];
        }

        public int GetByRow(int rowIndex, int columnIndex)
        {
            int cellIndex = -1;
            cellIndex = rowIndex * boardSize + columnIndex;
            return board[cellIndex];
        }

        public int GetBySquare(int squareIndex, int positionIndex)
        {
            int cellIndex = cellIndexFromSquare(squareIndex, positionIndex);
            return board[cellIndex];
        }

        // Set functions
        public void SetByColumn(int value, int columnIndex, int rowIndex)
        {
            int cellIndex = -1;
            cellIndex = rowIndex * boardSize + columnIndex;
            board[cellIndex] = value;
        }
        public void SetByRow(int value, int rowIndex, int columnIndex)
        {
            int cellIndex = -1;
            cellIndex = rowIndex * boardSize + columnIndex;
            board[cellIndex] = value;
        }

        public void SetBySquare(int value, int squareIndex, int positionIndex)
        {
            int cellIndex = cellIndexFromSquare(squareIndex, positionIndex);
            board[cellIndex] = value;
        }
    }
}
    
