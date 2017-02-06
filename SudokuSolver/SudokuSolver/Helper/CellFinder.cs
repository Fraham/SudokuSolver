using SudokuSolver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Helper
{
    public class CellFinder
    {
        public static GridReference GetGridReference(int index)
        {
            return new GridReference(GetRowNumber(index), GetColumnNumber(index), GetBlockNumber(index));
        }

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

            if (index < 9)
            {
                return 1;
            }
            else if (index < 18)
            {
                return 2;
            }
            else if (index < 27)
            {
                return 3;
            }
            else if (index < 36)
            {
                return 4;
            }
            else if (index < 45)
            {
                return 5;
            }
            else if (index < 54)
            {
                return 6;
            }
            else if (index < 63)
            {
                return 7;
            }
            else if (index < 72)
            {
                return 8;
            }
            else
            {
                return 9;
            }
        }

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
