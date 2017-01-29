using NUnit.Framework;
using SudokuSolver.Models;
using System;
using System.Collections.Generic;

namespace SudokuSolverTests.Models
{
    public class RowTests
    {
        #region Constructor

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Row_Constructor_Number_Success(int number)
        {
            Row row = new Row(number);

            Assert.AreEqual(number, row.Number);
            Assert.AreEqual(new List<Cell>(), row.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Row_Constructor_Cells_NULLList_Success(int number)
        {
            Row row = new Row(number, null);

            Assert.AreEqual(number, row.Number);
            Assert.AreEqual(new List<Cell>(), row.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Row_Constructor_Cells_EmptyList_Success(int number)
        {
            Row row = new Row(number, new List<Cell>());

            Assert.AreEqual(number, row.Number);
            Assert.AreEqual(new List<Cell>(), row.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Row_Constructor_Cells_OneItemList_Success(int number)
        {
            var list = new List<Cell> { new Cell() };
            Row row = new Row(number, list);

            Assert.AreEqual(number, row.Number);
            Assert.AreEqual(list, row.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Row_Constructor_Cells_HalfList_Success(int number)
        {
            var list = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell() };
            Row row = new Row(number, list);

            Assert.AreEqual(number, row.Number);
            Assert.AreEqual(list, row.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Row_Constructor_Cells_FullList_Success(int number)
        {
            var list = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() };
            Row row = new Row(number, list);

            Assert.AreEqual(number, row.Number);
            Assert.AreEqual(list, row.Cells);
        }

        #endregion Constructor

        #region Cells

        [Test]
        public void Row_Cells_EmptyList_Success()
        {
            Row row = new Row(1);

            var list = new List<Cell>();

            row.Cells = list;

            Assert.AreEqual(list, row.Cells);
        }

        [Test]
        public void Row_Cells_OneItemList_Success()
        {
            Row row = new Row(1);

            var list = new List<Cell> { new Cell() };

            row.Cells = list;

            Assert.AreEqual(list, row.Cells);
        }

        [Test]
        public void Row_Cells_HalfList_Success()
        {
            Row row = new Row(1);

            var list = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell() };

            row.Cells = list;

            Assert.AreEqual(list, row.Cells);
        }

        [Test]
        public void Row_Cells_FullList_Success()
        {
            Row row = new Row(1);

            var list = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() };

            row.Cells = list;

            Assert.AreEqual(list, row.Cells);
        }

        [Test]
        public void Row_Cells_NULLList_Failure()
        {
            Row row = new Row(1);

            var ex = Assert.Throws<ArgumentException>(delegate { row.Cells = null; });

            Assert.AreEqual("Cells can not be null", ex.Message);
        }

        [Test]
        public void Row_Cells_TooFullList_Failure()
        {
            Row row = new Row(1);

            var ex = Assert.Throws<ArgumentException>(delegate { row.Cells = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() }; });

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
        public void Row_Number_Success(int number)
        {
            Row row = new Row(1);

            row.Number = number;

            Assert.AreEqual(number, row.Number);
        }

        [TestCase(10)]
        [TestCase(100)]
        [TestCase(1000)]
        public void Row_Number_TooHigh_Failure(int number)
        {
            {
                Row row = new Row(1);

                var ex = Assert.Throws<ArgumentException>(delegate { row.Number = number; });

                Assert.AreEqual("Number can not be greater than 9", ex.Message);
            }
        }

        [TestCase(0)]
        [TestCase(-10)]
        [TestCase(-100)]
        [TestCase(-1000)]
        public void Row_Number_TooLow_Failure(int number)
        {
            {
                Row row = new Row(1);

                var ex = Assert.Throws<ArgumentException>(delegate { row.Number = number; });

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
        public void Row_AddCell_Success(int amount)
        {
            Row row = new Row(1);

            Assert.AreEqual(0, row.Cells.Count);

            for (int i = 0; i < amount; i++)
            {
                row.AddCell(new Cell());
            }

            Assert.AreEqual(amount, row.Cells.Count);
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
        public void Row_RemoveOption_Success(int option)
        {
            Row row = new Row(1, new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() });

            row.RemoveOption(option);

            foreach (var cell in row.Cells)
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
        public void Row_ProcessCells_Success(int option)
        {
            Cell cell = new Cell(availableOptions: new List<int> { option });

            Row row = new Row(1, new List<Cell> { cell });

            row.ProcessCells();

            Assert.AreEqual(option, cell.Entry);
            Assert.AreEqual(new List<int>(), cell.AvailableOptions);
        }
    }
}