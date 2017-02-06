using NUnit.Framework;
using SudokuSolver.Helper;
using System;
using System.Collections.Generic;

namespace SudokuSolverTests.Helper
{
    [TestFixture]
    internal class GridHelperTests
    {
        #region Get_Numbers

        [TestCase(82)]
        [TestCase(80)]
        [TestCase(1)]
        [TestCase(100)]
        public void GridHelper_Get_Numbers_Failure(int number)
        {
            var numbers = new List<int>();
            for (int i = 0; i < number; i++)
            {
                numbers.Add(0);
            }

            var ex = Assert.Throws<ArgumentException>(delegate { var row = GridHelper.Get(numbers); });

            Assert.AreEqual("Not the right amount of numbers provided", ex.Message);
        }

        #endregion Get_Numbers
    }
}