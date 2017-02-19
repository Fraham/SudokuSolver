using System;
using NUnit.Framework;
using html = SudokuSolver.Repositories.Input.HTML;

namespace SudokuSolverTests.Repositories.Input.HTML
{
    [TestFixture]
    public class ReaderTests
    {
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ReaderHTML_GetGrid_InvalidFileName_Failure(string fileName)
        {
            var reader = new html.Reader();
            var ex = Assert.Throws<ArgumentException>(delegate { reader.GetGrid(fileName); });

            Assert.AreEqual("URL is not valid", ex.Message);
        }

        [TestCase("cheese")]
        [TestCase("..")]
        [TestCase(".hello.")]
        public void ReaderHTML_GetGrid_InvalidURL_Failure(string fileName)
        {
            var reader = new html.Reader();
            var ex = Assert.Throws<UriFormatException>(delegate { reader.GetGrid(fileName); });

            Assert.AreEqual("Invalid URI: The format of the URI could not be determined.", ex.Message);
        }

        [TestCase("http://google.com")]
        [TestCase("http://facebook.com")]
        [TestCase("http://bbc.co.uk")]
        public void ReaderHTML_GetGrid_URLNotFound_Failure(string fileName)
        {
            var reader = new html.Reader();
            var ex = Assert.Throws<ArgumentException>(delegate { reader.GetGrid(fileName); });

            Assert.AreEqual($"{fileName} is not supported", ex.Message);
        }
    }
}
