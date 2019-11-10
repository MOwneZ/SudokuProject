using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Sudoku : IValidate
    {
        public int RowLength;
        public int SectionHeight;
        public int SectionWidth;
        public int SectionCount;

        public void SetTemps()
        {
            RowLength = GetMaxValue();
            SectionHeight = sectionHeight;
            SectionWidth = sectionWidth;
            SectionCount = sectionHeight * sectionWidth;
        }

        public bool CheckRow (int theRowNum)
        {
            SetTemps();
            bool isValid = false;
            int startPos = GetRowStartPosition(theRowNum);
            int[] row = GetRow(startPos);
            if (row.Length == row.Distinct().Count() && !row.Contains(0))
            {
                isValid = true;
            }
            return isValid;
        }

        public bool CheckColumn (int theColNum)
        {
            bool isValid = false;
            SetTemps();
            int startPos = GetColStartPosition(theColNum);
            int[] col = GetCol(startPos);
            if (col.Length == col.Distinct().Count() && !col.Contains(0))
            {
                isValid = true;
            }
            return isValid;
        }

        public bool CheckBox (int theBoxNum)
        {
            SetTemps();
            bool isValid = false;
            int[] box = GetBox(theBoxNum);
            if (box.Length == box.Distinct().Count() && !box.Contains(0))
            {
                isValid = true;
            }
            return isValid;
        }
        // loops that determines starting position
        public int GetRowStartPosition (int theRowNum)
        {
            int startPos = 0;
            if (theRowNum == 0)
            {
                return startPos;
            }
            else
            {
                for (int i = 0; i <= theRowNum - 2; i++)
                {
                    startPos += RowLength;
                }
            }
            return startPos;
        }
        public int GetColStartPosition(int theColNum)
        {
            int startPos = 0;
            if (theColNum != 0)
            {
                for (int i = 0; i <= theColNum - 2; i++)
                {
                    startPos += 1;
                }
            }
            return startPos;
        }  
        public int[] GetRow(int newStartPos)
        {
            int n = 0; // counter for index
            int[] row = new int[RowLength];
            // Go through each element in the array we are checking
            for (int i = newStartPos; i <= newStartPos+(RowLength-1); i++)
            {
                row[n] = board[i];
                n++;
            }
            return row;
        }
        public int[] GetCol(int newStartPos)
        {
            int n = 0; // counter for index
            int x = newStartPos;
            int len = RowLength;
            int[] col = new int[RowLength];
            for (int i = newStartPos; i <= newStartPos+(RowLength-1); i++)
            {
                col[n] = board[x];
                n++;
                x = Iterate(x);
            }
            return col;
        }
        public int[] GetBox(int theBoxNum)
        {
            List<int> square = new List<int> { };
            int rowNum = theBoxNum / (RowLength / SectionWidth) * SectionHeight;
            int colNum = theBoxNum % (RowLength / SectionWidth) * SectionWidth;

            for (int row = rowNum; row < SectionHeight + rowNum; row++)
            {
                for (int column = colNum; column < SectionWidth + colNum; column++)
                {
                    square.Add(board[RowLength * row + column]);
                }
            }
            return square.ToArray();
        }
        public int Iterate(int num)
        {
            return num + RowLength;
        }
    }
}