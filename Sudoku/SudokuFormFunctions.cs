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
        Stopwatch TheStopWatch = new Stopwatch();
        Sudoku TheSudoku = new Sudoku();
        List<int> validRows = new List<int> { };
        List<int> validColumns = new List<int> { };
        List<int> validSquares = new List<int> { };
        string originalBoard;
        int maxNum;

        // Button function which generates the board based on input array (either csv or restarted game).
        public void GenerateBoard (int[] newBoard)
        {
            int cellNum = newBoard.ToArray().Length;
            maxNum = TheSudoku.GetMaxValue();
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
            string value = "";
            if (newNum != 0)
            {
                value = newNum.ToString();
            }
            TextBox Cell = new TextBox
            {
                Name = positionIndex.ToString(),
                Size = new Size(30, 30),
                MaxLength = 1,
                Text = value,
                TextAlign = HorizontalAlignment.Center,
                ReadOnly = readOnly,
                Font = new Font(Font.FontFamily, 24),
                Location = new Point(newX, newY)
            };
            Cell.TextChanged += new EventHandler(Cell_TextChanged);
            GameBoard.Controls.Add(Cell);
            GameBoard.Show();
        }

        // function which submits input to game board and verifys game board based on cell entered. !!most important!!
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
                        TheSudoku.board[position] = input;
                        CheckAndSet();
                    }
                    else
                    {
                        MessageBox.Show(string.Concat("Please enter a number from 1 to ", maxNum), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CheckAndSet();
                    }
                }
                else
                {
                    MessageBox.Show("Please only enter numbers.");
                    CheckAndSet();
                }
            }
        }
        // functions which checks current game board for any completed rows/columns/boxes
        public void CheckBoard()
        {
            for (int i = 0; i <= maxNum; i++)
            {
                if (TheSudoku.CheckRow(i))
                {
                    validRows.Add(i);
                }
                if (TheSudoku.CheckColumn(i))
                {
                    validColumns.Add(i);
                }
            }
            validRows.RemoveAt(0);
            validColumns.RemoveAt(0);
            CheckSquares();
            CheckVictory();
        }
        public void CheckAndSet()
        {
            CheckBoard();
            SetLabels();
            EmptyLists();
        }
        public void CheckSquares()
        {
            for(int i = 0; i < maxNum; i++)
            {
                if (TheSudoku.CheckBox(i))
                {
                    validSquares.Add(i);
                }
            }
            
        }
        public void EmptyLists()
        {
            validRows.Clear();
            validColumns.Clear();
            validSquares.Clear();
        }
        // functions which set the valid labels based on number of valid rows/columns/squares
        public void SetLabels()
        {
            SetRowLabel(validRows);
            SetColLabel(validColumns);
            SetSquareLabel(validSquares);
            EmptyLists();
        }
        public void HideValidLabels()
        {
            lblRowsValid.Visible = false;
            lblColsValid.Visible = false;
            lblSquaresValid.Visible = false;
        }
        public void ShowValidLabels()
        {
            lblRowsValid.Visible = true;
            lblColsValid.Visible = true;
            lblSquaresValid.Visible = true;
        }
        public void SetRowLabel(List<int> newValidRows)
        {
            string text = "Rows that are valid: ";
            if (newValidRows.Count() == 0)
            {
                text = "No rows are currently valid.";
            }
            else
            {
                for (int i = 0; i <= (newValidRows.Count - 1); i++)
                {
                    text += "#" + newValidRows[i] + ", ";
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
                    text += "#" + newValidCols[i] + ", ";
                }
            }
            lblColsValid.Text = text;
        }
        public void SetSquareLabel(List<int> newValidSquares)
        {
            string text = "boxes that are valid: ";
            if (newValidSquares.Count() == 0)
            {
                text = "No boxes are currently valid.";
            }
            else
            {
                for (int i = 0; i <= newValidSquares.Count - 1; i++)
                {
                    text += "#" + (newValidSquares[i] + 1) + ", ";
                }
            }
            lblSquaresValid.Text = text;
        }
        // boolean function which checks whether number is within appropriate range
        public bool WithinValidRange(int newNum)
        {
            bool isValid = false;
            if (newNum > 0 && newNum <= TheSudoku.maxValue)
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
                    string contents = File.ReadAllText(file);
                    originalBoard = File.ReadAllText(file);
                    TheSudoku.FromCSV(contents);
                }
                catch (IOException)
                {
                }
            }
        }

        // function for restarting the game using original string. 
        public void ResetBoard ()
        {
            TheSudoku.FromCSV(originalBoard);
            CheckBoard();
            SetRowLabel(validRows);
            SetColLabel(validColumns);
            SetSquareLabel(validSquares);
        }
        // victory checking/setting function
        public void CheckVictory ()
        {
            if (validRows.Count == maxNum && validColumns.Count == maxNum && validSquares.Count == maxNum)
            {
                MessageBox.Show("you win nice");
                HideValidLabels();
                GameBoard.Visible = false;
                lblVictory.Text += lblMinuteTimer.Text + " and " + TheStopWatch.Elapsed.Seconds.ToString() + " seconds.";
                lblVictory.Visible = true;
                theTimer.Stop();
                TheStopWatch.Stop();

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
                    string Contents = TheSudoku.ToCSV();
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
            TheStopWatch.Start();
        }

        public void PauseTimer ()
        {
            theTimer.Stop();
            TheStopWatch.Stop();
        }
    }
}
