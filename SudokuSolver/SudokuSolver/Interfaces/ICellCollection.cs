using SudokuSolver.Models;

namespace SudokuSolver.Interfaces
{
    public interface ICellCollection
    {
        /// <summary>
        /// Add the cell to the collection
        /// </summary>
        /// <param name="cell">Cell being added to the collection</param>
        void AddCell(Cell cell);
    }
}