using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLib.Model;

namespace TicTacToeLibTests
{
    [TestClass]
    public class ResultAnalyzerTest
    {
        [TestMethod]
        public void Analyze_ShouldResultNoResultForEmptyBoard()
        {
            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            ResultType result =  resultAnalyzer.Analyze();
            Assert.IsTrue(result == ResultType.NoResult);
        }

        [TestMethod]
        public void Analyze_ShouldReturnWin_ForAllVerticallySameCellsWithX()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.X;
            board.Cells[3].Mark = MarkType.X;
            board.Cells[6].Mark = MarkType.X;
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            ResultType result = resultAnalyzer.Analyze();
            Assert.IsTrue(result == ResultType.Win);

        }
        [TestMethod]
        public void Analyze_ShouldReturnWin_ForAllVerticallySameCellsWithO_ForColumn1()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.O;
            board.Cells[3].Mark = MarkType.O;
            board.Cells[6].Mark = MarkType.O;
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            ResultType result = resultAnalyzer.Analyze();
            Assert.IsTrue(result == ResultType.Win);

        }

        [TestMethod]
        public void Analyze_ShouldReturnWin_ForAllVerticallySameCellsWithO_ForColumn2()
        {
            Board board = new Board();
            board.Cells[1].Mark = MarkType.O;
            board.Cells[4].Mark = MarkType.O;
            board.Cells[7].Mark = MarkType.O;
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            ResultType result = resultAnalyzer.Analyze();
            Assert.IsTrue(result == ResultType.Win);

        }
        [TestMethod]
        public void Analyze_ShouldReturnWin_ForAllVerticallySameCellsWithO_ForColumn3()
        {
            Board board = new Board();
            board.Cells[2].Mark = MarkType.O;
            board.Cells[5].Mark = MarkType.O;
            board.Cells[8].Mark = MarkType.O;
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            ResultType result = resultAnalyzer.Analyze();
            Assert.IsTrue(result == ResultType.Win);

        }

        [TestMethod]
        public void Analyze_NoResultCase()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.X;
            board.Cells[1].Mark = MarkType.X;
            board.Cells[2].Mark = MarkType.O;

            board.Cells[3].Mark = MarkType.O;
            board.Cells[4].Mark = MarkType.O;
            board.Cells[5].Mark = MarkType.X;

            board.Cells[6].Mark = MarkType.X;
            board.Cells[7].Mark = MarkType.X;
            //board.Cells[8].Mark = MarkType.O;

            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            ResultType result = resultAnalyzer.Analyze();
            Assert.IsTrue(result == ResultType.NoResult);
        }

        [TestMethod]
        public void Analyze_DrawCase()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.X;
            board.Cells[1].Mark = MarkType.X;
            board.Cells[2].Mark = MarkType.O;

            board.Cells[3].Mark = MarkType.O;
            board.Cells[4].Mark = MarkType.O;
            board.Cells[5].Mark = MarkType.X;

            board.Cells[6].Mark = MarkType.X;
            board.Cells[7].Mark = MarkType.X;
            board.Cells[8].Mark = MarkType.O;

            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            ResultType result = resultAnalyzer.Analyze();
            Assert.IsTrue(result == ResultType.Draw);
        }
    }
}
