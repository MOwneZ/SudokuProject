namespace Sudoku
{
    partial class SudokuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.GameBoard = new System.Windows.Forms.Panel();
            this.lblSecondTimer = new System.Windows.Forms.Label();
            this.theTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.grpBoxCtrls = new System.Windows.Forms.GroupBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblGamePaused = new System.Windows.Forms.Label();
            this.lblMinuteTimer = new System.Windows.Forms.Label();
            this.lblSquaresValid = new System.Windows.Forms.Label();
            this.lblColsValid = new System.Windows.Forms.Label();
            this.lblRowsValid = new System.Windows.Forms.Label();
            this.lblVictory = new System.Windows.Forms.Label();
            this.grpBoxCtrls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGame.Location = new System.Drawing.Point(7, 12);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(103, 28);
            this.btnSaveGame.TabIndex = 2;
            this.btnSaveGame.Text = "Save Game";
            this.btnSaveGame.UseVisualStyleBackColor = true;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGame.Location = new System.Drawing.Point(151, 12);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(111, 28);
            this.btnLoadGame.TabIndex = 3;
            this.btnLoadGame.Text = "Load Game!";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // GameBoard
            // 
            this.GameBoard.AutoSize = true;
            this.GameBoard.BackColor = System.Drawing.Color.Bisque;
            this.GameBoard.Location = new System.Drawing.Point(272, 12);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(0, 0);
            this.GameBoard.TabIndex = 6;
            // 
            // lblSecondTimer
            // 
            this.lblSecondTimer.AutoSize = true;
            this.lblSecondTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondTimer.Location = new System.Drawing.Point(55, 96);
            this.lblSecondTimer.Name = "lblSecondTimer";
            this.lblSecondTimer.Size = new System.Drawing.Size(142, 31);
            this.lblSecondTimer.TabIndex = 9;
            this.lblSecondTimer.Text = "0 Seconds";
            // 
            // theTimer
            // 
            this.theTimer.Interval = 1000;
            this.theTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(18, 130);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(91, 36);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.Location = new System.Drawing.Point(135, 130);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(91, 36);
            this.btnResume.TabIndex = 11;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(73, 172);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(101, 36);
            this.btnRestart.TabIndex = 12;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // grpBoxCtrls
            // 
            this.grpBoxCtrls.BackColor = System.Drawing.Color.PaleGreen;
            this.grpBoxCtrls.Controls.Add(this.lblInstructions);
            this.grpBoxCtrls.Controls.Add(this.lblGamePaused);
            this.grpBoxCtrls.Controls.Add(this.lblMinuteTimer);
            this.grpBoxCtrls.Controls.Add(this.btnRestart);
            this.grpBoxCtrls.Controls.Add(this.lblSecondTimer);
            this.grpBoxCtrls.Controls.Add(this.btnPause);
            this.grpBoxCtrls.Controls.Add(this.btnResume);
            this.grpBoxCtrls.Location = new System.Drawing.Point(7, 73);
            this.grpBoxCtrls.Name = "grpBoxCtrls";
            this.grpBoxCtrls.Size = new System.Drawing.Size(255, 339);
            this.grpBoxCtrls.TabIndex = 13;
            this.grpBoxCtrls.TabStop = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(33, 16);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(181, 34);
            this.lblInstructions.TabIndex = 14;
            this.lblInstructions.Text = "Select a cell, enter a number\r\n then press enter!\r\n";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGamePaused
            // 
            this.lblGamePaused.AutoSize = true;
            this.lblGamePaused.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamePaused.Location = new System.Drawing.Point(16, 223);
            this.lblGamePaused.Name = "lblGamePaused";
            this.lblGamePaused.Size = new System.Drawing.Size(210, 102);
            this.lblGamePaused.TabIndex = 0;
            this.lblGamePaused.Text = "Game Paused.\r\nBoard edits\r\nunavaliable!";
            // 
            // lblMinuteTimer
            // 
            this.lblMinuteTimer.AutoSize = true;
            this.lblMinuteTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuteTimer.Location = new System.Drawing.Point(55, 65);
            this.lblMinuteTimer.Name = "lblMinuteTimer";
            this.lblMinuteTimer.Size = new System.Drawing.Size(149, 31);
            this.lblMinuteTimer.TabIndex = 13;
            this.lblMinuteTimer.Text = "0 Minute(s)";
            // 
            // lblSquaresValid
            // 
            this.lblSquaresValid.AutoSize = true;
            this.lblSquaresValid.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquaresValid.Location = new System.Drawing.Point(268, 391);
            this.lblSquaresValid.Name = "lblSquaresValid";
            this.lblSquaresValid.Size = new System.Drawing.Size(246, 21);
            this.lblSquaresValid.TabIndex = 17;
            this.lblSquaresValid.Text = "No squares are currently valid.";
            // 
            // lblColsValid
            // 
            this.lblColsValid.AutoSize = true;
            this.lblColsValid.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColsValid.Location = new System.Drawing.Point(268, 370);
            this.lblColsValid.Name = "lblColsValid";
            this.lblColsValid.Size = new System.Drawing.Size(253, 21);
            this.lblColsValid.TabIndex = 16;
            this.lblColsValid.Text = "No columns are currently valid.";
            // 
            // lblRowsValid
            // 
            this.lblRowsValid.AutoSize = true;
            this.lblRowsValid.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsValid.Location = new System.Drawing.Point(268, 349);
            this.lblRowsValid.Name = "lblRowsValid";
            this.lblRowsValid.Size = new System.Drawing.Size(224, 21);
            this.lblRowsValid.TabIndex = 15;
            this.lblRowsValid.Text = "No rows are currently valid.";
            // 
            // lblVictory
            // 
            this.lblVictory.AutoSize = true;
            this.lblVictory.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVictory.Location = new System.Drawing.Point(298, 17);
            this.lblVictory.Name = "lblVictory";
            this.lblVictory.Size = new System.Drawing.Size(194, 87);
            this.lblVictory.TabIndex = 18;
            this.lblVictory.Text = "Congratulations!\r\nYou win!\r\nTime:";
            this.lblVictory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SudokuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(270, 45);
            this.Controls.Add(this.lblVictory);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.lblSquaresValid);
            this.Controls.Add(this.grpBoxCtrls);
            this.Controls.Add(this.lblColsValid);
            this.Controls.Add(this.GameBoard);
            this.Controls.Add(this.lblRowsValid);
            this.Controls.Add(this.btnLoadGame);
            this.Name = "SudokuForm";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.SudokuForm_Load);
            this.grpBoxCtrls.ResumeLayout(false);
            this.grpBoxCtrls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Panel GameBoard;
        private System.Windows.Forms.Label lblSecondTimer;
        private System.Windows.Forms.Timer theTimer;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.GroupBox grpBoxCtrls;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblMinuteTimer;
        private System.Windows.Forms.Label lblRowsValid;
        private System.Windows.Forms.Label lblColsValid;
        private System.Windows.Forms.Label lblSquaresValid;
        private System.Windows.Forms.Label lblGamePaused;
        private System.Windows.Forms.Label lblVictory;
    }
}

