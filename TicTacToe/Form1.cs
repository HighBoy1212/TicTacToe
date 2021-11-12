using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePlay;
using System.IO;
using System.Reflection;

namespace TicTacToe {
    public partial class Form1 : Form {
        // The contents of the grid.
        private CellContent[,] accCells = new CellContent[3, 3];
        // The current player. Express in terms of the content that player would put
        // into a cell.
        private CellContent ccCurrentPlayer;
        // Tell whether we are playing. This allows us to stop game play if one of
        // the players wins the game.
        private bool bPlaying;

        public Form1() {
            InitializeComponent();

            // Add grid coordinates to each picture box in the grid, to make it easy
            // to determine which cell was clicked when the user clicks in the grid.
            this.pbx00.Tag = new Point(0, 0);
            this.pbx01.Tag = new Point(0, 1);
            this.pbx02.Tag = new Point(0, 2);
            this.pbx10.Tag = new Point(1, 0);
            this.pbx11.Tag = new Point(1, 1);
            this.pbx12.Tag = new Point(1, 2);
            this.pbx20.Tag = new Point(2, 0);
            this.pbx21.Tag = new Point(2, 1);
            this.pbx22.Tag = new Point(2, 2);

            // Initialize the grid.
            vInitGrid();

            // We are playing, and X plays first.
            bPlaying = true;
            ccCurrentPlayer = CellContent.X;
        }

        // Initialize the grid to all empty cells, and set the picture boxes to all
        // show the Blank image.
        private void vInitGrid() {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    accCells[i, j] = CellContent.Empty;
                }
            }

            this.pbx00.Image = TicTacToe.Properties.Resources.Blank;
            this.pbx01.Image = TicTacToe.Properties.Resources.Blank;
            this.pbx02.Image = TicTacToe.Properties.Resources.Blank;
            this.pbx10.Image = TicTacToe.Properties.Resources.Blank;
            this.pbx11.Image = TicTacToe.Properties.Resources.Blank;
            this.pbx12.Image = TicTacToe.Properties.Resources.Blank;
            this.pbx20.Image = TicTacToe.Properties.Resources.Blank;
            this.pbx21.Image = TicTacToe.Properties.Resources.Blank;
            this.pbx22.Image = TicTacToe.Properties.Resources.Blank;
        }

        private void tsmiNewGame_Click(object sender, EventArgs e) {
            // Reinitialize the grid, set the current player to X, and say we
            // are playing.
            vInitGrid();
            ccCurrentPlayer = CellContent.X;
            bPlaying = true;
        }

        private void tsmiQuit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void pbx00_Click(object sender, EventArgs e) {
            // Do something only if we are still playing.
            if (bPlaying) {
                // Get the picture box the user clicked on and determine its coordinates
                // (row = X, column = Y).
                PictureBox pbxClicked = (PictureBox)sender;
                Point ptCoords = (Point)(pbxClicked.Tag);
                // Do something only if that cell is empty.
                if (accCells[ptCoords.X, ptCoords.Y] == CellContent.Empty) {
                    // Update the cell.
                    vUpdateCell(ptCoords.X, ptCoords.Y);
                    // If the game is not over, switch player and let the AI move.
                    if (!bGameOver()) {
                        // Switch player and let AI play.
                        vSwitchPlayer();
                        vAIMove();
                    }
                }
            }
        }

        // Update a cell to be taken by the current player.
        private void vUpdateCell(int iRow, int iCol) {
            // Find the picture box from the row and column number.
            string strPBName = "pbx" + iRow.ToString() + iCol.ToString();
            PictureBox pbxClicked = this.Controls.Find(strPBName, true).SingleOrDefault() as PictureBox;
            accCells[iRow, iCol] = ccCurrentPlayer;
            if (ccCurrentPlayer == CellContent.O) {
                pbxClicked.Image = TicTacToe.Properties.Resources.O;
            } else {
                pbxClicked.Image = TicTacToe.Properties.Resources.X;
            }
        }

        // Switch player.
        private void vSwitchPlayer() {
            if (ccCurrentPlayer == CellContent.O) {
                ccCurrentPlayer = CellContent.X;
            } else {
                ccCurrentPlayer = CellContent.O;
            }
        }

        // Check whether the game is over, because of a win or a cat's game.
        private bool bGameOver() {
            if (bCheckWin()) {
				// Announce winner and stop game play.
				MessageBox.Show("Winner: " + ccCurrentPlayer.ToString());
				bPlaying = false;
                return true;
            } else if (bCheckCatsGame()) {
                // Announce cat's game and stop game play.
                MessageBox.Show("Cat's Game");
                bPlaying = false;
                return true;
            } else {
                // Game not over yet.
                return false;
            }
        }

        // Check for a win.
        private bool bCheckWin() {
            // Check for a win along one of the rows.
            for (int iRow = 0; iRow < 3; iRow++) {
                if (bCheckRowWin(iRow)) {
                    return true;
                }
            }
            // No row win. Check for a win down one of the columns.
            for (int iCol = 0; iCol < 3; iCol++) {
                if (bCheckColWin(iCol)) {
                    return true;
                }
            }
            // No column win either. Check for a diagonal win.
            if (bCheckDiagWin()) {
                return true;
            }
            // Last chance: A win down the reverse diagonal. The result here (true or
            // false is the final result.
            return bCheckRevDiagWin();
        }

        // Check for a win along a row.
        private bool bCheckRowWin(int iRow) {
            // Check each column in this row. If any cell is not marked by the current
            // player then there is no win in this row.
            for (int iCol = 0; iCol < 3; iCol++) {
                if (accCells[iRow, iCol] != ccCurrentPlayer) {
                    return false;
                }
            }
            // If we get here then all cells in the row are marked by the current player,
            // so there is a win in this row.
            return true;
        }

        // Check for a win down a column. Similar to checking for a win along a row.
        private bool bCheckColWin(int iCol) {
            for (int iRow = 0; iRow < 3; iRow++) {
                if (accCells[iRow, iCol] != ccCurrentPlayer) {
                    return false;
                }
            }
            return true;
        }

        // Check for a win down the main diagonal.
        private bool bCheckDiagWin() {
            for (int iRC = 0; iRC < 3; iRC++) {
                if (accCells[iRC, iRC] != ccCurrentPlayer) {
                    return false;
                }
            }
            return true;
		}

		// Check for a win down the reverse diagonal.
		private bool bCheckRevDiagWin() {
			for (int iRC = 0; iRC < 3; iRC++) {
				if (accCells[iRC, 2 - iRC] != ccCurrentPlayer) {
					return false;
				}
			}
			return true;
		}

        // Check for a cat's game.
        private bool bCheckCatsGame() {
            // Loop through all of the cells. If any are still empty then it is not a
            // cat's game.
            for (int iRow = 0; iRow < 3; iRow++) {
                for (int iCol = 0; iCol < 3; iCol++) {
                    if (accCells[iRow, iCol] == CellContent.Empty) {
                        return false;
                    }
                }
            }
            return true;
        }

        // Have the AI move.
        private void vAIMove() {
            // Only have the AI make the next move if one has been selected in the
            // combo box.
            if (cboAILevel.SelectedIndex >= 0) {
                // Get the plugin selected in the combobox
                IAIPlugin objChosenAI = (IAIPlugin)cboAILevel.SelectedItem;
                // Get the AI's next move
                Point ptNextMove = objChosenAI.NextMove(accCells, ccCurrentPlayer);
                // Do something only if that cell is empty.
                if (accCells[ptNextMove.X, ptNextMove.Y] == CellContent.Empty)
                {
                    // Update the cell.
                    vUpdateCell(ptNextMove.X, ptNextMove.Y);
                    // If the game is not over, switch player and let the AI move.
                    if (!bGameOver())
                    {
                        // Switch player and let AI play.
                        vSwitchPlayer();
                    }
                }
                // Selected cell is not empty. End game
                else
                {
                    MessageBox.Show("There has been an internal error with the AI. The game has been stopped");
                    bPlaying = false;
                }
            }
        }

        // A function to load the AI Level objects into the combo box
        private void vLoadComboBox()
        {
            // Create a list of objects for the different AI levels
            List<IAIPlugin> lstMethods = new List<IAIPlugin>();
            // Load the list from all of the DLL's
            vLoadFromDLLs(lstMethods);
            // Tell the combobox to use the list as the source of items
            cboAILevel.DataSource = lstMethods;
            // Tell the combobox to use the "Name" property of the objects as the 
            // text to display for each item
            cboAILevel.DisplayMember = "Name";
        }

        // Function to load the list of AI Level objects from the DLL's
        private void vLoadFromDLLs(List<IAIPlugin> lstMethods)
        {
            // Load all of the plugin DLL's that are listed in the file PluginList.txt
            using (StreamReader srPlugins = new StreamReader("Plugins\\PluginList.txt"))
            {
                // Read a line from the file
                string strOneLine = srPlugins.ReadLine();
                // The line read is a valid line from the file if it is not null
                while (strOneLine != null)
                {
                    // Construct the complete file name
                    string strFileName = "Plugins\\" + strOneLine;
                    Assembly asmAILevel = Assembly.LoadFrom(strFileName);
                    // Loop through the types exported by the DLL, create an instance of each one
                    // and add the instance to the list of AI's
                    foreach (Type tAI in asmAILevel.ExportedTypes)
                    {
                        // Create an instance of the type and add it to the list
                        try
                        {
                            IAIPlugin aiObject = (IAIPlugin)asmAILevel.CreateInstance(tAI.FullName);
                            lstMethods.Add(aiObject);
                        }
                        catch { }
                    }
                    // Read the next line from the file
                    strOneLine = srPlugins.ReadLine();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load the combobox names
            vLoadComboBox();
        }
    }
}
