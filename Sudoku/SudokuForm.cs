using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SudokuForm : Form
    {
        public int Minutes;
        public SudokuForm()
        {
            InitializeComponent();
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {

        }  
        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            LoadCsvFromFile();
            grpBoxCtrls.Visible = true;
            lblInstructions.Visible = true;
            GenerateBoard(theSudoku.board);
            CheckBoard();
            SetLabels();
            StartTimer();
        }
        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            SaveCsvToFile();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSecondTimer.Text = theStopWatch.Elapsed.Seconds.ToString() + " Seconds";
            if (theStopWatch.Elapsed.Seconds.ToString() == "59")
            {
                Minutes++;
                lblMinuteTimer.Text = Minutes.ToString() + " Minute(s)";
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseTimer();
        }
        private void btnResume_Click(object sender, EventArgs e)
        {
            theTimer.Start();
            theStopWatch.Start();
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            GenerateBoard(theSudoku.originalBoard);
            StartTimer();
        }
        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
        private void SudokuForm_Load(object sender, EventArgs e)
        {
            grpBoxCtrls.Visible = false;
            lblInstructions.Visible = false;
        }
    }
}
