using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using csv = SudokuSolver.Repositories.Input.CSV;

namespace SudokuSolverTests.Repositories.Input.CSV
{
    [TestFixture]
    public class ReaderTests
    {
        int[] csv1Numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] csv2Numbers = { 0, 0, 0, 0, 0, 0, 9, 0, 0, 0, 9, 0, 5, 0, 0, 2, 0, 1, 0, 2, 1, 0, 7, 6, 0, 0, 0, 1, 5, 0, 4, 0, 0, 0, 0, 0, 0, 6, 0, 0, 9, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 4, 5, 0, 0, 0, 1, 2, 0, 3, 8, 0, 6, 0, 7, 0, 0, 8, 0, 9, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0 };


        [Test]
        public void ReaderCSV_GetGrid_CSV1_Success()
        {
            var reader = new csv.Reader();
            var gridNumbers = reader.GetGrid("csv1.csv");

            Assert.IsNotNull(gridNumbers);
            Assert.IsNotEmpty(gridNumbers);
            Assert.AreEqual(10, gridNumbers.Length);
            Assert.AreEqual(csv1Numbers, gridNumbers);
        }

        [Test]
        public void ReaderCSV_GetGrid_CSV2_Success()
        {
            var reader = new csv.Reader();
            var gridNumbers = reader.GetGrid("csv2.csv");

            Assert.IsNotNull(gridNumbers);
            Assert.IsNotEmpty(gridNumbers);
            Assert.AreEqual(81, gridNumbers.Length);
            Assert.AreEqual(csv2Numbers, gridNumbers);
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        [TestCase("csv1")]
        [TestCase("csv2")]
        [TestCase("csv1.html")]
        [TestCase("csv1.css")]
        public void ReaderCSV_GetGrid_InvalidFileName_Failure(string fileName)
        {
            var reader = new csv.Reader();
            var ex = Assert.Throws<ArgumentException>(delegate { reader.GetGrid(fileName); });

            Assert.AreEqual("File name should end with .csv", ex.Message);
        }
    }
}
