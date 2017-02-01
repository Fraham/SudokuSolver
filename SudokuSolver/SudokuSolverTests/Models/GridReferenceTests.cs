using NUnit.Framework;
using SudokuSolver.Models;
using System;

namespace SudokuSolverTests.Models
{
    [TestFixture]
    public class GridReferenceTests
    {
        #region Constructor

        [Test]
        public void GridReference_Constructor_Success()
        {
            var row = 1;
            var column = 2;
            var block = 3;

            var gridReference = new GridReference(row, column, block);

            Assert.AreEqual(row, gridReference.Row);
            Assert.AreEqual(column, gridReference.Column);
            Assert.AreEqual(block, gridReference.Block);
        }

        #endregion Constructor

        #region Row

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        public void GridReference_Row_Success(int newRow)
        {
            var row = 1;
            var column = 2;
            var block = 3;

            var gridReference = new GridReference(row, column, block);

            gridReference.Row = newRow;

            Assert.AreEqual(newRow, gridReference.Row);
            Assert.AreEqual(column, gridReference.Column);
            Assert.AreEqual(block, gridReference.Block);
        }

        [TestCase(0)]
        [TestCase(-9)]
        public void GridReference_Row_TooLow_Failure(int newRow)
        {
            var row = 1;
            var column = 2;
            var block = 3;

            var gridReference = new GridReference(row, column, block);

            var ex = Assert.Throws<ArgumentException>(delegate { gridReference.Row = newRow; });

            Assert.AreEqual("Row value can not be below 1", ex.Message);

            Assert.AreEqual(row, gridReference.Row);
            Assert.AreEqual(column, gridReference.Column);
            Assert.AreEqual(block, gridReference.Block);
        }

        [TestCase(100)]
        [TestCase(10)]
        public void GridReference_Row_TooHigh_Failure(int newRow)
        {
            var row = 1;
            var column = 2;
            var block = 3;

            var gridReference = new GridReference(row, column, block);

            var ex = Assert.Throws<ArgumentException>(delegate { gridReference.Row = newRow; });

            Assert.AreEqual("Row value can not be greater than 9", ex.Message);

            Assert.AreEqual(row, gridReference.Row);
            Assert.AreEqual(column, gridReference.Column);
            Assert.AreEqual(block, gridReference.Block);
        }

        #endregion Row

        #region Column

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        public void GridReference_Column_Success(int newColumn)
        {
            var row = 1;
            var column = 2;
            var block = 3;

            var gridReference = new GridReference(row, column, block);

            gridReference.Column = newColumn;

            Assert.AreEqual(row, gridReference.Row);
            Assert.AreEqual(newColumn, gridReference.Column);
            Assert.AreEqual(block, gridReference.Block);
        }

        [TestCase(0)]
        [TestCase(-9)]
        public void GridReference_Column_TooLow_Failure(int newColumn)
        {
            var row = 1;
            var column = 2;
            var block = 3;

            var gridReference = new GridReference(row, column, block);

            var ex = Assert.Throws<ArgumentException>(delegate { gridReference.Column = newColumn; });

            Assert.AreEqual("Column value can not be below 1", ex.Message);

            Assert.AreEqual(row, gridReference.Row);
            Assert.AreEqual(column, gridReference.Column);
            Assert.AreEqual(block, gridReference.Block);
        }

        [TestCase(100)]
        [TestCase(10)]
        public void GridReference_Column_TooHigh_Failure(int newColumn)
        {
            var row = 1;
            var column = 2;
            var block = 3;

            var gridReference = new GridReference(row, column, block);

            var ex = Assert.Throws<ArgumentException>(delegate { gridReference.Column = newColumn; });

            Assert.AreEqual("Column value can not be greater than 9", ex.Message);

            Assert.AreEqual(row, gridReference.Row);
            Assert.AreEqual(column, gridReference.Column);
            Assert.AreEqual(block, gridReference.Block);
        }

        #endregion Column

        #region Block

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        public void GridReference_Block_Success(int newBlock)
        {
            var row = 1;
            var column = 2;
            var block = 3;

            var gridReference = new GridReference(row, column, block);

            gridReference.Block = newBlock;

            Assert.AreEqual(row, gridReference.Row);
            Assert.AreEqual(column, gridReference.Column);
            Assert.AreEqual(newBlock, gridReference.Block);
        }

        [TestCase(0)]
        [TestCase(-9)]
        public void GridReference_Block_TooLow_Failure(int newBlock)
        {
            var row = 1;
            var column = 2;
            var block = 3;

            var gridReference = new GridReference(row, column, block);

            var ex = Assert.Throws<ArgumentException>(delegate { gridReference.Block = newBlock; });

            Assert.AreEqual("Block value can not be below 1", ex.Message);

            Assert.AreEqual(row, gridReference.Row);
            Assert.AreEqual(column, gridReference.Column);
            Assert.AreEqual(block, gridReference.Block);
        }

        [TestCase(100)]
        [TestCase(10)]
        public void GridReference_Block_TooHigh_Failure(int newBlock)
        {
            var row = 1;
            var column = 2;
            var block = 3;

            var gridReference = new GridReference(row, column, block);

            var ex = Assert.Throws<ArgumentException>(delegate { gridReference.Block = newBlock; });

            Assert.AreEqual("Block value can not be greater than 9", ex.Message);

            Assert.AreEqual(row, gridReference.Row);
            Assert.AreEqual(column, gridReference.Column);
            Assert.AreEqual(block, gridReference.Block);
        }

        #endregion Block
    }
}