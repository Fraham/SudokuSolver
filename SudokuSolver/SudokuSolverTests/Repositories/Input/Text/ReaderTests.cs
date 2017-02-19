using System;
using NUnit.Framework;
using txt = SudokuSolver.Repositories.Input.Text;

namespace SudokuSolverTests.Repositories.Input.Text
{
    [TestFixture]
    public class ReaderTests
    {
        int[] txt1Numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] txt2Numbers = { 0, 0, 0, 0, 0, 0, 9, 0, 0, 0, 9, 0, 5, 0, 0, 2, 0, 1, 0, 2, 1, 0, 7, 6, 0, 0, 0, 1, 5, 0, 4, 0, 0, 0, 0, 0, 0, 6, 0, 0, 9, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 4, 5, 0, 0, 0, 1, 2, 0, 3, 8, 0, 6, 0, 7, 0, 0, 8, 0, 9, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0 };


        [Test]
        public void ReaderTXT_GetGrid_TXT1_Success()
        {
            var reader = new txt.Reader();
            var gridNumbers = reader.GetGrid("txt1.txt");

            Assert.IsNotNull(gridNumbers);
            Assert.IsNotEmpty(gridNumbers);
            Assert.AreEqual(10, gridNumbers.Length);
            Assert.AreEqual(txt1Numbers, gridNumbers);
        }

        [Test]
        public void ReaderTXT_GetGrid_TXT2_Success()
        {
            var reader = new txt.Reader();
            var gridNumbers = reader.GetGrid("txt2.txt");

            Assert.IsNotNull(gridNumbers);
            Assert.IsNotEmpty(gridNumbers);
            Assert.AreEqual(81, gridNumbers.Length);
            Assert.AreEqual(txt2Numbers, gridNumbers);
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        [TestCase("txt1")]
        [TestCase("txt2")]
        [TestCase("txt1.html")]
        [TestCase("txt1.css")]
        public void ReaderTXT_GetGrid_InvalidFileName_Failure(string fileName)
        {
            var reader = new txt.Reader();
            var ex = Assert.Throws<ArgumentException>(delegate { reader.GetGrid(fileName); });

            Assert.AreEqual("File name should end with .txt", ex.Message);
        }
    }
}
