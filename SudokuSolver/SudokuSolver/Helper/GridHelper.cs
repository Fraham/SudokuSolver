using SudokuSolver.Models;
using System;
using System.Collections.Generic;

namespace SudokuSolver.Helper
{
    public static class GridHelper
    {
        /// <summary>
        /// Makes a new grid from the number providied
        /// </summary>
        /// <param name="numbers">The entry number for the new cells</param>
        /// <returns>A new grid</returns>
        public static Grid Get(ICollection<int> numbers)
        {
            if (numbers.Count != 81)
            {
                throw new ArgumentException("Not the right amount of numbers provided");
            }

            var cells = new List<Cell>();

            foreach (var number in numbers)
            {
                if (number != 0)
                {
                    cells.Add(new Cell(number, new List<int>()));
                }
                else
                {
                    cells.Add(new Cell(availableOptions: new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
                }
            }

            return new Grid(cells);
        }
    }
}