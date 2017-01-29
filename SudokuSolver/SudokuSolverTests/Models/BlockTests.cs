using NUnit.Framework;
using SudokuSolver.Models;
using System;
using System.Collections.Generic;

namespace SudokuSolverTests.Models
{
    public class BlockTests
    {
        #region Constructor

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Block_Constructor_Number_Success(int number)
        {
            Block Block = new Block(number);

            Assert.AreEqual(number, Block.Number);
            Assert.AreEqual(new List<Cell>(), Block.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Block_Constructor_Cells_NULLList_Success(int number)
        {
            Block Block = new Block(number, null);

            Assert.AreEqual(number, Block.Number);
            Assert.AreEqual(new List<Cell>(), Block.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Block_Constructor_Cells_EmptyList_Success(int number)
        {
            Block Block = new Block(number, new List<Cell>());

            Assert.AreEqual(number, Block.Number);
            Assert.AreEqual(new List<Cell>(), Block.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Block_Constructor_Cells_OneItemList_Success(int number)
        {
            var list = new List<Cell> { new Cell() };
            Block Block = new Block(number, list);

            Assert.AreEqual(number, Block.Number);
            Assert.AreEqual(list, Block.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Block_Constructor_Cells_HalfList_Success(int number)
        {
            var list = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell() };
            Block Block = new Block(number, list);

            Assert.AreEqual(number, Block.Number);
            Assert.AreEqual(list, Block.Cells);
        }

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Block_Constructor_Cells_FullList_Success(int number)
        {
            var list = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() };
            Block Block = new Block(number, list);

            Assert.AreEqual(number, Block.Number);
            Assert.AreEqual(list, Block.Cells);
        }

        #endregion Constructor

        #region Cells

        [Test]
        public void Block_Cells_EmptyList_Success()
        {
            Block Block = new Block(1);

            var list = new List<Cell>();

            Block.Cells = list;

            Assert.AreEqual(list, Block.Cells);
        }

        [Test]
        public void Block_Cells_OneItemList_Success()
        {
            Block Block = new Block(1);

            var list = new List<Cell> { new Cell() };

            Block.Cells = list;

            Assert.AreEqual(list, Block.Cells);
        }

        [Test]
        public void Block_Cells_HalfList_Success()
        {
            Block Block = new Block(1);

            var list = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell() };

            Block.Cells = list;

            Assert.AreEqual(list, Block.Cells);
        }

        [Test]
        public void Block_Cells_FullList_Success()
        {
            Block Block = new Block(1);

            var list = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() };

            Block.Cells = list;

            Assert.AreEqual(list, Block.Cells);
        }

        [Test]
        public void Block_Cells_NULLList_Failure()
        {
            Block Block = new Block(1);

            var ex = Assert.Throws<ArgumentException>(delegate { Block.Cells = null; });

            Assert.AreEqual("Cells can not be null", ex.Message);
        }

        [Test]
        public void Block_Cells_TooFullList_Failure()
        {
            Block Block = new Block(1);

            var ex = Assert.Throws<ArgumentException>(delegate { Block.Cells = new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() }; });

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
        public void Block_Number_Success(int number)
        {
            Block Block = new Block(1);

            Block.Number = number;

            Assert.AreEqual(number, Block.Number);
        }

        [TestCase(10)]
        [TestCase(100)]
        [TestCase(1000)]
        public void Block_Number_TooHigh_Failure(int number)
        {
            {
                Block Block = new Block(1);

                var ex = Assert.Throws<ArgumentException>(delegate { Block.Number = number; });

                Assert.AreEqual("Number can not be greater than 9", ex.Message);
            }
        }

        [TestCase(0)]
        [TestCase(-10)]
        [TestCase(-100)]
        [TestCase(-1000)]
        public void Block_Number_TooLow_Failure(int number)
        {
            {
                Block Block = new Block(1);

                var ex = Assert.Throws<ArgumentException>(delegate { Block.Number = number; });

                Assert.AreEqual("Number can not be less than 1", ex.Message);
            }
        }

        #endregion Number

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
        public void Block_AddCell_Success(int amount)
        {
            Block Block = new Block(1);

            Assert.AreEqual(0, Block.Cells.Count);

            for (int i = 0; i < amount; i++)
            {
                Block.AddCell(new Cell());
            }

            Assert.AreEqual(amount, Block.Cells.Count);
        }

        #endregion AddCell

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
        public void Block_RemoveOption_Success(int option)
        {
            Block block = new Block(1, new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() });

            block.RemoveOption(option);

            foreach (var cell in block.Cells)
            {
                Assert.That(cell.AvailableOptions, Has.No.Member(option));
                Assert.AreEqual(8, cell.AvailableOptions.Count);
            }
        }

        #endregion RemoveOption

        #region ProcessCells

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        public void Block_ProcessCells_Success(int option)
        {
            Cell cell = new Cell(availableOptions: new List<int> { option });

            Block block = new Block(1, new List<Cell> { cell });

            block.ProcessCells();

            Assert.AreEqual(option, cell.Entry);
            Assert.AreEqual(new List<int>(), cell.AvailableOptions);
        }

        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 4)]
        [TestCase(4, 5)]
        [TestCase(5, 6)]
        [TestCase(6, 7)]
        [TestCase(7, 8)]
        [TestCase(8, 9)]
        [TestCase(9, 1)]
        public void Block_ProcessCells_TwoCells_Success(int option, int option2)
        {
            Cell cell1 = new Cell(availableOptions: new List<int> { 1, 2 });
            Cell cell2 = new Cell(availableOptions: new List<int> { 1 });

            Block block = new Block(1, new List<Cell> { cell1, cell2 });

            block.ProcessCells();

            Assert.AreEqual(1, cell2.Entry);
            Assert.AreEqual(new List<int>(), cell2.AvailableOptions);

            Assert.AreEqual(null, cell1.Entry);
            Assert.AreEqual(new List<int> { 2 }, cell1.AvailableOptions);

            block.ProcessCells();

            Assert.AreEqual(1, cell2.Entry);
            Assert.AreEqual(new List<int>(), cell2.AvailableOptions);

            Assert.AreEqual(2, cell1.Entry);
            Assert.AreEqual(new List<int>(), cell1.AvailableOptions);
        }

        #endregion ProcessCells
    }
}