using SudokuSolver.Models;
using System;

namespace SudokuSolver.Helper
{
    public static class CellFinder
    {
        /// <summary>
        /// Gets the grid reference from the index provided
        /// </summary>
        /// <param name="index">The index</param>
        /// <returns>The cell reference</returns>
        /// <exception cref="ArgumentException">Index out of range</exception>
        public static GridReference GetGridReference(int index)
        {
            return new GridReference(GetRowNumber(index), GetColumnNumber(index), GetBlockNumber(index));
        }

        /// <summary>
        /// Gets the row number from the index provided
        /// </summary>
        /// <param name="index">The index</param>
        /// <returns>The row number</returns>
        /// <exception cref="ArgumentException">Index out of range</exception>
        public static int GetRowNumber(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("Index is too small");
            }
            if (index > 81)
            {
                throw new ArgumentException("Index is too high");
            }

            return ((index - (index % 9)) / 9) + 1;
        }

        /// <summary>
        /// Gets the column number from the index provided
        /// </summary>
        /// <param name="index">The index</param>
        /// <returns>The column number</returns>
        /// <exception cref="ArgumentException">Index out of range</exception>
        public static int GetColumnNumber(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("Index is too small");
            }
            if (index > 81)
            {
                throw new ArgumentException("Index is too high");
            }

            return (index % 9) + 1;
        }

        /// <summary>
        /// Gets the block number from the index provided
        /// </summary>
        /// <param name="index">The index</param>
        /// <returns>The block number</returns>
        /// <exception cref="ArgumentException">Index out of range</exception>
        public static int GetBlockNumber(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("Index is too small");
            }
            if (index > 81)
            {
                throw new ArgumentException("Index is too high");
            }

            return GetBlockNumber(GetRowNumber(index), GetColumnNumber(index));
        }

        /// <summary>
        /// Gets the block number from the provided row and column
        /// </summary>
        /// <param name="row">The row number</param>
        /// <param name="column">The column number</param>
        /// <returns>The block number</returns>
        public static int GetBlockNumber(int row, int column)
        {
            if (row < 1 || row > 9)
            {
                throw new ArgumentException("Row is out of range");
            }
            if (column < 1 || column > 9)
            {
                throw new ArgumentException("Column is out of range");
            }

            int rowIndex = GetIndex(row);
            int columnIndex = GetIndex(column);

            int[,] array = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            return array[rowIndex, columnIndex];
        }

        private static int GetIndex(int number)
        {
            return (int)Math.Ceiling(number / 3d) - 1;
        }
    }
}