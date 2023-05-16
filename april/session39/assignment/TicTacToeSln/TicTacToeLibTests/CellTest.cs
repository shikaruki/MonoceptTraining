using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLib.Model;

namespace TicTacToeLibTests
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void Constructor_ShouldAbleToMark_X_O()
        {
            Cell cell1 = new Cell(MarkType.X);
            Cell cell2 = new Cell(MarkType.O);

            Assert.AreEqual(MarkType.X, cell1.Mark);
            Assert.AreEqual(MarkType.O, cell2.Mark);
        }

        [TestMethod]
        public void Constructor_ShouldCreateCellWithMarkEmpty()
        {
            Cell cell = new Cell();

            Assert.AreEqual(MarkType.Empty, cell.Mark);
        }

        [TestMethod]
        public void IsAlreadyMarked_CheckIfCellsMarked()
        {
            Cell cell1 = new Cell(MarkType.X);
            Cell cell2 = new Cell();

            Assert.IsTrue(cell1.IsAlreadyMarked());
            Assert.IsFalse(cell2.IsAlreadyMarked());
        }

        [TestMethod]
        [ExpectedException(typeof(CellAlreadyMarkedException))]
        public void ShouldNotAllowToMarkCellMoreThanOnce()
        {
            Cell cell = new Cell();
            cell.Mark = MarkType.X;
            cell.Mark = MarkType.O;
            Assert.IsTrue(cell.Mark == MarkType.X);
        }
    }
}
