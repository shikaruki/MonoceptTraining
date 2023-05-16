using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib.Model
{
    public class CellAlreadyMarkedException:Exception
    {
        public CellAlreadyMarkedException() : base("The cell is already marked.")
        {
        }
    }
}
