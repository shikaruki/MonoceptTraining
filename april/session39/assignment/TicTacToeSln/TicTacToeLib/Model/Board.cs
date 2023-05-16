using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib.Model
{
    public class Board
    {
        private Cell[] _cells;
        public Board()
        {
            _cells = new Cell[9];
            InitializeCells();
        }
        public void InitializeCells()
        {
            for(int i = 0; i < 9; i++)
            {
                _cells[i]= new Cell();
            }
        }

        public void MarkCell(int cellPosition, MarkType mark)
        {
            _cells[cellPosition].Mark=mark;
        }

        public Cell[] Cells
        {
            get { return _cells; }
        }

        public bool IsEmpty()
        {
            for(int i = 0; i < _cells.Length; i++)
            {
                if (_cells[i].IsAlreadyMarked())
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsBoardFull()
        {
            for(int i=0;i< _cells.Length; i++)
            {
                if (!_cells[i].IsAlreadyMarked())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
