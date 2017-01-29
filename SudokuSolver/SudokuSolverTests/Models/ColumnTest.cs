using NUnit.Framework;
using SudokuSolver.Models;
using System;
using System.Collections.Generic;

namespace SudokuSolverTests.Models
{
    public class ColumnTests
    {
        #region Constructor

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Column_Constructor_Number_Success(int number)
        {
            Column Column = new Column(number);

            Assert.AreEqual(number, Column.Number);
            Assert.AreEqual(new List<Cell>(), Column.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Column_Constructor_Cells_NULLList_Success(int number)
        {
            Column Column = new Column(number, null);

            Assert.AreEqual(number, Column.Number);
            Assert.AreEqual(new List<Cell>(), Column.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Column_Constructor_Cells_EmptyList_Success(int number)
        {
            Column Column = new Column(number, new List<Cell>());

            Assert.AreEqual(number, Column.Number);
            Assert.AreEqual(new List<Cell>(), Column.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Column_Constructor_Cells_OneItemList_Success(int number)
        {
            var list = new List<Cell> { new Cell() };
            Column Column = new Column(number, list);

            Assert.AreEqual(number, Column.Number);
            Assert.AreEqual(list, Column.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Column_Constructor_Cells_HalfList_Success(int number)
        {
            var list = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell() };
            Column Column = new Column(number, list);

            Assert.AreEqual(number, Column.Number);
            Assert.AreEqual(list, Column.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Column_Constructor_Cells_FullList_Success(int number)
        {
            var list = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() };
            Column Column = new Column(number, list);

            Assert.AreEqual(number, Column.Number);
            Assert.AreEqual(list, Column.Cells);
        }

        #endregion Constructor

        #region Cells

        [Test]
        public void Column_Cells_EmptyList_Success()
        {
            Column Column = new Column(1);

            var list = new List<Cell>();

            Column.Cells = list;

            Assert.AreEqual(list, Column.Cells);
        }

        [Test]
        public void Column_Cells_OneItemList_Success()
        {
            Column Column = new Column(1);

            var list = new List<Cell> { new Cell() };

            Column.Cells = list;

            Assert.AreEqual(list, Column.Cells);
        }

        [Test]
        public void Column_Cells_HalfList_Success()
        {
            Column Column = new Column(1);

            var list = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell() };

            Column.Cells = list;

            Assert.AreEqual(list, Column.Cells);
        }

        [Test]
        public void Column_Cells_FullList_Success()
        {
            Column Column = new Column(1);

            var list = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() };

            Column.Cells = list;

            Assert.AreEqual(list, Column.Cells);
        }

        [Test]
        public void Column_Cells_NULLList_Failure()
        {
            Column Column = new Column(1);

            var ex = Assert.Throws<ArgumentException>(delegate { Column.Cells = null; });

            Assert.AreEqual("Cells can not be null", ex.Message);
        }

        [Test]
        public void Column_Cells_TooFullList_Failure()
        {
            Column Column = new Column(1);

            var ex = Assert.Throws<ArgumentException>(delegate { Column.Cells = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() }; });

            Assert.AreEqual("Can not have more than 9 cells", ex.Message);
        }

        #endregion Cells

        #region Number

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]        
        public void Column_Number_Success(int number)
        {
            Column Column = new Column(1);

            Column.Number = number;

            Assert.AreEqual(number, Column.Number);
        }

        [TestCase(10)]
        [TestCase(100)]
        [TestCase(1000)]
        public void Column_Number_TooHigh_Failure(int number)
        {
            {
                Column Column = new Column(1);

                var ex = Assert.Throws<ArgumentException>(delegate { Column.Number = number; });

                Assert.AreEqual("Number can not be greater than 9", ex.Message);
            }
        }

        [TestCase(0)]
        [TestCase(-10)]
        [TestCase(-100)]
        [TestCase(-1000)]
        public void Column_Number_TooLow_Failure(int number)
        {
            {
                Column Column = new Column(1);

                var ex = Assert.Throws<ArgumentException>(delegate { Column.Number = number; });

                Assert.AreEqual("Number can not be less than 1", ex.Message);
            }
        }

        #endregion

        #region AddCell

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        public void Column_AddCell_Success(int amount)
        {
            Column Column = new Column(1);

            Assert.AreEqual(0, Column.Cells.Count);

            for (int i = 0; i < amount; i++)
            {
                Column.AddCell(new Cell());
            }

            Assert.AreEqual(amount, Column.Cells.Count);
        }

        #endregion

        #region RemoveOption

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        public void Column_RemoveOption_Success(int option)
        {
            Column column = new Column(1, new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() });

            column.RemoveOption(option);

            foreach (var cell in column.Cells)
            {
                Assert.That(cell.AvailableOptions, Has.No.Member(option));
            }
        }

        #endregion RemoveOption

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        public void Column_ProcessCells_Success(int option)
        {
            Cell cell = new Cell(availableOptions: new List<int> { option });

            Column column = new Column(1, new List<Cell> { cell });

            column.ProcessCells();

            Assert.AreEqual(option, cell.Entry);
            Assert.AreEqual(new List<int>(), cell.AvailableOptions);
        }
    }
}