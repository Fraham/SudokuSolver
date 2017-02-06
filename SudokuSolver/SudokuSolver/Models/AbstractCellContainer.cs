using SudokuSolver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Models
{
    public class AbstractCellContainer : ICellCollection
    {
        private ICollection<Cell> cells = new List<Cell>();
        private int number;

        private ICollection<int> optionsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public static string Id = "None";

        public AbstractCellContainer(int number, ICollection<Cell> cells = default(List<Cell>))
        {
            Cells = cells ?? new List<Cell>();
            Number = number;
        }

        public ICollection<Cell> Cells
        {
            get
            {
                return cells;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Cells can not be null");
                }
                if (value.Count > 9)
                {
                    throw new ArgumentException("Can not have more than 9 cells");
                }

                cells = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                if (value > 9)
                {
                    throw new ArgumentException("Number can not be greater than 9");
                }
                if (value < 1)
                {
                    throw new ArgumentException("Number can not be less than 1");
                }

                number = value;
            }
        }

        public void AddCell(Cell cell)
        {
            Cells.Add(cell);
        }

        public void ProcessCells()
        {
            if (optionsLeft.Count > 0)
            {
                foreach (var cell in Cells)
                {
                    if (cell.AvailableOptions.Count == 1)
                    {
                        cell.Entry = cell.AvailableOptions.First();

                        cell.AvailableOptions = new List<int>();

                        RemoveOption(cell.Entry.Value);
                    }
                }
            }
        }

        public void ReduceCells()
        {
            foreach (var cell in Cells)
            {
                if (cell.Entry != null)
                {
                    RemoveOption(cell.Entry.Value);
                }
            }
        }

        public void BigTask()
        {
            foreach (var number in optionsLeft)
            {
                if (Cells.Count(op => op.AvailableOptions.Contains(number)) == 1)
                {
                    var cell = Cells.First(op => op.AvailableOptions.Contains(number));

                    cell.Entry = number;

                    cell.AvailableOptions = new List<int>();

                    RemoveOption(cell.Entry.Value);

                    break;
                }
            }
        }

        public void RemoveOption(int option)
        {
            optionsLeft.Remove(option);

            foreach (Cell cell in Cells)
            {
                cell.RemoveOption(option);
            }
        }
    }
}
