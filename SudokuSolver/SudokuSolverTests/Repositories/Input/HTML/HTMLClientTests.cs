using System;
using NUnit.Framework;
using html = SudokuSolver.Repositories.Input.HTML;

namespace SudokuSolverTests.Repositories.Input.HTML
{
    [TestFixture]
    public class HTMLClientTests
    {
        [Test]
        [TestCase("http://google.com")]
        [TestCase("http://facebook.com")]
        public void HTMLClient_GetHTML_Success(string url)
        {
            var html = new html.HTMLClient().GetHTML(url);

            Assert.NotNull(html);
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void HTMLClient_GetHTML_InvalidFileName_Failure(string fileName)
        {
            var client = new html.HTMLClient();
            var ex = Assert.Throws<ArgumentException>(delegate { client.GetHTML(fileName); });

            Assert.AreEqual("URL is not valid", ex.Message);
        }

        [TestCase("cheese")]
        [TestCase("..")]
        [TestCase(".hello.")]
        public void HTMLClient_GetHTML_InvalidURL_Failure(string fileName)
        {
            var client = new html.HTMLClient();
            var ex = Assert.Throws<UriFormatException>(delegate { client.GetHTML(fileName); });

            Assert.AreEqual("Invalid URI: The format of the URI could not be determined.", ex.Message);
        }
    }
}
