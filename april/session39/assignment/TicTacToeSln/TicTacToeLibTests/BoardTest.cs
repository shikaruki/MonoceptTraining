using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLib.Model;
namespace TicTacToeLibTests
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void Constructor_BoardShouldHave9EmptyCells()
        {
            Board board = new Board();
            Assert.IsTrue(board.Cells.Length == 9);
            for (int i = 0; i < board.Cells.Length; i++)
            {
                Assert.IsTrue(board.Cells[i].Mark == MarkType.Empty);
            }
        }

        [TestMethod]
        public void MarkCell_SpecificCellInBoardMustBeMarkedWithXorO()
        {
            Board board = new Board();
            board.MarkCell(cellPosition: 8, mark: MarkType.X);
            Assert.IsTrue(board.Cells[8].Mark == MarkType.X);
        }

        [TestMethod, ExpectedException(typeof(CellAlreadyMarkedException))]
        public void MarkCell_ShouldThrowExceptionIfSameCellPositionIsMarked()
        {
            Board board = new Board();
            board.MarkCell(cellPosition : 8, mark : MarkType.X);
            board.MarkCell(cellPosition: 8, mark: MarkType.X);
        }

        [TestMethod]
        public void IsBoardFull_ShouldReturnTrueIfBoardIsFull()
        {
            Board board = new Board();
            for(int i =0;i<board.Cells.Length;i++)
            {
                board.MarkCell(cellPosition: i, mark: MarkType.X);
            }
            Assert.IsTrue(board.IsBoardFull());
        }

        [TestMethod]
        public void IsBoardFull_ShouldReturnFalseIfBoardIsFull()
        {
            Board board = new Board();
            for (int i = 0; i < board.Cells.Length-1; i++)
            {
                board.MarkCell(cellPosition: i, mark: MarkType.X);
            }
            Assert.IsFalse(board.IsBoardFull());
        }

    }
}
