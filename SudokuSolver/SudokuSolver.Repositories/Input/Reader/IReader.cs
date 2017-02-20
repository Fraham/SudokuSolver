using System.IO;

namespace SudokuSolver.Repositories.Input.Reader
{
    public interface IReader
    {
        StreamReader OpenFile(string fileName);
    }
}
