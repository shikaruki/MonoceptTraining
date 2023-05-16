using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib.Model
{
    public class Game
    {
        private Board _board;
        private ResultAnalyzer _analyzer;
        private Player[] _players;
        private Player _currentPlayer;
        private ResultType _status;

        public Game(Board board, ResultAnalyzer analyzer, Player[] players)
        {
            _board = board;
            _analyzer = analyzer;
            _players = players;
            _currentPlayer = players[0];
        }

        public void Play(int cellPosition)
        {
            _board.MarkCell(cellPosition, _currentPlayer.Mark);
            _status = _analyzer.Analyze();
            if(_currentPlayer == _players[0])
            {
                _currentPlayer = _players[1];
            }
            else
            {
                _currentPlayer = _players[0];
            }
        }
        public ResultType Status
        {
            get { return _status; }
        }

        public Player CurrentPlayer
        {
            get { return _currentPlayer; }
        }
    }
}
