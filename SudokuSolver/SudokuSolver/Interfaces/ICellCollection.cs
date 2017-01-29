using SudokuSolver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
