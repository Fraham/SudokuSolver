using NUnit.Framework;
using SudokuSolver.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolverTests.Models
{
    [TestFixture]
    internal class GridTests
    {
        #region Constructor

        [Test]
        public void Grid_Constructor_ColumnRowGrid_Success()
        {
            var columns = new List<Column> { new Column(1), new Column(2), new Column(3), new Column(4), new Column(5), new Column(6), new Column(7), new Column(8), new Column(9) };
            var rows = new List<Row> { new Row(1), new Row(2), new Row(3), new Row(4), new Row(5), new Row(6), new Row(7), new Row(8), new Row(9) };
            var blocks = new List<Block> { new Block(1), new Block(2), new Block(3), new Block(4), new Block(5), new Block(6), new Block(7), new Block(8), new Block(9) };

            var grid = new Grid(columns, rows, blocks);

            Assert.AreEqual(columns, grid.Columns);
            Assert.AreEqual(rows, grid.Rows);
            Assert.AreEqual(blocks, grid.Blocks);
        }

        [Test]
        public void Grid_Constructor_Cells_Success()
        {
            var cells = new List<Cell>();

            for (int i = 0; i < 81; i++)
            {
                cells.Add(new Cell());
            }

            var grid = new Grid(cells);

            Assert.AreEqual(9, grid.Columns.Count);
            Assert.AreEqual(9, grid.Rows.Count);
            Assert.AreEqual(9, grid.Blocks.Count);

            foreach (var column in grid.Columns)
            {
                Assert.AreEqual(9, column.Cells.Count);

                foreach (var cell in column.Cells)
                {
                    Assert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, cell.AvailableOptions);
                    Assert.IsNull(cell.Entry);
                }
            }

            foreach (var row in grid.Rows)
            {
                Assert.AreEqual(9, row.Cells.Count);

                foreach (var cell in row.Cells)
                {
                    Assert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, cell.AvailableOptions);
                    Assert.IsNull(cell.Entry);
                }
            }

            foreach (var block in grid.Blocks)
            {
                Assert.AreEqual(9, block.Cells.Count);

                foreach (var cell in block.Cells)
                {
                    Assert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, cell.AvailableOptions);
                    Assert.IsNull(cell.Entry);
                }
            }
        }

        [TestCase(82)]
        [TestCase(80)]
        [TestCase(1)]
        [TestCase(100)]
        public void Grid_Constructor_Cells_Failure(int amount)
        {
            var cells = new List<Cell>();

            for (int i = 0; i < amount; i++)
            {
                cells.Add(new Cell());
            }

            var ex = Assert.Throws<ArgumentException>(delegate { var grid = new Grid(cells); });

            Assert.AreEqual("Wrong amount of cells for grid", ex.Message);
        }

        #endregion Constructor

        #region ReduceCells

        [Test]
        public void Grid_ReduceCells_Success()
        {
            var cells = new List<Cell>();

            for (int i = 0; i < 81; i++)
            {
                if (i == 0)
                {
                    cells.Add(new Cell(1, new List<int>()));
                }
                else
                {
                    cells.Add(new Cell(availableOptions: new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
                }
            }

            var grid = new Grid(cells);

            var column = grid.Columns.First(b => b.Number == 1);

            Assert.AreEqual(9, column.Cells.Count);

            foreach (var cell in column.Cells)
            {
                if (cell.Entry != null)
                {
                    Assert.AreEqual(new List<int> { }, cell.AvailableOptions);
                }
                else
                {
                    Assert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, cell.AvailableOptions);
                }
            }

            var row = grid.Rows.First(b => b.Number == 1);

            foreach (var cell in row.Cells)
            {
                if (cell.Entry != null)
                {
                    Assert.AreEqual(new List<int> { }, cell.AvailableOptions);
                }
                else
                {
                    Assert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, cell.AvailableOptions);
                }
            }

            var block = grid.Blocks.First(b => b.Number == 1);

            foreach (var cell in block.Cells)
            {
                if (cell.Entry != null)
                {
                    Assert.AreEqual(new List<int> { }, cell.AvailableOptions);
                }
                else
                {
                    Assert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, cell.AvailableOptions);
                }
            }

            grid.ReduceCells();

            column = grid.Columns.First(b => b.Number == 1);

            foreach (var cell in column.Cells)
            {
                if (cell.Entry != null)
                {
                    Assert.AreEqual(new List<int> { }, cell.AvailableOptions);
                }
                else
                {
                    Assert.AreEqual(new List<int> { 2, 3, 4, 5, 6, 7, 8, 9 }, cell.AvailableOptions);
                }
            }

            row = grid.Rows.First(b => b.Number == 1);

            foreach (var cell in row.Cells)
            {
                if (cell.Entry != null)
                {
                    Assert.AreEqual(new List<int> { }, cell.AvailableOptions);
                }
                else
                {
                    Assert.AreEqual(new List<int> { 2, 3, 4, 5, 6, 7, 8, 9 }, cell.AvailableOptions);
                }
            }

            block = grid.Blocks.First(b => b.Number == 1);

            foreach (var cell in block.Cells)
            {
                if (cell.Entry != null)
                {
                    Assert.AreEqual(new List<int> { }, cell.AvailableOptions);
                }
                else
                {
                    Assert.AreEqual(new List<int> { 2, 3, 4, 5, 6, 7, 8, 9 }, cell.AvailableOptions);
                }
            }
        }

        #endregion ReduceCells

        #region CompleteAll

        [Test]
        public void Grid_CompleteAll_Success()
        {
            int[] numbers = new int[] { 0, 0, 0, 0, 0, 0, 9, 0, 0, 0, 9, 0, 5, 0, 0, 2, 0, 1, 0, 2, 1, 0, 7, 6, 0, 0, 0, 1, 5, 0, 4, 0, 0, 0, 0, 0, 0, 6, 0, 0, 9, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 4, 5, 0, 0, 0, 1, 2, 0, 3, 8, 0, 6, 0, 7, 0, 0, 8, 0, 9, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0 };

            var cells = new List<Cell>();

            foreach (var number in numbers)
            {
                if (number != 0)
                {
                    cells.Add(new Cell(number, new List<int>()));
                }
                else
                {
                    cells.Add(new Cell(availableOptions: new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
                }
            }

            var grid = new Grid(cells);

            var finalString = "| 3 | 7 | 5 | 8 | 1 | 2 | 9 | 6 | 4 |\r\n| 8 | 9 | 6 | 5 | 3 | 4 | 2 | 7 | 1 |\r\n| 4 | 2 | 1 | 9 | 7 | 6 | 5 | 3 | 8 |\r\n| 1 | 5 | 8 | 4 | 6 | 3 | 7 | 2 | 9 |\r\n| 7 | 6 | 4 | 2 | 9 | 5 | 8 | 1 | 3 |\r\n| 9 | 3 | 2 | 7 | 8 | 1 | 6 | 4 | 5 |\r\n| 5 | 4 | 9 | 1 | 2 | 7 | 3 | 8 | 6 |\r\n| 6 | 1 | 7 | 3 | 5 | 8 | 4 | 9 | 2 |\r\n| 2 | 8 | 3 | 6 | 4 | 9 | 1 | 5 | 7 |\r\n";

            Assert.AreEqual(finalString, grid.CompleteGrid());
        }

        #endregion CompleteAll

        #region ProcessCells

        [Test]
        public void Grid_ProcessCells_Success()
        {
            int[] numbers = new int[] { 0, 0, 0, 0, 0, 0, 9, 0, 0, 0, 9, 0, 5, 0, 0, 2, 0, 1, 0, 2, 1, 0, 7, 6, 0, 0, 0, 1, 5, 0, 4, 0, 0, 0, 0, 0, 0, 6, 0, 0, 9, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 4, 5, 0, 0, 0, 1, 2, 0, 3, 8, 0, 6, 0, 7, 0, 0, 8, 0, 9, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0 };

            var cells = new List<Cell>();

            foreach (var number in numbers)
            {
                if (number != 0)
                {
                    cells.Add(new Cell(number, new List<int>()));
                }
                else
                {
                    cells.Add(new Cell(availableOptions: new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
                }
            }

            var grid = new Grid(cells);

            var finalString = "|   |   |   |   |   |   | 9 |   |   |\r\n|   | 9 |   | 5 |   |   | 2 |   | 1 |\r\n|   | 2 | 1 |   | 7 | 6 |   |   |   |\r\n| 1 | 5 |   | 4 |   |   |   |   |   |\r\n|   | 6 |   |   | 9 |   |   | 1 |   |\r\n|   |   |   |   |   | 1 |   | 4 | 5 |\r\n|   | 4 |   | 1 | 2 |   | 3 | 8 |   |\r\n| 6 | 1 | 7 | 3 |   | 8 |   | 9 |   |\r\n|   | 8 | 3 |   |   |   |   |   |   |\r\n";

            Assert.AreEqual(finalString, grid.ProcessCells());
        }

        #endregion
    }
}