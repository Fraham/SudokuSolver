using SudokuSolver.Interfaces;
using System;
using System.Collections.Generic;

namespace SudokuSolver.Models
{
    public class Block : AbstractCellContainer, ICellCollection
    {
        public Block(int number, ICollection<Cell> cells = default(List<Cell>)) : base (number, cells)
        {
        }
    }
}