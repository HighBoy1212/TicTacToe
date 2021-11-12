using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GamePlay {
    public interface IAIPlugin {
        // A property to return the name of the AI
        string Name
        {
            get;
        }
        // The function to compute the AI's next move
        Point NextMove(CellContent[,] Grid, CellContent PlayerIinfo);
    }
}
