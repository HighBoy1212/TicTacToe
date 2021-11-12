using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePlay;
using System.Drawing;

namespace AI1
{
    public class FirstAI : IAIPlugin
    {
        // Name of AI
        public string Name
        {
            get
            {
                return "Easy";
            }
        }
        // Function to make the next move
        public Point NextMove(CellContent[,] accCells, CellContent ccCurrentPlayer)
        {
            Random rnd = new Random();
            int iCount = 0;
            // variables to hold the values of unnoccupied cells
            int X = rnd.Next(3);
            int Y = rnd.Next(3);
            Point ptCoords = new Point(X, Y);

            // Check for a possible win in each row
            // Loop through rows
            for (int iRow = 0; iRow < 3; iRow++)
            {
                // Loop through columns in each row
                for (int iCol = 0; iCol < 3; iCol++)
                {
                    // Checks to see if current cell is not AI's
                    if (accCells[iRow, iCol] == CellContent.Empty)
                    {
                        X = iRow;
                        Y = iCol;
                    }
                    // keeps track of the number of AI cells in a row
                    else if (accCells[iRow, iCol] == ccCurrentPlayer)
                    {
                        iCount++;
                    }
                    // Check to see if the AI has two in a row and the third cell is empty
                    if (iCount == 2)
                    {
                        // Make and return point with winning coordinates
                        ptCoords.X = X;
                        ptCoords.Y = Y;
                        return ptCoords;
                    }
                }
                iCount = 0;
            }

            // Check for a possible win in each Column
            // Loop through columns
            for (int iCol = 0; iCol < 3; iCol++)
            {
                // Loop through rows in each column
                for (int iRow = 0; iRow < 3; iRow++)
                {
                    // Checks to see if current cell is not AI's
                    if (accCells[iRow, iCol] == CellContent.Empty)
                    {
                        X = iRow;
                        Y = iCol;
                        Console.WriteLine(iRow.ToString() + "," + iCol.ToString());
                    }
                    // Keeps track of the number of AI cells in a column
                    else if (accCells[iRow, iCol] == ccCurrentPlayer)
                    {
                        iCount++;
                    }
                    // Check to see if the AI has two in a row and the third cell is empty
                    if (iCount == 2)
                    {
                        // Make and return point with winning coordinates
                        ptCoords.X = X;
                        ptCoords.Y = Y;
                        return ptCoords;
                    }
                }
                iCount = 0;
            }

            // Check for possible win down diagonal
            // Loop through coordinates on the diagonal
            for (int iRC = 0; iRC < 3; iRC++)
            {
                // Checks to see if current cell is not AI's
                if (accCells[iRC, iRC] == CellContent.Empty)
                {
                    X = iRC;
                    Y = iRC;
                }
                // Keeps track of the number of AI cells on diagonal
                else if (accCells[iRC, iRC] == ccCurrentPlayer)
                {
                    iCount++;
                }
                // Check to see if the AI has two on the diagonal and the third is empty
                if (iCount == 2)
                {
                    // Make and return point with winning coordinates
                    ptCoords.X = X;
                    ptCoords.Y = Y;
                    return ptCoords;
                }
            }

            // Check for possible win down reverse diagonal
            iCount = 0;
            // Loop through coordinates on the reverse diagonal
            for (int iRC = 0; iRC < 3; iRC++)
            {
                // Checks to see if current cell is not AI's
                if (accCells[iRC, 2 - iRC] == CellContent.Empty)
                {
                    X = iRC;
                    Y = 2 - iRC;
                }
                // Keeps track of the number of AI cells on diagonal
                else if (accCells[iRC, 2-iRC] == ccCurrentPlayer)
                {
                    iCount++;
                }
                // Check to see if the AI has two on the diagonal and the third is empty
                if (iCount == 2)
                {
                    // Make and return point with winning coordinates
                    ptCoords.X = X;
                    ptCoords.Y = Y;
                    return ptCoords;
                }
            }

            while (accCells[ptCoords.X, ptCoords.Y] != CellContent.Empty)
            {
                ptCoords.X = rnd.Next(3);
                ptCoords.Y = rnd.Next(3);
            }
            return ptCoords;
        }
    }
}
