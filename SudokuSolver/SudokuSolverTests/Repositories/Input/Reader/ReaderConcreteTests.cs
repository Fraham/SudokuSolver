using NUnit.Framework;
using System;
using System.IO;

using Repo = SudokuSolver.Repositories.Input.Reader;

namespace SudokuSolverTests.Repositories.Input.Reader
{
    [TestFixture]
    public class ReaderConcreteTests
    {
        [OneTimeSetUp]
        public void FixtureSetup()
        {
            using (StreamWriter writer = new StreamWriter("file1"))
            {
                writer.WriteLine("file1");
            }

            using (StreamWriter writer = new StreamWriter("file2"))
            {
                writer.WriteLine("file2");
            }
        }

        [OneTimeTearDown]
        public void FixtureTeardown()
        {
            if (File.Exists("file1"))
            {
                File.Delete("file1");
            }

            if (File.Exists("file2"))
            {
                File.Delete("file2");
            }
        }

        [TestCase("file1")]
        [TestCase("file2")]
        public void ReaderConcrete_OpenFile_Success(string fileName)
        {
            using (var stream = Repo.ReaderFactory.GetReader().OpenFile(fileName))
            {
                Assert.AreEqual(fileName + "\r\n", stream.ReadToEnd());
            }
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ReaderConcrete_OpenFile_InvalidFileName_Failure(string fileName)
        {
            var ex = Assert.Throws<ArgumentException>(delegate { Repo.ReaderFactory.GetReader().OpenFile(fileName); });

            Assert.AreEqual("File name can't be empty", ex.Message);
        }

        [TestCase("1")]
        [TestCase("file3")]
        public void ReaderConcrete_OpenFile_FileDoesntExist_Failure(string fileName)
        {
            var ex = Assert.Throws<IOException>(delegate { Repo.ReaderFactory.GetReader().OpenFile(fileName); });

            Assert.AreEqual("Unable to find file", ex.Message);
        }
    }
}