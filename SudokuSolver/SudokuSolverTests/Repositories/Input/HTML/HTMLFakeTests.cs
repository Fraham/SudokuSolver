using System;
using NUnit.Framework;
using html = SudokuSolver.Repositories.Input.HTML;

namespace SudokuSolverTests.Repositories.Input.HTML
{
    [TestFixture]
    public class HTMLFakeTests
    {
        [Test]
        [TestCase("http://show.websudoku.com/?level=3")]
        public void HTMLFake_GetHTML_Success(string url)
        {
            var fakeHtml = new html.HTMLFake();

            Assert.NotNull(fakeHtml.GetHTML(url));
        }

        [Test]
        [TestCase("http://google.com")]
        [TestCase("http://facebook.com")]
        [TestCase("http://bbc.co.uk")]
        public void HTMLFake_GetHTML_NotFoundURL_Failure(string url)
        {
            var fakeHtml = new html.HTMLFake();
            var ex = Assert.Throws<ArgumentException>(delegate { fakeHtml.GetHTML(url); });

            Assert.AreEqual($"Unable to find url", ex.Message);
        }

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void HTMLFake_GetHTML_EmptyURL_Failure(string url)
        {
            var fakeHtml = new html.HTMLFake();
            var ex = Assert.Throws<ArgumentException>(delegate { fakeHtml.GetHTML(url); });

            Assert.AreEqual($"URL can't be empty", ex.Message);
        }
    }
}
