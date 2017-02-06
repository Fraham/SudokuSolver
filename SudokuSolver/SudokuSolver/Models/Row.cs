using SudokuSolver.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Models
{
    public class Row : AbstractCellContainer, ICellCollection
    {
        public Row(int number, ICollection<Cell> cells = default(List<Cell>)) : base(number, cells)
        {
        }

        public new string ToString
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("|");

                foreach (var cell in Cells)
                {
                    string text = cell.ToString;

                    sb.Append($" {text} |");
                }

                return sb.ToString();
            }
        }
    }
}