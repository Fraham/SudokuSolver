using NUnit.Framework;
using System;
using SudokuSolver.Helper;

namespace SudokuSolverTests.Helper
{
    [TestFixture]
    class CellFinderTests
    {
        #region GetGridReference

        [Test]
        public void CellFinder_GetGridReference_Success()
        {
            var row = 1;
            var column = 1;
            var block = 1;

            var gridReference = CellFinder.GetGridReference(0);

            Assert.AreEqual(row, gridReference.Row);
            Assert.AreEqual(column, gridReference.Column);
            Assert.AreEqual(block, gridReference.Block);
        }

        #endregion

        #region GetRowNumber

        [TestCase(0, 1)]
        [TestCase(10, 2)]
        [TestCase(20, 3)]
        [TestCase(30, 4)]
        [TestCase(40, 5)]
        [TestCase(50, 6)]
        [TestCase(60, 7)]
        [TestCase(70, 8)]
        [TestCase(80, 9)]
        public void CellFinder_GetRowNumber_Success(int index, int row)
        {
            Assert.AreEqual(row, CellFinder.GetRowNumber(index));
        }

        [TestCase(-1)]
        [TestCase(-9)]
        public void CellFinder_GetRowNumber_TooLow_Failure(int index)
        {
            var ex = Assert.Throws<ArgumentException>(delegate { var row = CellFinder.GetRowNumber(index); });

            Assert.AreEqual("Index is too small", ex.Message);
        }

        [TestCase(100)]
        [TestCase(82)]
        public void CellFinder_GetRowNumber_TooHigh_Failure(int index)
        {
            var ex = Assert.Throws<ArgumentException>(delegate { var row = CellFinder.GetRowNumber(index); });

            Assert.AreEqual("Index is too high", ex.Message);
        }

        #endregion

        #region GetColumnNumber

        [TestCase(72, 1)]
        [TestCase(55, 2)]
        [TestCase(11, 3)]
        [TestCase(21, 4)]
        [TestCase(67, 5)]
        [TestCase(68, 6)]
        [TestCase(33, 7)]
        [TestCase(43, 8)]
        [TestCase(8, 9)]
        public void CellFinder_GetColumnNumber_Success(int index, int column)
        {
            Assert.AreEqual(column, CellFinder.GetColumnNumber(index));
        }

        [TestCase(-1)]
        [TestCase(-9)]
        public void CellFinder_GetColumnNumber_TooLow_Failure(int index)
        {
            var ex = Assert.Throws<ArgumentException>(delegate { var row = CellFinder.GetColumnNumber(index); });

            Assert.AreEqual("Index is too small", ex.Message);
        }

        [TestCase(100)]
        [TestCase(82)]
        public void CellFinder_GetColumnNumber_TooHigh_Failure(int index)
        {
            var ex = Assert.Throws<ArgumentException>(delegate { var row = CellFinder.GetColumnNumber(index); });

            Assert.AreEqual("Index is too high", ex.Message);
        }

        #endregion

        #region GetBlockNumber

        [TestCase(19, 1)]
        [TestCase(13, 2)]
        [TestCase(25, 3)]
        [TestCase(36, 4)]
        [TestCase(40, 5)]
        [TestCase(44, 6)]
        [TestCase(72, 7)]
        [TestCase(59, 8)]
        [TestCase(71, 9)]
        public void CellFinder_GetBlockNumber_Index_Success(int index, int block)
        {
            Assert.AreEqual(block, CellFinder.GetBlockNumber(index));
        }

        [TestCase(-1)]
        [TestCase(-9)]
        public void CellFinder_GetBlockNumber_Index_TooLow_Failure(int index)
        {
            var ex = Assert.Throws<ArgumentException>(delegate { var row = CellFinder.GetBlockNumber(index); });

            Assert.AreEqual("Index is too small", ex.Message);
        }

        [TestCase(100)]
        [TestCase(82)]
        public void CellFinder_GetBlockNumber_Index_TooHigh_Failure(int index)
        {
            var ex = Assert.Throws<ArgumentException>(delegate { var row = CellFinder.GetBlockNumber(index); });

            Assert.AreEqual("Index is too high", ex.Message);
        }

        #endregion
    }
}
