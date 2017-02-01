using NUnit.Framework;
using SudokuSolver.Models;
using System;
using System.Collections.Generic;

namespace SudokuSolverTests.Models
{
    [TestFixture]
    class GridTests
    {
        #region Constructor

        [Test]
        public void Grid_Constructor_ColumnRowGrid_Complete_Success()
        {
            var columns = new List<Column> { new Column(1), new Column(2), new Column(3), new Column(4), new Column(5), new Column(6), new Column(7), new Column(8), new Column(9) };
            var rows = new List<Row> { new Row(1), new Row(2), new Row(3), new Row(4), new Row(5), new Row(6), new Row(7), new Row(8), new Row(9) };
            var blocks = new List<Block> { new Block(1), new Block(2), new Block(3), new Block(4), new Block(5), new Block(6), new Block(7), new Block(8), new Block(9) };

            var grid = new Grid(columns, rows, blocks);

            Assert.AreEqual(columns, grid.Columns);
            Assert.AreEqual(rows, grid.Rows);
            Assert.AreEqual(blocks, grid.Blocks);
        }

        #endregion
    }
}
