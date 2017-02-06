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

            return GetBlockNumber(GetRowNumber(index) - 1, GetColumnNumber(index) - 1);
        }

        /// <summary>
        /// Gets the block number from the provided row and column
        /// </summary>
        /// <param name="row">The row number</param>
        /// <param name="column">The column number</param>
        /// <returns>The block number</returns>
        public static int GetBlockNumber(int row, int column)
        {
            if (row < 3)
            {
                if (column < 3)
                {
                    return 1;
                }
                else if (column < 6)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
            else if (row < 6)
            {
                if (column < 3)
                {
                    return 4;
                }
                else if (column < 6)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
            else
            {
                if (column < 3)
                {
                    return 7;
                }
                else if (column < 6)
                {
                    return 8;
                }
                else
                {
                    return 9;
                }
            }
        }
    }
}