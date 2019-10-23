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
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.GameBoard = new System.Windows.Forms.Panel();
            this.lblSecondTimer = new System.Windows.Forms.Label();
            this.theTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.grpBoxCtrls = new System.Windows.Forms.GroupBox();
            this.lblMinuteTimer = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblRowsValid = new System.Windows.Forms.Label();
            this.lblColsValid = new System.Windows.Forms.Label();
            this.lblSquaresValid = new System.Windows.Forms.Label();
            this.grpBoxCtrls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(6, 291);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(103, 42);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.Location = new System.Drawing.Point(144, 291);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(105, 42);
            this.btnRedo.TabIndex = 1;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGame.Location = new System.Drawing.Point(7, 12);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(103, 42);
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
            this.btnLoadGame.Size = new System.Drawing.Size(111, 42);
            this.btnLoadGame.TabIndex = 3;
            this.btnLoadGame.Text = "Load Game!";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // GameBoard
            // 
            this.GameBoard.BackColor = System.Drawing.Color.Bisque;
            this.GameBoard.Location = new System.Drawing.Point(333, 39);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(403, 310);
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
            this.lblSecondTimer.Click += new System.EventHandler(this.lblTimer_Click);
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
            this.grpBoxCtrls.Controls.Add(this.lblMinuteTimer);
            this.grpBoxCtrls.Controls.Add(this.btnRestart);
            this.grpBoxCtrls.Controls.Add(this.lblSecondTimer);
            this.grpBoxCtrls.Controls.Add(this.btnPause);
            this.grpBoxCtrls.Controls.Add(this.btnResume);
            this.grpBoxCtrls.Controls.Add(this.btnUndo);
            this.grpBoxCtrls.Controls.Add(this.btnRedo);
            this.grpBoxCtrls.Location = new System.Drawing.Point(7, 73);
            this.grpBoxCtrls.Name = "grpBoxCtrls";
            this.grpBoxCtrls.Size = new System.Drawing.Size(255, 339);
            this.grpBoxCtrls.TabIndex = 13;
            this.grpBoxCtrls.TabStop = false;
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
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(302, 12);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(468, 24);
            this.lblInstructions.TabIndex = 14;
            this.lblInstructions.Text = "Click a cell to select it, type a number and press Enter!";
            // 
            // lblRowsValid
            // 
            this.lblRowsValid.AutoSize = true;
            this.lblRowsValid.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsValid.Location = new System.Drawing.Point(329, 352);
            this.lblRowsValid.Name = "lblRowsValid";
            this.lblRowsValid.Size = new System.Drawing.Size(224, 21);
            this.lblRowsValid.TabIndex = 15;
            this.lblRowsValid.Text = "No rows are currently valid.";
            // 
            // lblColsValid
            // 
            this.lblColsValid.AutoSize = true;
            this.lblColsValid.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColsValid.Location = new System.Drawing.Point(329, 373);
            this.lblColsValid.Name = "lblColsValid";
            this.lblColsValid.Size = new System.Drawing.Size(253, 21);
            this.lblColsValid.TabIndex = 16;
            this.lblColsValid.Text = "No columns are currently valid.";
            // 
            // lblSquaresValid
            // 
            this.lblSquaresValid.AutoSize = true;
            this.lblSquaresValid.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquaresValid.Location = new System.Drawing.Point(329, 394);
            this.lblSquaresValid.Name = "lblSquaresValid";
            this.lblSquaresValid.Size = new System.Drawing.Size(246, 21);
            this.lblSquaresValid.TabIndex = 17;
            this.lblSquaresValid.Text = "No squares are currently valid.";
            // 
            // SudokuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(793, 421);
            this.Controls.Add(this.lblSquaresValid);
            this.Controls.Add(this.lblColsValid);
            this.Controls.Add(this.lblRowsValid);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.grpBoxCtrls);
            this.Controls.Add(this.GameBoard);
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

        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
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
    }
}

