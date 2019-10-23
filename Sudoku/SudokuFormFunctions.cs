using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SudokuForm
    {
        OpenFileDialog OpenDialog = new OpenFileDialog
        {
            Filter = "CSV files (*.csv)|*.csv",
            DefaultExt = ".csv"
        };
        SaveFileDialog SaveDialog = new SaveFileDialog
        {
            Filter = "CSV files (*.csv)|*.csv"
        };
        Stopwatch theStopWatch = new Stopwatch();
        Sudoku theSudoku = new Sudoku();
        List<int> validRows = new List<int> { };
        List<int> validColumns = new List<int> { };
        List<int> validSquares = new List<int> { };
        int maxNum;

        // button function which generates the board based on input array (either csv or restarted game)
        public void GenerateBoard (int[] newBoard)
        {
            int cellNum = newBoard.ToArray().Length;
            maxNum = theSudoku.GetMaxValue();
            int pointX = 0;
            int pointY = 0;
            int position = 0;
            GameBoard.Controls.Clear();
            for (int n = 1; n <= cellNum; n++)
            {
                if (newBoard[position] != 0)
                {
                    NewCell(newBoard[position], position, pointX, pointY, true);
                }
                else
                {
                    NewCell(newBoard[position], position, pointX, pointY, false);
                }
                pointX += 50;
                position++;
                if (n % maxNum == 0)
                {
                    pointY += 50;
                    pointX = 0;
                }
            }
        }

        // Function which creates each cell on the game board
        public void NewCell(int newNum, int positionIndex, int newX, int newY, bool readOnly)
        {
            TextBox Cell = new TextBox
            {
                Name = positionIndex.ToString(),
                Size = new Size(30, 30),
                MaxLength = 1,
                Text = newNum.ToString(),
                TextAlign = HorizontalAlignment.Center,
                ReadOnly = readOnly,
                Font = new Font(Font.FontFamily, 24),
                Location = new Point(newX, newY)
            };
            Cell.TextChanged += new EventHandler(Cell_TextChanged);
            GameBoard.Controls.Add(Cell);
            GameBoard.Show();
        }

        // function which submits input to game board and verifys game board based on cell entered
        public void Cell_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox stringInput)
            {
                int num = -1;
                if (int.TryParse(stringInput.Text, out num))
                {
                    int position = Int32.Parse(stringInput.Name);
                    int input = Int32.Parse(stringInput.Text);
                    if (WithinValidRange(input))
                    {
                        theSudoku.board[position] = input;
                        CheckBoard();
                        SetLabels();
                        EmptyLists();
                    }
                    else
                    {
                        MessageBox.Show(string.Concat("Please enter a number from 1 to ", maxNum), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please only enter numbers.");
                }
            }
        }
        // functions which checks current game board for any completed rows/columns/squares
        public void CheckBoard()
        {
            for (int i = 1; i <= maxNum; i++)
            {
                if (theSudoku.CheckRow(i))
                {
                    validRows.Add(i);
                }
                if (theSudoku.CheckColumn(i))
                {
                    validColumns.Add(i);
                }
            }
        }
        public void EmptyLists()
        {
            validRows.Clear();
            validColumns.Clear();
            validSquares.Clear();
        }
        public void SetLabels()
        {
            SetRowLabel(validRows);
            SetColLabel(validColumns);
            EmptyLists();
        }
        // functions which set the valid labels based on number of valid rows/columns/squares
        public void SetRowLabel(List<int> newValidRows)
        {
            string text = "Rows that are valid: ";
            if (newValidRows.Count() == 0)
            {
                text = "No rows are currently valid.";
            }
            else
            {
                for (int i = 0; i <= newValidRows.Count - 1; i++)
                {
                    text += newValidRows[i] + ", ";
                }
            }
            lblRowsValid.Text = text;
        }
        public void SetColLabel(List<int> newValidCols)
        {
            string text = "Columns that are valid: ";
            if (newValidCols.Count() == 0)
            {
                text = "No columns are currently valid.";
            }
            else
            {
                for (int i = 0; i <= newValidCols.Count - 1; i++)
                {
                    text += newValidCols[i] + " ";
                }
            }
            lblColsValid.Text = text;
        }
        // boolean function which checks whether number is within appropriate range
        public bool WithinValidRange(int newNum)
        {
            bool isValid = false;
            if (newNum > 0 && newNum <= theSudoku.maxValue)
            {
                isValid = true;
            }
            return isValid;
        }

        // button function which opens file dialog, and loads csv into game
        public void LoadCsvFromFile ()
        {
            DialogResult result = OpenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = OpenDialog.FileName;
                try
                {
                    string Contents = File.ReadAllText(file);
                    theSudoku.FromCSV(Contents);
                }
                catch (IOException)
                {
                }
            }
        }

        // button function which saves current game state to file
        public void SaveCsvToFile ()
        {
            DialogResult = SaveDialog.ShowDialog();
            string filePath;
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    string Contents = theSudoku.ToCSV();
                    filePath = SaveDialog.FileName;
                    File.WriteAllText(filePath, Contents);
                }
                catch (IOException)
                {
                }
            }
        }

        // function which starts the timer
        public void StartTimer ()
        {
            theTimer.Start();
            theStopWatch.Start();
        }

        public void PauseTimer ()
        {
            theTimer.Stop();
            theStopWatch.Stop();
        }
    }
}
