﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib.Model
{
    public class ResultAnalyzer
    {
        private Board _board;

        public ResultAnalyzer(Board board)
        {
            _board = board;
        }

        public Board Board { get { return _board; } }   

        public ResultType Analyze()
        {
            
            if(MatchVertically() || MatchHorizontally() || MatchDiagonally())
                return ResultType.Win;
            if (_board.IsBoardFull())
                return ResultType.Draw;

            return ResultType.NoResult;
        }

        private bool MatchDiagonally()
        {
            if(CheckDiagonallyForX()||CheckDiagonallyForO())
                return true;
            return false;
        }

        private bool MatchHorizontally()
        {
            if(CheckHorizontallyForX()||CheckHorizontallyForO()) 
                return true;
            return false;
        }

        private bool MatchVertically()
        {
            if(CheckVerticallyForX() || CheckVerticallyForO() || CheckHorizontallyForX() || CheckHorizontallyForO() || CheckDiagonallyForX() || CheckDiagonallyForO())
                return true;
            return false;
        }

        private bool CheckDiagonallyForO()
        {
            if (_board.Cells[0].Mark == MarkType.O && _board.Cells[4].Mark == MarkType.O && _board.Cells[8].Mark == MarkType.O ||
                _board.Cells[6].Mark == MarkType.O && _board.Cells[4].Mark == MarkType.O && _board.Cells[2].Mark == MarkType.O)
                return true;
            return false;
        }

        private bool CheckDiagonallyForX()
        {
            if (_board.Cells[0].Mark == MarkType.X && _board.Cells[4].Mark == MarkType.X && _board.Cells[8].Mark == MarkType.X ||
                _board.Cells[6].Mark == MarkType.X && _board.Cells[4].Mark == MarkType.X && _board.Cells[2].Mark == MarkType.X)
                return true;
            return false;
        }

        private bool CheckHorizontallyForO()
        {
            if (_board.Cells[0].Mark == MarkType.O && _board.Cells[1].Mark == MarkType.O && _board.Cells[2].Mark == MarkType.O ||
                _board.Cells[3].Mark == MarkType.O && _board.Cells[4].Mark == MarkType.O && _board.Cells[5].Mark == MarkType.O ||
                 _board.Cells[6].Mark == MarkType.O && _board.Cells[7].Mark == MarkType.O && _board.Cells[8].Mark == MarkType.O)
                return true;
            return false;
        }

        private bool CheckHorizontallyForX()
        {
            if (_board.Cells[0].Mark == MarkType.X && _board.Cells[1].Mark == MarkType.X && _board.Cells[2].Mark == MarkType.X ||
               _board.Cells[3].Mark == MarkType.X && _board.Cells[4].Mark == MarkType.X && _board.Cells[5].Mark == MarkType.X ||
                _board.Cells[6].Mark == MarkType.X && _board.Cells[7].Mark == MarkType.X && _board.Cells[8].Mark == MarkType.X)
                return true;
            return false;
        }

        private bool CheckVerticallyForX()
        {
            if (_board.Cells[0].Mark == MarkType.X && _board.Cells[3].Mark == MarkType.X && _board.Cells[6].Mark == MarkType.X)
                return true;

            if (_board.Cells[1].Mark == MarkType.X && _board.Cells[4].Mark == MarkType.X && _board.Cells[7].Mark == MarkType.X)
                return true;

            if (_board.Cells[2].Mark == MarkType.X && _board.Cells[5].Mark == MarkType.X && _board.Cells[8].Mark == MarkType.X)
                return true;
            return false;
        }
        private bool CheckVerticallyForO()
        {
            if (_board.Cells[0].Mark == MarkType.O && _board.Cells[3].Mark == MarkType.O && _board.Cells[6].Mark == MarkType.O)
                return true;

            if (_board.Cells[1].Mark == MarkType.O && _board.Cells[4].Mark == MarkType.O && _board.Cells[7].Mark == MarkType.O)
                return true;

            if (_board.Cells[2].Mark == MarkType.O && _board.Cells[5].Mark == MarkType.O && _board.Cells[8].Mark == MarkType.O)
                return true;

            return false;
        }
    }
}
