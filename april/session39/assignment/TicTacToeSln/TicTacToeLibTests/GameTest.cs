using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLib.Model;

namespace TicTacToeLibTests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void Constructor_WhenGameIsCreated_CurrentPlayerShouldBePlayer0()
        {
            Player p1 = new Player { Mark = MarkType.X, Name = "Player1" };
            Player p2 = new Player { Mark = MarkType.O, Name = "Player2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board, analyzer, players);

            Assert.AreEqual(players[0], game.CurrentPlayer);
        }

        [TestMethod]
        public void Constructor_WhenGameIsCreated_StatusWillBeNoResult()
        {
            Player p1 = new Player { Mark = MarkType.X, Name = "Player1" };
            Player p2 = new Player { Mark = MarkType.O, Name = "Player2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board, analyzer, players);

            Assert.IsTrue(game.Status == ResultType.NoResult);
        }

        [TestMethod]
        public void Play_WhenPlayIsCalledOnceCurrentPlayerShouldChangeToPlayer1()
        {
            Player p1 = new Player { Mark = MarkType.X, Name = "Player1" };
            Player p2 = new Player { Mark = MarkType.O, Name = "Player2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board, analyzer, players);
            game.Play(cellPosition: 0);

            Assert.AreEqual(game.CurrentPlayer, players[1]);
        }

        [TestMethod]
        public void Play_WhenPlayIsCalledTwiceCurrentPlayerShouldChangeToPlayer0()
        {
            Player p1 = new Player { Mark = MarkType.X, Name = "Player1" };
            Player p2 = new Player { Mark = MarkType.O, Name = "Player2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board, analyzer, players);
            game.Play(cellPosition: 0);
            game.Play(cellPosition: 5);


            Assert.AreEqual(game.CurrentPlayer, players[0]);
        }

        [TestMethod]
        public void Play_AfterPlayCheckBoardIsUpdated()
        {
            Player p1 = new Player { Mark = MarkType.X, Name = "Player1" };
            Player p2 = new Player { Mark = MarkType.O, Name = "Player2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game=new Game(board,analyzer,players);
            MarkType currentPlayerMark = game.CurrentPlayer.Mark;
            game.Play(cellPosition: 7);

            Assert.IsTrue(board.Cells[7].Mark == currentPlayerMark);
        }
    }
}
