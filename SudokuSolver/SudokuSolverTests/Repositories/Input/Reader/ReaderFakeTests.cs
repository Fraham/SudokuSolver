using NUnit.Framework;
using System;
using System.IO;
using Repo = SudokuSolver.Repositories.Input.Reader;

namespace SudokuSolverTests.Repositories.Input.Reader
{
    [TestFixture]
    public class ReaderFakeTests
    {
        [TestCase("file1")]
        [TestCase("file2")]
        public void ReaderFake_OpenFile_Success(string fileName)
        {
            using (var stream = Repo.ReaderFactory.GetReader().OpenFile(fileName))
            {
                Assert.AreEqual(fileName + Environment.NewLine,stream.ReadToEnd());
            }
        }
        
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ReaderFake_OpenFile_InvalidFileName_Failure(string fileName)
        {
            var ex = Assert.Throws<ArgumentException>(delegate { Repo.ReaderFactory.GetReader().OpenFile(fileName); });

            Assert.AreEqual("File name can't be empty",ex.Message);
        }

        [TestCase("1")]
        [TestCase("file3")]
        public void ReaderFake_OpenFile_FileDoesntExist_Failure(string fileName)
        {
            var ex = Assert.Throws<IOException>(delegate { Repo.ReaderFactory.GetReader().OpenFile(fileName); });

            Assert.AreEqual("Unable to find file",ex.Message);
        }
    }
}