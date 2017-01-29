using SudokuSolver.Interfaces;
using System;
using System.Collections.Generic;

namespace SudokuSolver.Models
{
    public class Column : AbstractCellContainer, ICellCollection
    {
        public Column(int number, ICollection<Cell> cells = default(List<Cell>)) : base(number, cells)
        {
        }
    }
}