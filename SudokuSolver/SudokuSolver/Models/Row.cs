using SudokuSolver.Interfaces;
using System;
using System.Collections.Generic;

namespace SudokuSolver.Models
{
    public class Row : AbstractCellContainer, ICellCollection
    {
        public Row(int number, ICollection<Cell> cells = default(List<Cell>)) : base(number, cells)
        {
        }
    }
}