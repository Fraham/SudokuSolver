namespace SudokuSolver.Repositories.Input
{
    public interface IInput
    {
        int[] GetGrid(string fileName);
    }
}