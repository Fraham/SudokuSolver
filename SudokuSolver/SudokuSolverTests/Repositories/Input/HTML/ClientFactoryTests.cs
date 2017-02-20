using NUnit.Framework;
using html = SudokuSolver.Repositories.Input.HTML;
using SudokuSolver.Repositories;

namespace SudokuSolverTests.Repositories.Input.HTML
{
    [TestFixture]
    public class ClientFactoryTests
    {
        [Test]
        public void ClientFactory_GetClient_Success()
        {
            Assert.AreEqual(typeof(html.HTMLFake), html.ClientFactory.GetClient().GetType());
        }

        [Test]
        public void ClientFactory_GetClient_Fake_Success()
        {
            Assert.AreEqual(typeof(html.HTMLFake), html.ClientFactory.GetClient(FakeEnum.Fake).GetType());
        }

        [Test]
        public void ClientFactory_GetClient_Real_Success()
        {
            Assert.AreEqual(typeof(html.HTMLClient), html.ClientFactory.GetClient(FakeEnum.Real).GetType());
        }
    }
}
