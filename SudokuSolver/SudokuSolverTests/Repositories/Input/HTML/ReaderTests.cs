using System;
using NUnit.Framework;
using html = SudokuSolver.Repositories.Input.HTML;

namespace SudokuSolverTests.Repositories.Input.HTML
{
    [TestFixture]
    public class ReaderTests
    {
        int[] webSudoku1 = new int[] { 0, 0, 0, 0, 0, 6, 4, 0, 0, 6, 0, 0, 0, 0, 1, 7, 3, 0, 8, 0, 2, 0, 9, 0, 0, 0, 0, 4, 5, 0, 0, 0, 0, 0, 0, 0, 0, 8, 9, 0, 4, 0, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 7, 4, 0, 0, 0, 0, 3, 0, 6, 0, 1, 0, 4, 5, 9, 0, 0, 0, 0, 3, 0, 0, 6, 1, 0, 0, 0, 0, 0 };

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ReaderHTML_GetGrid_InvalidFileName_Failure(string fileName)
        {
            var reader = new html.Reader();
            var ex = Assert.Throws<ArgumentException>(delegate { reader.GetGrid(fileName); });

            Assert.AreEqual("URL is not valid", ex.Message);
        }

        [Test]
        [TestCase("cheese")]
        [TestCase("..")]
        [TestCase(".hello.")]
        public void ReaderHTML_GetGrid_InvalidURL_Failure(string fileName)
        {
            var reader = new html.Reader();
            var ex = Assert.Throws<UriFormatException>(delegate { reader.GetGrid(fileName); });

            Assert.AreEqual("Invalid URI: The format of the URI could not be determined.", ex.Message);
        }

        [Test]
        [TestCase("http://google.com")]
        [TestCase("http://facebook.com")]
        [TestCase("http://bbc.co.uk")]
        public void ReaderHTML_GetGrid_URLNotFound_Failure(string fileName)
        {
            var reader = new html.Reader();
            var ex = Assert.Throws<ArgumentException>(delegate { reader.GetGrid(fileName); });

            Assert.AreEqual($"{fileName} is not supported", ex.Message);
        }

        [Test]
        [TestCase("http://show.websudoku.com/?level=3")]
        public void ReaderHTML_GetGrid_WebSudoku_Success(string fileName)
        {
            var reader = new html.Reader();
            var numbers = reader.GetGrid(fileName);

            Assert.NotNull(numbers);
            Assert.AreEqual(81, numbers.Length);
            Assert.AreEqual(webSudoku1, numbers);
        }
    }
}
