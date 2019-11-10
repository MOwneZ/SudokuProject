using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public partial class Sudoku : ISerialize
    {
        public void FromCSV(string csv)
        {
            string[] allLines = csv.Split('\n');
            string[] aLine = allLines[0].Split(',');
            SetMaxValue(int.Parse(aLine[0]));
            SetSquareHeight(int.Parse(aLine[1]));
            SetSquareWidth(int.Parse(aLine[2]));
            aLine = allLines[1].Split(',');
            for (int i = 0; i < aLine.Length; i++) this.SetCell(int.Parse(aLine[i]), i);
            SetMax();
        }
        public string ToCSV()
        {
            string strReturn  = "";
            strReturn = boardSize.ToString() + ',' + sectionHeight.ToString() + ',' + sectionWidth.ToString() + '\n';
            for (int i=0; i<board.Length; i++) strReturn += (board[i].ToString() + ',');
            strReturn = (strReturn.Remove(strReturn.Length-1) + '\n'); 
            return strReturn;
        }
        public void SetCell(int value, int gridIndex)
        {
            board[gridIndex] = value;
        }
        public int GetCell(int gridIndex)
        {
            return board[gridIndex];
        }
        public void SetMax ()
        {
            maxValue = board.Max();
        }
        public string ToPrettyString()
        {
            // Won't be very pretty with more than one digit
            string strReturn = "";
            string blankLine = "";
            string rowDivider = "-".PadRight((boardSize * 3 + sectionHeight - 1), '-') + '\n'; // A row of minus signs
            string blankSection = " ".PadRight(sectionWidth * 3, ' ');
            int cellNumber = 0;
            // Create teh blank line
            for (int i=1; i<sectionHeight; i++)
            {
                blankLine += (blankSection + '|');
            }
            blankLine += (blankSection + '\n'); ;
            
            // All rows
            for (int row = 1; row <= boardSize; row++)
            {
                strReturn += blankLine;
                for (int colSection= 1; colSection <= sectionHeight; colSection++)
                {
                    // Add the number 
                    for (int col = 1; col <= sectionWidth; col++)
                    {
                        if (board[cellNumber] == 0)
                        {
                            strReturn += "   ";
                        }
                        else
                        {
                            strReturn += (' ' + board[cellNumber].ToString() + ' ');
                        }
                        cellNumber++;
                    }
                    // Add a column divider or new line
                    if ((cellNumber % boardSize) != 0)
                    {
                        strReturn += '|';
                    }
                    else
                    {
                        strReturn += '\n';
                    }
                }
                if ((row % sectionHeight) == 0 && (row < boardSize))
                {
                    strReturn += blankLine;
                    strReturn += rowDivider;
                }
            }
            strReturn += blankLine;
            return strReturn;
        }
    }
}
