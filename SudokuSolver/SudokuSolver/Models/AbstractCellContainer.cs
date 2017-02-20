using SudokuSolver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver.Models
{
    public class AbstractCellContainer : ICellCollection
    {
        private ICollection<Cell> cells = new List<Cell>();
        private int number;

        private ICollection<int> optionsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public AbstractCellContainer(int number, ICollection<Cell> cells = default(List<Cell>))
        {
            Cells = cells ?? new List<Cell>();
            Number = number;
        }

        /// <summary>
        /// Cells for the collection
        /// </summary>
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

        /// <summary>
        /// The number of the collection
        /// </summary>
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

        /// <summary>
        /// Adds a cell to the collection
        /// </summary>
        /// <param name="cell">The cell being added</param>
        public void AddCell(Cell cell)
        {
            Cells.Add(cell);
        }

        /// <summary>
        /// Processes cells which only have one option left
        /// </summary>
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

        /// <summary>
        /// Removes the option from all the cells in the collection once a new entry has been found
        /// </summary>
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

        /// <summary>
        /// If only one cell has an option left in the collection it will set that cell to be the option
        /// </summary>
        public void ProcessSingleOptionLeftInCollection()
        {
            for (int i = 0; i < optionsLeft.Count; i++)
            {
                var number = optionsLeft.ToArray()[i];

                if (Cells.Count(op => op.AvailableOptions.Contains(number)) == 1)
                {
                    var cell = Cells.First(op => op.AvailableOptions.Contains(number));

                    cell.Entry = number;

                    cell.AvailableOptions = new List<int>();

                    RemoveOption(cell.Entry.Value);
                }
            }
        }

        /// <summary>
        /// Removes the option from the collection and all the cells in the collection
        /// </summary>
        /// <param name="option">The option being removed</param>
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