using System;
using System.IO;

namespace SudokuSolver.Repositories.Input.Reader
{
    public class ReaderConcrete : IReader
    {
        public StreamReader OpenFile(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentException("File name can't be empty");
            }
            if (!File.Exists(fileName))
            {
                throw new IOException("Unable to find file");
            }

            return new StreamReader(fileName);
        }
    }
}
