using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    interface IValidate
    {
        void SetTemps();
        bool CheckRow(int theRowNum);
        bool CheckColumn(int theColNum);
        bool CheckBox(int theSquareNum);
        int GetRowStartPosition(int theRowNum);
        int GetColStartPosition(int theColNum);
        int[] GetRow(int rowNum);
        int[] GetCol(int colNum);
        int[] GetBox(int squareNum);
        int Iterate(int num);
    }
}
