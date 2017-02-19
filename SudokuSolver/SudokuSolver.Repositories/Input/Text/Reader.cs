using SudokuSolver.Repositories.Input.Reader;
using System;
using System.Linq;

namespace SudokuSolver.Repositories.Input.Text
{
    public class Reader : IInput
    {
        public int[] GetGrid(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName) || !fileName.EndsWith(".txt"))
            {
                throw new ArgumentException("File name should end with .txt");
            }

            return ReaderFactory.GetReader().OpenFile(fileName).ReadToEnd()
                .Replace($" {Environment.NewLine}", "")
                .Replace($"{Environment.NewLine}", "")
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();
        }
    }
}
