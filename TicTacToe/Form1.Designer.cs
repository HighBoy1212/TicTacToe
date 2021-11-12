namespace TicTacToe {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAILevel = new System.Windows.Forms.Label();
            this.cboAILevel = new System.Windows.Forms.ComboBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pbx22 = new System.Windows.Forms.PictureBox();
            this.pbx21 = new System.Windows.Forms.PictureBox();
            this.pbx20 = new System.Windows.Forms.PictureBox();
            this.pbx12 = new System.Windows.Forms.PictureBox();
            this.pbx11 = new System.Windows.Forms.PictureBox();
            this.pbx10 = new System.Windows.Forms.PictureBox();
            this.pbx02 = new System.Windows.Forms.PictureBox();
            this.pbx01 = new System.Windows.Forms.PictureBox();
            this.pbx00 = new System.Windows.Forms.PictureBox();
            this.msMain.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx00)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGame});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(284, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiGame
            // 
            this.tsmiGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewGame,
            this.tsmiQuit});
            this.tsmiGame.Name = "tsmiGame";
            this.tsmiGame.Size = new System.Drawing.Size(50, 20);
            this.tsmiGame.Text = "Game";
            // 
            // tsmiNewGame
            // 
            this.tsmiNewGame.Name = "tsmiNewGame";
            this.tsmiNewGame.Size = new System.Drawing.Size(132, 22);
            this.tsmiNewGame.Text = "New Game";
            this.tsmiNewGame.Click += new System.EventHandler(this.tsmiNewGame_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(132, 22);
            this.tsmiQuit.Text = "Quit";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // lblAILevel
            // 
            this.lblAILevel.AutoSize = true;
            this.lblAILevel.Location = new System.Drawing.Point(12, 30);
            this.lblAILevel.Name = "lblAILevel";
            this.lblAILevel.Size = new System.Drawing.Size(46, 13);
            this.lblAILevel.TabIndex = 1;
            this.lblAILevel.Text = "AI Level";
            // 
            // cboAILevel
            // 
            this.cboAILevel.FormattingEnabled = true;
            this.cboAILevel.Location = new System.Drawing.Point(64, 27);
            this.cboAILevel.Name = "cboAILevel";
            this.cboAILevel.Size = new System.Drawing.Size(121, 21);
            this.cboAILevel.TabIndex = 2;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.Black;
            this.pnlGrid.Controls.Add(this.pbx22);
            this.pnlGrid.Controls.Add(this.pbx21);
            this.pnlGrid.Controls.Add(this.pbx20);
            this.pnlGrid.Controls.Add(this.pbx12);
            this.pnlGrid.Controls.Add(this.pbx11);
            this.pnlGrid.Controls.Add(this.pbx10);
            this.pnlGrid.Controls.Add(this.pbx02);
            this.pnlGrid.Controls.Add(this.pbx01);
            this.pnlGrid.Controls.Add(this.pbx00);
            this.pnlGrid.Location = new System.Drawing.Point(20, 54);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(244, 244);
            this.pnlGrid.TabIndex = 3;
            // 
            // pbx22
            // 
            this.pbx22.Image = global::TicTacToe.Properties.Resources.Blank;
            this.pbx22.Location = new System.Drawing.Point(164, 164);
            this.pbx22.Name = "pbx22";
            this.pbx22.Size = new System.Drawing.Size(80, 80);
            this.pbx22.TabIndex = 8;
            this.pbx22.TabStop = false;
            this.pbx22.Click += new System.EventHandler(this.pbx00_Click);
            // 
            // pbx21
            // 
            this.pbx21.Image = global::TicTacToe.Properties.Resources.Blank;
            this.pbx21.Location = new System.Drawing.Point(82, 164);
            this.pbx21.Name = "pbx21";
            this.pbx21.Size = new System.Drawing.Size(80, 80);
            this.pbx21.TabIndex = 7;
            this.pbx21.TabStop = false;
            this.pbx21.Click += new System.EventHandler(this.pbx00_Click);
            // 
            // pbx20
            // 
            this.pbx20.Image = global::TicTacToe.Properties.Resources.Blank;
            this.pbx20.Location = new System.Drawing.Point(0, 164);
            this.pbx20.Name = "pbx20";
            this.pbx20.Size = new System.Drawing.Size(80, 80);
            this.pbx20.TabIndex = 6;
            this.pbx20.TabStop = false;
            this.pbx20.Click += new System.EventHandler(this.pbx00_Click);
            // 
            // pbx12
            // 
            this.pbx12.Image = global::TicTacToe.Properties.Resources.Blank;
            this.pbx12.Location = new System.Drawing.Point(164, 82);
            this.pbx12.Name = "pbx12";
            this.pbx12.Size = new System.Drawing.Size(80, 80);
            this.pbx12.TabIndex = 5;
            this.pbx12.TabStop = false;
            this.pbx12.Click += new System.EventHandler(this.pbx00_Click);
            // 
            // pbx11
            // 
            this.pbx11.Image = global::TicTacToe.Properties.Resources.Blank;
            this.pbx11.Location = new System.Drawing.Point(82, 82);
            this.pbx11.Name = "pbx11";
            this.pbx11.Size = new System.Drawing.Size(80, 80);
            this.pbx11.TabIndex = 4;
            this.pbx11.TabStop = false;
            this.pbx11.Click += new System.EventHandler(this.pbx00_Click);
            // 
            // pbx10
            // 
            this.pbx10.Image = global::TicTacToe.Properties.Resources.Blank;
            this.pbx10.Location = new System.Drawing.Point(0, 82);
            this.pbx10.Name = "pbx10";
            this.pbx10.Size = new System.Drawing.Size(80, 80);
            this.pbx10.TabIndex = 3;
            this.pbx10.TabStop = false;
            this.pbx10.Click += new System.EventHandler(this.pbx00_Click);
            // 
            // pbx02
            // 
            this.pbx02.Image = global::TicTacToe.Properties.Resources.Blank;
            this.pbx02.Location = new System.Drawing.Point(164, 0);
            this.pbx02.Name = "pbx02";
            this.pbx02.Size = new System.Drawing.Size(80, 80);
            this.pbx02.TabIndex = 2;
            this.pbx02.TabStop = false;
            this.pbx02.Click += new System.EventHandler(this.pbx00_Click);
            // 
            // pbx01
            // 
            this.pbx01.Image = global::TicTacToe.Properties.Resources.Blank;
            this.pbx01.Location = new System.Drawing.Point(82, 0);
            this.pbx01.Name = "pbx01";
            this.pbx01.Size = new System.Drawing.Size(80, 80);
            this.pbx01.TabIndex = 1;
            this.pbx01.TabStop = false;
            this.pbx01.Click += new System.EventHandler(this.pbx00_Click);
            // 
            // pbx00
            // 
            this.pbx00.Image = global::TicTacToe.Properties.Resources.Blank;
            this.pbx00.Location = new System.Drawing.Point(0, 0);
            this.pbx00.Name = "pbx00";
            this.pbx00.Size = new System.Drawing.Size(80, 80);
            this.pbx00.TabIndex = 0;
            this.pbx00.TabStop = false;
            this.pbx00.Click += new System.EventHandler(this.pbx00_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 310);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.cboAILevel);
            this.Controls.Add(this.lblAILevel);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx00)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiGame;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewGame;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.Label lblAILevel;
        private System.Windows.Forms.ComboBox cboAILevel;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.PictureBox pbx00;
        private System.Windows.Forms.PictureBox pbx02;
        private System.Windows.Forms.PictureBox pbx01;
        private System.Windows.Forms.PictureBox pbx22;
        private System.Windows.Forms.PictureBox pbx21;
        private System.Windows.Forms.PictureBox pbx20;
        private System.Windows.Forms.PictureBox pbx12;
        private System.Windows.Forms.PictureBox pbx11;
        private System.Windows.Forms.PictureBox pbx10;
    }
}

