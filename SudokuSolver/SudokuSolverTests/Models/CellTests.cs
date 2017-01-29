using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SudokuSolver.Models.Tests
{
    [TestFixture]
    public class CellTests
    {
        #region Constructor

        [TestCase(null)]
        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Cell_Constructor_Entry_Success(int? entry)
        {
            Cell cell = new Cell(entry: entry);

            Assert.AreEqual(entry, cell.Entry);
            Assert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, cell.AvailableOptions);
        }

        [Test]
        public void Cell_Constructor_Options_One_Success()
        {
            var list = new List<int> { 1 };
            Cell cell = new Cell(availableOptions: list);

            Assert.AreEqual(list, cell.AvailableOptions);
            Assert.AreEqual(null, cell.Entry);
        }

        [Test]
        public void Cell_Constructor_Options_All_Success()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Cell cell = new Cell(availableOptions: list);

            Assert.AreEqual(list, cell.AvailableOptions);
            Assert.AreEqual(null, cell.Entry);
        }

        [Test]
        public void Cell_Constructor_Options_Half_Success()
        {
            var list = new List<int> { 1, 2, 8, 9 };
            Cell cell = new Cell(availableOptions: list);

            Assert.AreEqual(list, cell.AvailableOptions);
            Assert.AreEqual(null, cell.Entry);
        }

        [Test]
        public void Cell_Constructor_Options_NULL_Success()
        {
            Cell cell = new Cell(availableOptions: null);

            Assert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, cell.AvailableOptions);
            Assert.AreEqual(null, cell.Entry);
        }

        [Test]
        public void Cell_Constructor_Options_Both_Success()
        {
            Cell cell = new Cell(entry: 5, availableOptions: null);

            Assert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, cell.AvailableOptions);
            Assert.AreEqual(5, cell.Entry);
        }

        #endregion Constructor

        #region Entry

        [TestCase(null)]
        [TestCase(1)]
        [TestCase(9)]
        [TestCase(5)]
        public void Cell_Entry_Success(int? entry)
        {
            Cell cell = new Cell();

            cell.Entry = entry;

            Assert.AreEqual(entry, cell.Entry);
        }

        [TestCase(0, "Entry can not be less than 1")]
        [TestCase(-1, "Entry can not be less than 1")]
        [TestCase(10, "Entry can not be greater than 9")]
        [TestCase(100, "Entry can not be greater than 9")]
        [TestCase(-100, "Entry can not be less than 1")]
        public void Cell_Entry_Fail(int? entry, string errorMessage)
        {
            Cell cell = new Cell();

            var ex = Assert.Throws<ArgumentException>(delegate { cell.Entry = entry; });

            Assert.AreEqual(errorMessage, ex.Message);
        }

        #endregion Entry

        #region Options

        [Test]
        public void Cell_Options_One_Success()
        {
            var list = new List<int> { 1 };
            Cell cell = new Cell();

            cell.AvailableOptions = list;

            Assert.AreEqual(list, cell.AvailableOptions);
        }

        [Test]
        public void Cell_Options_All_Success()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Cell cell = new Cell();

            cell.AvailableOptions = list;

            Assert.AreEqual(list, cell.AvailableOptions);
        }

        [Test]
        public void Cell_Options_Half_Success()
        {
            var list = new List<int> { 1, 2, 7, 8, 9 };
            Cell cell = new Cell();

            cell.AvailableOptions = list;

            Assert.AreEqual(list, cell.AvailableOptions);
        }

        [Test]
        public void Cell_Options_NULL_Fail()
        {
            Cell cell = new Cell();

            var ex = Assert.Throws<ArgumentException>(delegate { cell.AvailableOptions = null; });

            Assert.AreEqual("Available Options can not be null", ex.Message);
        }

        [Test]
        public void Cell_Options_OverFull_Fail()
        {
            Cell cell = new Cell();

            var ex = Assert.Throws<ArgumentException>(delegate { cell.AvailableOptions = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }; });

            Assert.AreEqual("Available Options can not have more than 9 options", ex.Message);
        }

        [Test]
        public void Cell_Options_WrongNumber_Fail()
        {
            Cell cell = new Cell();

            var ex = Assert.Throws<ArgumentException>(delegate { cell.AvailableOptions = new List<int> { 10 }; });

            Assert.AreEqual("Available Options values have to be in the range of 1 to 9", ex.Message);
        }

        #endregion Options

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
        public void Cell_RemoveOption_Success(int option)
        {
            Cell cell = new Cell();

            Assert.AreEqual(9, cell.AvailableOptions.Count);

            cell.RemoveOption(option);

            Assert.AreEqual(8, cell.AvailableOptions.Count);
        }

        #endregion
    }
}