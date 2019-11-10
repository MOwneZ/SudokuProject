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
            ShowValidLabels();
            GenerateBoard(TheSudoku.board);
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
            lblSecondTimer.Text = TheStopWatch.Elapsed.Seconds.ToString() + " Seconds";
            if (TheStopWatch.Elapsed.Seconds.ToString() == "59")
            {
                Minutes++;
                lblMinuteTimer.Text = Minutes.ToString() + " Minute(s)";
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseTimer();
            GameBoard.Visible = false;
            lblGamePaused.Visible = true;
        }
        private void btnResume_Click(object sender, EventArgs e)
        {
            GameBoard.Visible = true;
            lblGamePaused.Visible = false;
            theTimer.Start();
            TheStopWatch.Start();
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Minutes = 0;
            lblMinuteTimer.Text = "0 Minute(s)";
            lblGamePaused.Visible = false;
            TheStopWatch.Restart();
            ResetBoard();
            GenerateBoard(TheSudoku.board);
            StartTimer();
        }
        private void SudokuForm_Load(object sender, EventArgs e)
        {
            grpBoxCtrls.Visible = false;
            lblInstructions.Visible = false;
            lblGamePaused.Visible = false;
            lblVictory.Visible = false;
            HideValidLabels();
            this.MinimumSize = new Size(this.Width, this.Height);          
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
